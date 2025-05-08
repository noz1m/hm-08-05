using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.VisualBasic;
using Npgsql;
using Domain.DTO;
namespace Infrastructure.Interface;

public interface IUserService
{
    List<Users> GetAllUsers();
    void CreateUsers(Users users);
    void UpdateUsers(Users users);
    void DeleteUsers(Users users);
    List<Users> SearchByEmailOrName();
    List<UserMarketCount> GetUserMarketCounts();
}
