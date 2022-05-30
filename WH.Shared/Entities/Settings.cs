using System.Configuration;

namespace WH.Shared.Entities
{
    public class Settings
    {
        private static string? _csvDataPath;
        public static string? CsvDataPath
        {
            get
            {
                return _csvDataPath ?? String.Empty;
            }
        }

        private static string? _csvComboPath;
        public static string CsvComboPath
        {
            get
            {
                return _csvComboPath ?? String.Empty;
            }
        }

        private static string? _dataSourceType;
        public static string DataSourceType
        {
            get
            {
                return _dataSourceType ?? String.Empty;
            }
        }

        public Settings(string dataSourceType, string csvDataPath, string csvComboPath)
        {
            if (string.IsNullOrWhiteSpace(_dataSourceType))
            {
                _dataSourceType = dataSourceType ?? string.Empty;
            }
            if (string.IsNullOrWhiteSpace(_csvDataPath))
            {
                _csvDataPath = csvDataPath ?? string.Empty;
            }
            if (string.IsNullOrWhiteSpace(_csvComboPath))
            {
                _csvComboPath = csvComboPath ?? string.Empty;
            }
        }
    }
}