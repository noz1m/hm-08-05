using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.VisualBasic;
using Npgsql;
using Domain.DTO;
namespace Infrastructure.Interface;

public interface IMarketService
{
    List<Markets> GetAllMarkets();
    void CreateMarket(Markets market);
    void UpdateMarket(Markets market);
    void DeleteMarket(Markets market);
}
