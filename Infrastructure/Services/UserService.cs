using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.VisualBasic;
using Npgsql;
using Domain.DTO;
namespace Infrastructure.Services;

public class UserService
{
    private readonly DataContext context = new DataContext();

    public List<Users> GetAllUsers()
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"select * from users";
            var result = connection.Query<Users>(sql).ToList();
            return result;
        }
    } 
    public void CreateUsers(Users users)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"insert into users (fullName, email, phone) 
                        values (@fullName, @email, @phone)";
            var result = connection.Execute(sql,users);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void UpdateUsers(Users users)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"update users set fullName = @FullName, email = @Email, phone = @Phone where id = @Id";
            var result = connection.Execute(sql,users);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void DeleteUsers(Users users)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"delete from users where id = @id";
            var result = connection.Execute(sql,users);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    //task1
    public List<Users> SearchByEmailOrName(string text)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var cmd = $@"select * from users WHERE fullname LIKE @name OR email LIKE @email";
            var result = connection.Query<Users>(cmd, new { Name = $"%{text}%", Email = $"%{text}%"}).ToList();
            return result;
        }
    }
    //task7
    public List<UserMarketCount> GetUserMarketCounts()
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"select u.fullName as user_name, count(m.id) as market_count
                        from users u
                        left join markets m on m.userId = u.id
                        group by u.id;";
            var result = connection.Query<UserMarketCount>(sql).ToList();
            return result;
        }
    } 
}
