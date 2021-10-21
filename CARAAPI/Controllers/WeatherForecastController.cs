﻿using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CARAAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryManager _repository;

        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            //_repository.Company.AnyMethodFromCompanyRepository();
            //_repository.Employee.AnyMethodFromEmployeeRepository();

            return new string[] { "value1", "value2" };
        }
        //private ILoggerManager _logger;

        //public WeatherForecastController(ILoggerManager logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    _logger.LogInfo("Info message from our controller.");
        //    _logger.LogDebug("Debug message from our controller.");
        //    _logger.LogWarn("Warn message from our controller.");
        //    _logger.LogError("Error message from our controller.");

        //    return new string[] { "value1", "value2" };
        //}
    }
}

//[ApiController]
//[Route("[controller]")]
//public class WeatherForecastController : ControllerBase
//{
//    private static readonly string[] Summaries = new[]
//    {
//            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };

//    private readonly ILogger<WeatherForecastController> _logger;

//    public WeatherForecastController(ILogger<WeatherForecastController> logger)
//    {
//        _logger = logger;
//    }

//    [HttpGet]
//    public IEnumerable<WeatherForecast> Get()
//    {
//        var rng = new Random();
//        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//        {
//            Date = DateTime.Now.AddDays(index),
//            TemperatureC = rng.Next(-20, 55),
//            Summary = Summaries[rng.Next(Summaries.Length)]
//        })
//        .ToArray();
//    }
//}