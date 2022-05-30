using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using WH.Shared.Entities;

namespace WH.Repository.Implementations
{
    public class CsvRepository : Repository
    {
        private string _dataFilePath;
        private string _csvComboPath;
        public CsvRepository(string dataFilePath, string csvComboPath)
        {
            _dataFilePath = dataFilePath;
            _csvComboPath = csvComboPath;
            if (Data == null)
            {
                GetAll();
                GetAllComboList();
            }
        }

        public override int Add(Station s)
        {
            try
            {
                s.Id = (Data?.Max(x=>x.Id) ?? 0) + 1;
                Data?.Add(s);
                return s.Id;
            } catch { return 0; }
        }

        public override bool Delete(Station s)
        {
            try
            {
                var recordToDelete = Data?.FirstOrDefault(x=>x.Id == s.Id);
                if(recordToDelete != null)
                {
                    Data?.Remove(recordToDelete);
                    return true;
                }
            }
            catch { }
            return false;
        }

        public override Station? Get(int id)
        {
            try
            {
                return Data?.FirstOrDefault(x => x.Id == id);
            }
            catch { }
            return null;
        }

        public override List<Station> GetAll()
        {
            if (!(Data?.Any() ?? false))
            {
                Data = new List<Station>();

                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    PrepareHeaderForMatch = args => args.Header.ToLower(),
                    IgnoreBlankLines = true,
                };

                using (var reader = new StreamReader(_dataFilePath))
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Read();
                    csv.ReadHeader();
                    while (csv.Read())
                    {
                        var csvRecord = csv.GetRecord<CsvStation>();

                        if(!string.IsNullOrWhiteSpace(csvRecord.StationName) 
                            && !string.IsNullOrWhiteSpace(csvRecord.StationName)
                            && !string.IsNullOrWhiteSpace(csvRecord.Date)
                            && !string.IsNullOrWhiteSpace(csvRecord.DepthToWaterLvl)
                            && !string.IsNullOrWhiteSpace(csvRecord.Comment))
                        {
                            var record = csv.GetRecord<Station>();
                            record.Id = (Data?.Count() ?? 0) + 1;
                            Data?.Add(record);
                        }
                    }
                }
            }
            return Data;
        }

        public override List<ComboExample> GetAllComboList()
        {
            if (!(ComboList?.Any() ?? false))
            {
                ComboList = new List<ComboExample>();

                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    PrepareHeaderForMatch = args => args.Header.ToLower(),
                    IgnoreBlankLines = true,
                };

                using (var reader = new StreamReader(_csvComboPath))
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Read();
                    csv.ReadHeader();
                    while (csv.Read())
                    {
                        var record = csv.GetRecord<ComboExample>();
                        ComboList?.Add(record);
                    }
                }
            }
            return ComboList;
        }

        public override bool Update(Station s)
        {
            try
            {
                var current = Data?.FirstOrDefault(x => x.Id == s.Id);
                if (current != null)
                {
                    current.StationName = s.StationName;
                    current.ScreenId = s.ScreenId;
                    current.Date = s.Date;
                    current.DepthToWaterLvl = s.DepthToWaterLvl;
                    current.Comment = s.Comment;
                    return true;
                }
            }
            catch { }
            return false;
        }
    }
}