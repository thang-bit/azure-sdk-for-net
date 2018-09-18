// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ImportSource
    {
        /// <summary>
        /// Initializes a new instance of the ImportSource class.
        /// </summary>
        public ImportSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportSource class.
        /// </summary>
        /// <param name="resourceId">The resource identifier of the target
        /// Azure Container Registry.</param>
        /// <param name="sourceImage">Repository name of the source image.
        /// Specify an image by repository ('hello-world'). This will use the
        /// 'latest' tag.
        /// Specify an image by tag ('hello-world:latest').
        /// Specify an image by sha256-based manifest digest
        /// ('hello-world@sha256:abc123').</param>
        public ImportSource(string resourceId, string sourceImage)
        {
            ResourceId = resourceId;
            SourceImage = sourceImage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource identifier of the target Azure Container
        /// Registry.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets repository name of the source image.
        /// Specify an image by repository ('hello-world'). This will use the
        /// 'latest' tag.
        /// Specify an image by tag ('hello-world:latest').
        /// Specify an image by sha256-based manifest digest
        /// ('hello-world@sha256:abc123').
        /// </summary>
        [JsonProperty(PropertyName = "sourceImage")]
        public string SourceImage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
            if (SourceImage == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceImage");
            }
        }
    }
}
