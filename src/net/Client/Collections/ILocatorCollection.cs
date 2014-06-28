//-----------------------------------------------------------------------
// <copyright file="ILocatorCollection.cs" company="Microsoft">Copyright 2012 Microsoft Corporation</copyright>
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

using System;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    /// <summary>
    /// Represents an interface for collection of <see cref="ILocator"/>.
    /// </summary>
    public interface ILocatorCollection : IQueryable<ILocator>
    {
        /// <summary>
        /// Asynchronously creates a SAS Locator with the specified access policy and asset.
        /// </summary>
        /// <param name="asset">The asset to create a SAS Locator for.</param>
        /// <param name="accessPolicy">The AccessPolicy that governs access for the locator.</param>
        /// <returns>A function delegate that returns the future result to be available through the Task&lt;ILocator&gt;.</returns>
        /// <exception cref="ArgumentNullException">When <paramref name="asset"/> is null.</exception>
        /// <exception cref="ArgumentNullException">When <paramref name="accessPolicy"/> is null.</exception>
        Task<ILocator> CreateSasLocatorAsync(IAsset asset, IAccessPolicy accessPolicy);

        /// <summary>
        /// Creates a SAS Locator with the specified access policy and asset.
        /// </summary>
        /// <param name="asset">The asset to create a SAS Locator for.</param>
        /// <param name="accessPolicy">The AccessPolicy that governs access for the locator.</param>
        /// <returns>A locator granting access specified by <paramref name="accessPolicy" /> to the provided <paramref name="asset" />.</returns>
        /// <exception cref="ArgumentNullException">When <paramref name="asset"/> is null.</exception>
        /// <exception cref="ArgumentNullException">When <paramref name="accessPolicy"/> is null.</exception>
        ILocator CreateSasLocator(IAsset asset, IAccessPolicy accessPolicy);

        /// <summary>
        /// Creates a SAS Locator with the specified access policy and asset.
        /// </summary>
        /// <param name="asset">The asset to create a SAS Locator for.</param>
        /// <param name="accessPolicy">The AccessPolicy that governs access for the locator.</param>
        /// <param name="startTime">The access start time of the locator.</param>
        /// <param name="name">The locator name.</param>
        /// <returns>
        /// A locator granting access specified by <paramref name="accessPolicy" /> to the provided <paramref name="asset" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">When <paramref name="asset" /> is null.</exception>
        /// <exception cref="ArgumentNullException">When <paramref name="asset" /> is null.</exception>
        ILocator CreateSasLocator(IAsset asset, IAccessPolicy accessPolicy, DateTime? startTime, string name = null);
        
        /// <summary>
        /// Asynchronously creates a SAS Locator with the specified access policy and asset.
        /// </summary>
        /// <param name="asset">The asset to create a SAS Locator for.</param>
        /// <param name="accessPolicy">The AccessPolicy that governs access for the locator.</param>
        /// <param name="startTime">The access start time of the locator.</param>
        /// <param name="name">The locator name.</param>
        /// <returns>
        /// A function delegate that returns the future result to be available through the Task&lt;ILocator&gt;.
        /// </returns>
        /// <exception cref="ArgumentNullException">When <paramref name="asset" /> is null.</exception>
        /// <exception cref="ArgumentNullException">When <paramref name="asset" /> is null.</exception>
        Task<ILocator> CreateSasLocatorAsync(IAsset asset, IAccessPolicy accessPolicy, DateTime? startTime, string name = null);

        /// <summary>
        /// Creates the locator async.
        /// </summary>
        /// <param name="locatorType">Type of the locator.</param>
        /// <param name="asset">The asset.</param>
        /// <param name="accessPolicy">The access policy.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="name">The name.</param>
        /// <returns>
        /// A function delegate that returns the future result to be available through the Task&lt;ILocator&gt;.
        /// </returns>
        Task<ILocator> CreateLocatorAsync(LocatorType locatorType, IAsset asset, IAccessPolicy accessPolicy, DateTime? startTime, string name = null);
        
        Task<ILocator> CreateLocatorAsync(LocatorType locatorType, IAsset asset, IAccessPolicy accessPolicy);

        /// <summary>
        /// Creates the locator.
        /// </summary>
        /// <param name="locatorType">Type of the locator.</param>
        /// <param name="asset">The asset.</param>
        /// <param name="accessPolicy">The access policy.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="name">The name.</param>
        /// <returns>
        /// A locator enabling streaming access to the specified <paramref name="asset" />.
        /// </returns>
        ILocator CreateLocator(LocatorType locatorType, IAsset asset, IAccessPolicy accessPolicy, DateTime? startTime, string name = null);
        
        ILocator CreateLocator(LocatorType locatorType, IAsset asset, IAccessPolicy accessPolicy);

    }
}
