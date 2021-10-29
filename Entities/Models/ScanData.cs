using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public partial class ScanData
    {
        [Key]
        [Column("ScanId")]
        public int Id { get; set; }

        [Column("camid")]
        public string Camid { get; set; }

        [Column("devid")]
        public string Devid { get; set; }

        [Column("devmac")]
        public string Devmac { get; set; }

        [Column("devname")]
        public string Devname { get; set; }

        [Column("devno")]
        public string Devno { get; set; }

        [Column("event")]
        public string Event { get; set; }

        public ICollection<Face> Faces { get; set; }

        [Column("operator")]
        public string Operator { get; set; }

        [Column("time")]
        public int Time { get; set; }

        [Column("timelocal")]
        public int Timelocal { get; set; }

        [Column("type")]
        public string Type { get; set; }

        public DateTime PublishedDate { get; set; } = DateTime.Now;

        public string GetScanLocation()
        {
            return $"{this.Devid}, {this.Devname}";
        }
    }

    public partial class ScanData
    {
        public static ScanData FromJson(string json) => JsonConvert.DeserializeObject<ScanData>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ScanData self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
