using Microsoft.Data.SqlClient;
using Dapper;
using GestorTareas.Models.Entities;

namespace GestorTareas.Services
{
    public interface IUserRepository
    {
        Task<int> CreateUser(User user);
        Task<User> SearchUserByEmail(string NormalizedEmail);
    }

    public class UserRepository: IUserRepository
    {
        private readonly string connectionString;
        public UserRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<int> CreateUser(User user)
        {
            using var connection = new SqlConnection(connectionString);
            user.Username = user.Email.Split('@')[0];
            user.Name = user.Email.Split('@')[0];
            user.Lastname = "";
            user.CreatedAt = DateTime.UtcNow;
            user.UpdatedAt = DateTime.UtcNow;

            var id = await connection.QuerySingleAsync<int>(@"
            INSERT INTO Users (Username, Name, Lastname, Email, NormalizedEmail, Password, CreatedAt, UpdatedAt) 
            VALUES (@Username, @Name, @Lastname, @Email, @NormalizedEmail, @Password, @CreatedAt, @UpdatedAt) SELECT SCOPE_IDENTITY();", 
            user);

            return id;
        }

        public async Task<User> SearchUserByEmail(string NormalizedEmail)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QuerySingleOrDefaultAsync<User>(
                "SELECT * FROM Users WHERE NormalizedEmail = @NormalizedEmail", 
                new { NormalizedEmail }
            );
        }
    }
}
