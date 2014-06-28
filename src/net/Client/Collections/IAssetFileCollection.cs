using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Text;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    public interface IAssetFileCollection : IQueryable<IAssetFile>
    {
        IAssetFile Create(string name);

        Task<IAssetFile> CreateAsync(string name, CancellationToken cancellation);
    }
}
