// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> This is the storage profile of a Gallery Image Version. </summary>
    internal partial class GalleryImageVersionStorageProfile
    {
        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionStorageProfile"/>. </summary>
        public GalleryImageVersionStorageProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionStorageProfile"/>. </summary>
        /// <param name="osDiskImage"> This is the OS disk image. </param>
        internal GalleryImageVersionStorageProfile(GalleryOSDiskImage osDiskImage)
        {
            OSDiskImage = osDiskImage;
        }

        /// <summary> This is the OS disk image. </summary>
        internal GalleryOSDiskImage OSDiskImage { get; set; }
        /// <summary> This property indicates the size of the VHD to be created. </summary>
        public long? OSDiskImageSizeInMB
        {
            get => OSDiskImage is null ? default : OSDiskImage.SizeInMB;
        }
    }
}
