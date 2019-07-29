﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.CameraSystem;

namespace Microsoft.MixedReality.Toolkit.Utilities
{
    public partial class CoreServices : BaseCoreServices
    {
        /// <summary>
        /// Cached reference to the active instance of the camera system.
        /// If system is destroyed, reference will be invalid. Please use ResetCacheReferences() 
        /// </summary>
        public static IMixedRealityCameraSystem CameraSystem
        {
            get
            {
                return GetService<IMixedRealityCameraSystem>();
            }
        }
    }
}