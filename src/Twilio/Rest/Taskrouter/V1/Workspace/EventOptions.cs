/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace
{

    /// <summary>
    /// FetchEventOptions
    /// </summary>
    public class FetchEventOptions : IOptions<EventResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Event to fetch
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchEventOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Event to fetch </param>
        /// <param name="pathSid"> The SID of the resource to fetch </param>
        public FetchEventOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// ReadEventOptions
    /// </summary>
    public class ReadEventOptions : ReadOptions<EventResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Events to read
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// Only include usage that occurred on or before this date
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The type of Events to read
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// The period of events to read in minutes
        /// </summary>
        public int? Minutes { get; set; }
        /// <summary>
        /// The SID of the Reservation with the Events to read
        /// </summary>
        public string ReservationSid { get; set; }
        /// <summary>
        /// Only include Events from on or after this date
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The SID of the TaskQueue with the Events to read
        /// </summary>
        public string TaskQueueSid { get; set; }
        /// <summary>
        /// The SID of the Task with the Events to read
        /// </summary>
        public string TaskSid { get; set; }
        /// <summary>
        /// The SID of the Worker with the Events to read
        /// </summary>
        public string WorkerSid { get; set; }
        /// <summary>
        /// The SID of the Worker with the Events to read
        /// </summary>
        public string WorkflowSid { get; set; }
        /// <summary>
        /// The TaskChannel with the Events to read
        /// </summary>
        public string TaskChannel { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// Construct a new ReadEventOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Events to read </param>
        public ReadEventOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", Serializers.DateTimeIso8601(EndDate)));
            }

            if (EventType != null)
            {
                p.Add(new KeyValuePair<string, string>("EventType", EventType));
            }

            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.ToString()));
            }

            if (ReservationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationSid", ReservationSid.ToString()));
            }

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", Serializers.DateTimeIso8601(StartDate)));
            }

            if (TaskQueueSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueSid", TaskQueueSid.ToString()));
            }

            if (TaskSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskSid", TaskSid.ToString()));
            }

            if (WorkerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerSid", WorkerSid.ToString()));
            }

            if (WorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowSid", WorkflowSid.ToString()));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            if (Sid != null)
            {
                p.Add(new KeyValuePair<string, string>("Sid", Sid.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}