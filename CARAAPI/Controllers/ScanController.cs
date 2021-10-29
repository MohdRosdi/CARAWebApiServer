using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CARAAPI.Controllers
{
    [Route("api/scandata")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class ScanController : ControllerBase
    {
        private readonly IRepositoryManager _context;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ScanController(IRepositoryManager context, ILoggerManager logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpOptions]
        public IActionResult GetScanOptions()
        {
            Response.Headers.Add("Allow", "OPTIONS, SEARCH, POST");
            return Ok();
        }

        [HttpGet] 
        public IActionResult GetScansData() 
        { 
            try 
            { 
                var scanData = _context.ScanData.GetAllScannedData(trackChanges: false);
                //var scanDTO1 = scanData.Select(d => new ScanDto 
                //{
                    
                //}).ToList();

                var scanDto = _mapper.Map<IEnumerable<ScanDto>>(scanData);
                return Ok(scanDto);
            } 

            catch (Exception ex) 
            { 
                _logger.LogError($"Something went wrong in the {nameof(GetScansData)} action {ex}"); 
                return StatusCode(500, "Internal server error"); 
            } 
        }
    }
}
