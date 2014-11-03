using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class SignupResponse
    {
        [DataMember(Name = "transaction_id")]
        public string TransactionId { get; set; }

        [DataMember(Name = "user")]
        public SignedUpUser User { get; set; }
    }

    [DataContract]
    public class SignedUpUser
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "domain_name")]
        public string DomainName { get; set; }

        [DataMember(Name = "domain_url")]
        public string DomainURL { get; set; }

        [DataMember(Name = "domain_gui_name")]
        public string DomainGUIName { get; set; }

        [DataMember(Name = "plan")]
        public string Plan { get; set; }

        [DataMember(Name = "billing_day")]
        public string BillingDay { get; set; }

        [DataMember(Name = "domain_admin_id")]
        public string DomainAdminId { get; set; }

        [DataMember(Name = "user_id")]
        public string UserId { get; set; }

        [DataMember(Name = "partner_code")]
        public string PartnerCode { get; set; }
    }
}
