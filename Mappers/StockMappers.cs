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
        //for responding to get requests , just ignore the comments prop
        public static StockDto ToStockDto(this Stock stockModel){
           /*  The this keyword in the parameter signifies that this is an extension method to the Stock model , and stockModel will refer to the Stock object on which the method is called. Example: myStock.ToStockDto();*/
              return new StockDto {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap};
                //there will be no comments prop
        }
        public static Stock ToStockFromCreateDto(this CreateStockRequestDto stockDto) {
            return new Stock
            {
                //id will use auto increment, default even if not set manually
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                LastDiv = stockDto.LastDiv,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
                //comments will use default set, empty array
            };
        }
    }
}