using Dapper;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class MarketService
{
    private readonly DataContext context = new DataContext();

    public List<Markets> GetAllMarkets()
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"select * from markets";
            var result = connection.Query<Markets>(sql).ToList();
            return result;
        }
    }
    public void CreateMarket(Markets markets)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"insert into markets (id,name,address,userId)
                        values (@id, @name, @address,@userId) ";
            var result = connection.Execute(sql,markets);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void UpdateMarket(Markets markets)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"update markets set name = @name, address = @address where id = @id";
            var result = connection.Execute(sql,markets);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void DeleteMarket(Markets markets)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"delete from markets where id = @id";
            var result = connection.Execute(sql,markets);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
}
