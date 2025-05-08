using Domain.DTO;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

var userService = new UserService();
var result = userService.SearchByEmailOrName();
foreach (var item in result)
{
    Console.WriteLine(item);
}

var marketService = new MarketService();
var result1 = marketService.GetAllMarkets();
foreach (var item in result1)
{
    Console.WriteLine(item);
}

var categoryService = new CategoryService();
var result2 = categoryService.GetAllCategory();
foreach (var item in result2)
{
    Console.WriteLine(item);
}

var userMarketCountService = new UserService();
var result3 = userMarketCountService.GetUserMarketCounts();
foreach (var item in result3)
{
    Console.WriteLine(item);
}