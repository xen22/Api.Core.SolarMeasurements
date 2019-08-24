// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Api.Core.SolarMeasurementsProxy
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// A simple API for retrieving measurements from Solar sites
    /// </summary>
    public partial interface ISolarMeasurementsCoreAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the ITransport.
        /// </summary>
        ITransport Transport { get; }

    }
}
