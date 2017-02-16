using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Marketplace 
{

    /// <summary>
    /// InstalledAddOnResource
    /// </summary>
    public class InstalledAddOnResource : Resource 
    {
        private static Request BuildCreateRequest(CreateInstalledAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/marketplace/InstalledAddOns",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Install an Add-on for the Account specified.
        /// </summary>
        ///
        /// <param name="options"> Create InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static InstalledAddOnResource Create(CreateInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Install an Add-on for the Account specified.
        /// </summary>
        ///
        /// <param name="options"> Create InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> CreateAsync(CreateInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Install an Add-on for the Account specified.
        /// </summary>
        ///
        /// <param name="availableAddOnSid"> A string that uniquely identifies the Add-on to install </param>
        /// <param name="acceptTermsOfService"> A boolean reflecting your acceptance of the Terms of Service </param>
        /// <param name="configuration"> The JSON object representing the configuration </param>
        /// <param name="uniqueName"> The string that uniquely identifies this Add-on installation </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static InstalledAddOnResource Create(string availableAddOnSid, bool? acceptTermsOfService, object configuration = null, string uniqueName = null, ITwilioRestClient client = null)
        {
            var options = new CreateInstalledAddOnOptions(availableAddOnSid, acceptTermsOfService){Configuration = configuration, UniqueName = uniqueName};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Install an Add-on for the Account specified.
        /// </summary>
        ///
        /// <param name="availableAddOnSid"> A string that uniquely identifies the Add-on to install </param>
        /// <param name="acceptTermsOfService"> A boolean reflecting your acceptance of the Terms of Service </param>
        /// <param name="configuration"> The JSON object representing the configuration </param>
        /// <param name="uniqueName"> The string that uniquely identifies this Add-on installation </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> CreateAsync(string availableAddOnSid, bool? acceptTermsOfService, object configuration = null, string uniqueName = null, ITwilioRestClient client = null)
        {
            var options = new CreateInstalledAddOnOptions(availableAddOnSid, acceptTermsOfService){Configuration = configuration, UniqueName = uniqueName};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteInstalledAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                "/marketplace/InstalledAddOns/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Remove an Add-on installation from your account
        /// </summary>
        ///
        /// <param name="options"> Delete InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static bool Delete(DeleteInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Remove an Add-on installation from your account
        /// </summary>
        ///
        /// <param name="options"> Delete InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Remove an Add-on installation from your account
        /// </summary>
        ///
        /// <param name="sid"> The Installed Add-on Sid to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static bool Delete(string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteInstalledAddOnOptions(sid);
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Remove an Add-on installation from your account
        /// </summary>
        ///
        /// <param name="sid"> The Installed Add-on Sid to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteInstalledAddOnOptions(sid);
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildFetchRequest(FetchInstalledAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/marketplace/InstalledAddOns/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of an Add-on currently installed on this Account.
        /// </summary>
        ///
        /// <param name="options"> Fetch InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static InstalledAddOnResource Fetch(FetchInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of an Add-on currently installed on this Account.
        /// </summary>
        ///
        /// <param name="options"> Fetch InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> FetchAsync(FetchInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of an Add-on currently installed on this Account.
        /// </summary>
        ///
        /// <param name="sid"> The unique Installed Add-on Sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static InstalledAddOnResource Fetch(string sid, ITwilioRestClient client = null)
        {
            var options = new FetchInstalledAddOnOptions(sid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of an Add-on currently installed on this Account.
        /// </summary>
        ///
        /// <param name="sid"> The unique Installed Add-on Sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> FetchAsync(string sid, ITwilioRestClient client = null)
        {
            var options = new FetchInstalledAddOnOptions(sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateInstalledAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/marketplace/InstalledAddOns/" + options.Sid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Update an Add-on installation for the Account specified.
        /// </summary>
        ///
        /// <param name="options"> Update InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static InstalledAddOnResource Update(UpdateInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Update an Add-on installation for the Account specified.
        /// </summary>
        ///
        /// <param name="options"> Update InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> UpdateAsync(UpdateInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Update an Add-on installation for the Account specified.
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="configuration"> The JSON object representing the configuration </param>
        /// <param name="uniqueName"> The string that uniquely identifies this Add-on installation </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static InstalledAddOnResource Update(string sid, object configuration = null, string uniqueName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateInstalledAddOnOptions(sid){Configuration = configuration, UniqueName = uniqueName};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Update an Add-on installation for the Account specified.
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="configuration"> The JSON object representing the configuration </param>
        /// <param name="uniqueName"> The string that uniquely identifies this Add-on installation </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> UpdateAsync(string sid, object configuration = null, string uniqueName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateInstalledAddOnOptions(sid){Configuration = configuration, UniqueName = uniqueName};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadInstalledAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/marketplace/InstalledAddOns",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of Add-ons currently installed on this Account.
        /// </summary>
        ///
        /// <param name="options"> Read InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static ResourceSet<InstalledAddOnResource> Read(ReadInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<InstalledAddOnResource>.FromJson("installed_add_ons", response.Content);
            return new ResourceSet<InstalledAddOnResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of Add-ons currently installed on this Account.
        /// </summary>
        ///
        /// <param name="options"> Read InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<InstalledAddOnResource>> ReadAsync(ReadInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<InstalledAddOnResource>.FromJson("installed_add_ons", response.Content);
            return new ResourceSet<InstalledAddOnResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of Add-ons currently installed on this Account.
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns> 
        public static ResourceSet<InstalledAddOnResource> Read(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadInstalledAddOnOptions{PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of Add-ons currently installed on this Account.
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<InstalledAddOnResource>> ReadAsync(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadInstalledAddOnOptions{PageSize = pageSize, Limit = limit};
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
        public static Page<InstalledAddOnResource> NextPage(Page<InstalledAddOnResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<InstalledAddOnResource>.FromJson("installed_add_ons", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a InstalledAddOnResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InstalledAddOnResource object represented by the provided JSON </returns> 
        public static InstalledAddOnResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<InstalledAddOnResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// A string that uniquely identifies this Add-on installation
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The Account id that has installed this Add-on
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A description of this Add-on installation
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A short description of the Add-on functionality
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// The JSON object representing the current configuration
        /// </summary>
        [JsonProperty("configuration")]
        public object Configuration { get; private set; }
        /// <summary>
        /// The string that uniquely identifies this Add-on installation
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The date this Add-on installation was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Add-on installation was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
    
        private InstalledAddOnResource()
        {
        
        }
    }

}