using WH.Proxy.Subjects;
using WH.Proxy.Subjects.Interfaces;

namespace WH.Proxy
{
    public class ProxyClass
    {
        public IStationProxy StationProxy;
        public ICommonProxy CommonProxy;

        public ProxyClass(string baseUrl) : this(new StationProxy(baseUrl), new CommonProxy(baseUrl))
        {
            
        }

        public ProxyClass(IStationProxy stationProxy, ICommonProxy commonProxy)
        {
            StationProxy = stationProxy;
            CommonProxy = commonProxy;
        }

    }
}