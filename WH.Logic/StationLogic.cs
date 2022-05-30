using WH.Repository;
using MasterRepo = WH.Repository.Repository;
using WH.Shared.Entities;
using WH.Shared.Enum;

namespace WH.Logic
{
    public class StationLogic
    {
        private MasterRepo _repository;
        public StationLogic()
        
        {
            _repository = MyFactory.CreateDataSourceRepository();
        }

        public int Add(Station s)
        {
            return _repository.Add(s);
        }

        public Station? Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Station> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Delete(Station s)
        {
            return _repository.Delete(s);
        }

        public bool Update(Station s)
        {
            return _repository.Update(s);
        }

        public List<ComboExample> GetAllComboList()
        {
            return _repository.GetAllComboList();
        }

        public bool UpdateColumns(List<int> columnsIndex)
        {
            try
            {
                var columns = columnsIndex.Select(x => (StationColumnIndex)x).ToList();
                foreach (var item in _repository.GetAll())
                {
                    columns.ForEach(x =>
                    {
                        switch (x)
                        {
                            case StationColumnIndex.StationName:
                                item.StationName = item.StationName.Replace("a", "@").Replace("A", "@");
                                break;
                            case StationColumnIndex.ScreenId:
                                item.ScreenId = item.ScreenId.Replace("a", "@").Replace("A", "@");
                                break;
                            case StationColumnIndex.Comment:
                                item.Comment = item.Comment.Replace("a", "@").Replace("A", "@");
                                break;
                        }
                    });
                } 
            } 
            catch
            {
                return false;
            }
            return true;
        }
    }
}
