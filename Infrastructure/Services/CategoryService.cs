using Dapper;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class CategoryService
{
    private readonly DataContext context = new DataContext();

    public List<Category> GetAllCategory()
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"select * from category";
            var result = connection.Query<Category>(sql).ToList();
            return result;
        }
    }
    public void CreateCategory(Category category)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"insert int category (id,name)
            values(@did, @name)";
            var result = connection.Execute(sql,category);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void UpdateCategory(Category category)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"update category set name = @name where id = @id";
            var result = connection.Execute(sql,category);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void DeleteCategory(Category category)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"delete from category where id = @id";
            var result = connection.Execute(sql,category);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    //task5
    public string UpdatePricesByCategoryId(Category category)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"update products set price = price * 1.1 where categoryId = @id";
            var result = connection.Execute(sql,category);
            return result > 0 ? "Success" : "Failed";
        }
    }
}
