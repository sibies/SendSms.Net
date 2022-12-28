namespace SendSms.Net.Responses;

public enum ResponseStatusCode
{
    /// <summary>
    /// Authentication failure
    /// </summary>
    api_result_authentication_failed = -8,
    /// <summary>
    /// Could not save
    /// </summary>
    api_result_could_not_save = -256,
    /// <summary>
    /// Duplicate record found (when adding)
    /// </summary>
    api_result_duplicate_record = -512,
    /// <summary>
    /// Internal error
    /// </summary>
    api_result_internal_error = -16,
    /// <summary>
    /// Invalid record
    /// </summary>
    api_result_invalid_record = -128,
    /// <summary>
    /// API Request Key created
    /// </summary>
    api_result_key_created = 2,
    /// <summary>
    /// Message sent/queued
    /// </summary>
    api_result_message_sent = 1,
    /// <summary>
    /// There was a required parameter missing from the request (see 'details' key in result for more information)
    /// </summary>
    api_result_missing_parameter = -4,
    /// <summary>
    /// No action was specified in the request
    /// Message does not exist
    /// </summary>
    api_result_no_action_specified = -1,//message_status_does_not_exist
    /// <summary>
    /// There was no matching action found
    /// </summary>
    api_result_no_such_action = -2,
    /// <summary>
    /// Generic OK
    /// </summary>
    api_result_ok = 0,
    /// <summary>
    /// Out of credit
    /// </summary>
    api_result_out_of_credit = -64,
    /// <summary>
    /// Routing error
    /// </summary>
    api_result_routing_error = -32,
    /// <summary>
    /// User has exceeded the maximum number of simultaneous requests to the API
    /// </summary>
    api_result_timeout = -8191,
    /// <summary>
    /// User has exceeded the maximum number of simultaneous requests to the API
    /// </summary>
    api_result_too_many_connections = -4096,
    /// <summary>
    /// User is not part of any affiliate program
    /// </summary>
    api_result_user_invalid_affiliate = -1024,
    /// <summary>
    /// User does not have HLR enabled on his account
    /// User has reached maximum registrations during the specified period.
    /// </summary>
    api_result_user_no_hlr = -2048, //maximum_affliate_registrations_reached

}