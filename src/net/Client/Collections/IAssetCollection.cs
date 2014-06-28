//-----------------------------------------------------------------------
// <copyright file="IAssetCollection.cs" company="Microsoft">Copyright 2012 Microsoft Corporation</copyright>
// <license>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </license>

using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    /// <summary>
    /// Represents an interface for Asset collection of <see cref="IAsset"/>.
    /// </summary>
    public interface IAssetCollection : IQueryable<IAsset>
    {
        /// <summary>
        /// Asynchronously creates an asset that does not contain any files and <see cref="AssetState"/> is Initialized.
        /// </summary>
        /// <param name="assetName">The asset name.</param>
        /// <param name="options">A <see cref="AssetCreationOptions"/> which will be associated with created asset.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// An <see cref="Task"/> of type <see cref="IAsset"/>created according to the specified creation <paramref name="options"/>.
        /// </returns>
        Task<IAsset> CreateAsync(string assetName, AssetCreationOptions options, CancellationToken cancellationToken);

        /// <summary>
        /// Creates an asset that does not contain any files and <see cref="AssetState"/> is Initialized. 
        /// </summary>
        /// <param name="assetName">The asset name.</param>
        /// <param name="options">A <see cref="AssetCreationOptions"/> which will be associated with created asset.</param>
        /// <returns>The created asset.</returns>
        IAsset Create(string assetName, AssetCreationOptions options);

        /// <summary>
        /// Asynchronously creates an asset for specified storage account. Asset  does not contain any files and <see cref="AssetState" /> is Initialized.
        /// </summary>
        /// <param name="assetName">The asset name.</param>
        /// <param name="storageAccountName">The storage account name</param>
        /// <param name="options">A <see cref="AssetCreationOptions" /> which will be associated with created asset.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// An <see cref="Task" /> of type <see cref="IAsset" />, where IAsset created according to the specified creation <paramref name="options" />.
        /// </returns>
        Task<IAsset> CreateAsync(string assetName, string storageAccountName, AssetCreationOptions options, CancellationToken cancellationToken);

        /// <summary>
        /// Creates an asset for specified storage account. Asset does not contain any files and <see cref="AssetState" /> is Initialized.
        /// </summary>
        /// <param name="assetName">The asset name.</param>
        /// <param name="storageAccountName"></param>
        /// <param name="options">A <see cref="AssetCreationOptions" /> which will be associated with created asset.</param>
        /// <returns>
        /// The created asset.
        /// </returns>
        IAsset Create(string assetName, string storageAccountName, AssetCreationOptions options);
    }
}
