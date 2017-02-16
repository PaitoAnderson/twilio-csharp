using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Marketplace.AvailableAddOn 
{

    /// <summary>
    /// AvailableAddOnExtensionResource
    /// </summary>
    public class AvailableAddOnExtensionResource : Resource 
    {
        private static Request BuildFetchRequest(FetchAvailableAddOnExtensionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/marketplace/AvailableAddOns/" + options.AvailableAddOnSid + "/Extensions/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of an Extension for the Available Add-on.
        /// </summary>
        ///
        /// <param name="options"> Fetch AvailableAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOnExtension </returns> 
        public static AvailableAddOnExtensionResource Fetch(FetchAvailableAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of an Extension for the Available Add-on.
        /// </summary>
        ///
        /// <param name="options"> Fetch AvailableAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOnExtension </returns> 
        public static async System.Threading.Tasks.Task<AvailableAddOnExtensionResource> FetchAsync(FetchAvailableAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of an Extension for the Available Add-on.
        /// </summary>
        ///
        /// <param name="availableAddOnSid"> The available_add_on_sid </param>
        /// <param name="sid"> The unique Extension Sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOnExtension </returns> 
        public static AvailableAddOnExtensionResource Fetch(string availableAddOnSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchAvailableAddOnExtensionOptions(availableAddOnSid, sid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of an Extension for the Available Add-on.
        /// </summary>
        ///
        /// <param name="availableAddOnSid"> The available_add_on_sid </param>
        /// <param name="sid"> The unique Extension Sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOnExtension </returns> 
        public static async System.Threading.Tasks.Task<AvailableAddOnExtensionResource> FetchAsync(string availableAddOnSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchAvailableAddOnExtensionOptions(availableAddOnSid, sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadAvailableAddOnExtensionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/marketplace/AvailableAddOns/" + options.AvailableAddOnSid + "/Extensions",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of Extensions for the Available Add-on.
        /// </summary>
        ///
        /// <param name="options"> Read AvailableAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOnExtension </returns> 
        public static ResourceSet<AvailableAddOnExtensionResource> Read(ReadAvailableAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<AvailableAddOnExtensionResource>.FromJson("extensions", response.Content);
            return new ResourceSet<AvailableAddOnExtensionResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of Extensions for the Available Add-on.
        /// </summary>
        ///
        /// <param name="options"> Read AvailableAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOnExtension </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AvailableAddOnExtensionResource>> ReadAsync(ReadAvailableAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<AvailableAddOnExtensionResource>.FromJson("extensions", response.Content);
            return new ResourceSet<AvailableAddOnExtensionResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of Extensions for the Available Add-on.
        /// </summary>
        ///
        /// <param name="availableAddOnSid"> The available_add_on_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOnExtension </returns> 
        public static ResourceSet<AvailableAddOnExtensionResource> Read(string availableAddOnSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAvailableAddOnExtensionOptions(availableAddOnSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of Extensions for the Available Add-on.
        /// </summary>
        ///
        /// <param name="availableAddOnSid"> The available_add_on_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOnExtension </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AvailableAddOnExtensionResource>> ReadAsync(string availableAddOnSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAvailableAddOnExtensionOptions(availableAddOnSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<AvailableAddOnExtensionResource> NextPage(Page<AvailableAddOnExtensionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<AvailableAddOnExtensionResource>.FromJson("extensions", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a AvailableAddOnExtensionResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AvailableAddOnExtensionResource object represented by the provided JSON </returns> 
        public static AvailableAddOnExtensionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AvailableAddOnExtensionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// A string that uniquely identifies this Extension
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The available_add_on_sid
        /// </summary>
        [JsonProperty("available_add_on_sid")]
        public string AvailableAddOnSid { get; private set; }
        /// <summary>
        /// A human-readable description of this Extension
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A human-readable description of the Extension's Product
        /// </summary>
        [JsonProperty("product_name")]
        public string ProductName { get; private set; }
        /// <summary>
        /// The string that uniquely identifies this Extension
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private AvailableAddOnExtensionResource()
        {
        
        }
    }

}