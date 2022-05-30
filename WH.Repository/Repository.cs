using WH.Shared.Entities;

namespace WH.Repository
{
    public abstract class Repository
    {
        protected static List<Station>? Data;
        protected static List<ComboExample>? ComboList;

        public abstract List<Station> GetAll();
        public abstract Station? Get(int id);
        public abstract int Add(Station s);
        public abstract bool Update(Station s);
        public abstract bool Delete(Station s);
        public abstract List<ComboExample> GetAllComboList();
    }
}