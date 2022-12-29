namespace SendSms.Net.Constants;

public static class ApiConstants
{
    public const string Version = "1.0.0.0";
    public const string DefaultPhone = "40799999999";

    public const string BaseApiUrl = "https://hub.sendsms.ro"; //"https://api.sendsms.ro"
    public const string BaseApiPath = BaseApiUrl + "/json?action=";

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#messages
    /// </summary>
    public static class Messages
    {
        public const string MessageSendApiPath = BaseApiPath + "message_send";
        public const string MessageSendGdprApiPath = BaseApiPath + "message_send_gdpr";
        public const string MessageGetApiPath = BaseApiPath + "messages_get";
        public const string MessageStatisticsApiPath = BaseApiPath + "messages_statistics";
        public const string MessageStatusApiPath = BaseApiPath + "message_status";
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#address-book
    /// </summary>
    public static class AddressBook
    {
        public static class Contacts
        {
            public const string AddressBookContactsGetListApiPath = BaseApiPath + "address_book_contacts_get_list";
            public const string AddressBookContactAddApiPath = BaseApiPath + "address_book_contact_add";
            public const string AddressBookContactDeleteApiPath = BaseApiPath + "address_book_contact_delete";
            public const string AddressBookContactUpdateApiPath = BaseApiPath + "address_book_contact_update";
        }
        public static class Group
        {
            public const string AddressBookGroupsGetListApiPath = BaseApiPath + "address_book_groups_get_list";
            public const string AddressBookGroupAddApiPath = BaseApiPath + "address_book_group_add";
            public const string AddressBookGroupDeleteApiPath = BaseApiPath + "address_book_group_delete";
        }
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#batch
    /// </summary>
    public static class Batch
    {
        public const string BatchCreateApiPath = BaseApiPath + "batch_create";
        public const string BatchCheckStatusApiPath = BaseApiPath + "batch_check_status";
        public const string BatchesListApiPath = BaseApiPath + "batches_list";
        public const string BatchStartApiPath = BaseApiPath + "batch_start";
        public const string BatchStopApiPath = BaseApiPath + "batch_stop";
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#blocklist
    /// </summary>
    public static class Blocklist
    {
        public const string BlocklistAddApiPath = BaseApiPath + "blocklist_add";
        public const string BlocklistDelApiPath = BaseApiPath + "blocklist_del";
        public const string BlocklistCheckApiPath = BaseApiPath + "blocklist_check";
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#hlr
    /// </summary>
    public static class Hlr
    {
        public const string HlrPerformApiPath = BaseApiPath + "hlr_perform";
        public const string HlrPerformSynchronousApiPath = BaseApiPath + "hlr_perform_synchronous";

    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#otp
    /// </summary>
    public static class Otp
    {
        public const string OtpSendApiPath = BaseApiPath + "otp_send";
        public const string OtpCheckApiPath = BaseApiPath + "otp_check";
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#mnp
    /// </summary>
    public static class Mnp
    {
        public const string MnpPerformApiPath = BaseApiPath + "mnp_perform";
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#user
    /// </summary>
    public static class User
    {
        public const string UserGetBalanceApiPath = BaseApiPath + "user_get_balance";
        public const string UserGetInfoApiPath = BaseApiPath + "user_get_info";
        public const string UserGetPhoneNumberApiPath = BaseApiPath + "user_get_phone_number";
        public const string UserTransferFundsApiPath = BaseApiPath + "user_transfer_funds";
        public const string GetUserPricingListApiPath = BaseApiPath + "get_user_pricing_list";
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#api-key-2
    /// </summary>
    public static class ApiKey
    {
        public const string UserAuthorizeApplicationApiPath = BaseApiPath + "user_authorize_application";
        public const string UserAllowTokenRequestApiPath = BaseApiPath + "user_allow_token_request";
        public const string UserGetApKeyApiPath = BaseApiPath + "user_get_api_key";
        public const string TokenListIpsApiPath = BaseApiPath + "token_list_ips";
        public const string TokenAddIpApiPath = BaseApiPath + "token_add_ip";
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#other
    /// </summary>
    public static class Other
    {
        public const string ExecuteMultipleApiPath = BaseApiPath + "execute_multiple";
        public const string PingApiPath = BaseApiPath + "ping";
        public const string CheckPriceApiPath = BaseApiPath + "route_check_price";
    }
}