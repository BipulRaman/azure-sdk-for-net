// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceFabric;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The structure of the error
    /// </summary>
    public partial class ErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the ErrorModel class.
        /// </summary>
        public ErrorModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorModel class.
        /// </summary>
        /// <param name="error">The error detail </param>
        public ErrorModel(ErrorModelError error = default(ErrorModelError))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the error detail
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorModelError Error { get; set; }

    }
}
