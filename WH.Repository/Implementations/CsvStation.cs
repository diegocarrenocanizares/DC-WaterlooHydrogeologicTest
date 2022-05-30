using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WH.Repository.Implementations
{
    internal class CsvStation
    {
        [Name("StationName")]
        public string StationName { get; set; }
        [Name("screen_id")]
        public string ScreenId { get; set; }
        [Name("date")]
        public string Date { get; set; }
        [Name("depth_to_water_level")]
        public string DepthToWaterLvl { get; set; }
        [Name("comment")]
        public string Comment { get; set; }
    }
}
