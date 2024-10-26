
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_api.Data;
using dotnet_api.Mappers;
using Microsoft.AspNetCore.Mvc;



namespace dotnet_api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public StockController(ApplicationDbContext context)
        {
            _context = context; 
            
        }
        [HttpGet]
        public IActionResult GetALL(){
            //Select is the same thing as a map on js
            var stocks = _context.Stocks.ToList().Select( s => s.ToStockDto());
            return Ok(stocks);
        }
        [HttpGet("({id})")]
        public IActionResult GetById([FromRoute] int id){
            var stock = _context.Stocks.Find(id);
            if(stock == null){
                return NotFound();
            }
            return Ok(stock.ToStockDto());
        }
    }
}