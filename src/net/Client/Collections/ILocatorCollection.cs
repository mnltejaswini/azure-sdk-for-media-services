using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    public interface ILocatorCollection : IQueryable<ILocator>
    {
        Task<ILocator> CreateSasLocatorAsync(IAsset asset, IAccessPolicy accessPolicy);
        ILocator CreateSasLocator(IAsset asset, IAccessPolicy accessPolicy);
        ILocator CreateSasLocator(IAsset asset, IAccessPolicy accessPolicy, DateTime? startTime, string name = null);
        Task<ILocator> CreateSasLocatorAsync(IAsset asset, IAccessPolicy accessPolicy, DateTime? startTime, string name = null);
        Task<ILocator> CreateLocatorAsync(LocatorType locatorType, IAsset asset, IAccessPolicy accessPolicy, DateTime? startTime, string name = null);
        Task<ILocator> CreateLocatorAsync(LocatorType locatorType, IAsset asset, IAccessPolicy accessPolicy);
        ILocator CreateLocator(LocatorType locatorType, IAsset asset, IAccessPolicy accessPolicy, DateTime? startTime, string name = null);
        ILocator CreateLocator(LocatorType locatorType, IAsset asset, IAccessPolicy accessPolicy);

    }
}
