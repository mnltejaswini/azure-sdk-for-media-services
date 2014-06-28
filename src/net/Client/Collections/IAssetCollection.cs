using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Text;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    public interface IAssetCollection : IQueryable<IAsset>
    {
        Task<IAsset> CreateAsync(string assetName, AssetCreationOptions options, CancellationToken cancellationToken);

        IAsset Create(string assetName, AssetCreationOptions options);

        Task<IAsset> CreateAsync(string assetName, string storageAccountName, AssetCreationOptions options, CancellationToken cancellationToken);

        IAsset Create(string assetName, string storageAccountName, AssetCreationOptions options);
    }
}
