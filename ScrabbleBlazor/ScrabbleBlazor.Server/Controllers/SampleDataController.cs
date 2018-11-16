using ScrabbleBlazor.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrabbleBlazor.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SampleDataController : ControllerBase
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public IEnumerable<Table> GetScrabbleTable()
        {
            Table scrabbbleTable = new Table();
            List<List<TableSquare>> table = new List<List<TableSquare>>
            {
                 new List<TableSquare>{ new TableSquare('a'), new TableSquare('a'), new TableSquare('a') },
                 new List<TableSquare>{ new TableSquare('b'), new TableSquare('b'), new TableSquare('b') },
                 new List<TableSquare>{ new TableSquare('c'), new TableSquare('c'), new TableSquare('c') },
                 new List<TableSquare>{ new TableSquare('d'), new TableSquare('c'), new TableSquare('c') },
                 new List<TableSquare>{ new TableSquare('r'), new TableSquare('c'), new TableSquare('h') },
                 new List<TableSquare>{ new TableSquare('g'), new TableSquare('c'), new TableSquare('f') }

            };
            scrabbbleTable.Squares = table;
            scrabbbleTable.PlayerCount = 5;
            return new List<Table>() { scrabbbleTable };
        }
    }
}
