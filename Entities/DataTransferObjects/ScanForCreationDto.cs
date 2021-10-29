using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ScanForCreationDto
    {
        [Column("devid")]
        public string Devid { get; set; }
        [Column("devname")]
        public string Devname { get; set; }

        [Column("operator")]
        public string Operator { get; set; }

        [Column("time")]
        public string Time { get; set; }

        [Column("timelocal")]
        public string Timelocal { get; set; }

        public DateTime PublishedDate { get; set; }

        public ICollection<Face> Faces { get; set; }

    }
}
