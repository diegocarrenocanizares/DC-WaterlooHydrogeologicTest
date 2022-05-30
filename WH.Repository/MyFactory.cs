using WH.Repository.Implementations;
using WH.Shared.Entities;
using WH.Shared.Enum;

namespace WH.Repository
{
    public class MyFactory
    {
        public static Repository CreateDataSourceRepository()
        {
            var sourceType = Enum.Parse<SourceTypeEnum>(Settings.DataSourceType ?? string.Empty);
            switch (sourceType)
            {
                case SourceTypeEnum.CSV:
                    return new CsvRepository(Settings.CsvDataPath ?? string.Empty, Settings.CsvComboPath ?? string.Empty);
                default:
                    return new CsvRepository(Settings.CsvDataPath ?? string.Empty, Settings.CsvComboPath ?? string.Empty);
            }
        }
    }
}