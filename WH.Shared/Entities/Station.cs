using CsvHelper.Configuration.Attributes;

namespace WH.Shared.Entities
{
    public class Station
    {
        [Ignore]
        public int Id { get; set; }
        [Name("StationName")]
        public string StationName { get; set; }
        [Name("screen_id")]
        public string ScreenId { get; set; }
        [Name("date")]
        public DateTime Date { get; set; }
        [Name("depth_to_water_level")]
        public float DepthToWaterLvl { get; set; }
        [Name("comment")]
        public string Comment { get; set; }

        public Station() {
            this.StationName = String.Empty;
            this.Comment = String.Empty;
        }

        public Station(int id, string stationName, string screenId, DateTime date, float depthToWaterLvl, string comment)
        {
            Id = id;
            StationName = stationName;
            ScreenId = screenId;
            Date = date;
            DepthToWaterLvl = depthToWaterLvl;
            Comment = comment;
        }
    }
}