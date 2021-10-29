using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ScanDto
    {
        
        public string name { get; set; }
        public string ScanLocation { get; set; }
        public double temperature { get; set; }
        
        public double FaceTemperature { get; set; }
        
        public long timestamp { get; set; }
        
        public string userId { get; set; }
        
        public string image { get; set; }
        
        

    }
}
