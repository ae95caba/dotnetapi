using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_api.Dtos.Stock;
using dotnet_api.Models;

namespace dotnet_api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel){
           /*  The this keyword in the parameter signifies that this is an extension method to the Stock model , and stockModel will refer to the Stock object on which the method is called. Example: myStock.ToStockDto();*/
              return new StockDto {Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap};
        }
    }
}