using System.Runtime.Serialization;

namespace MangoApps.Client
{
    /// <summary>
    /// Signup Success Response
    /// </summary>
    [DataContract]
    public class SignupResponse : TransactionResponse
    {
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        [DataMember(Name = "user")]
        public SignedUpUser User { get; set; }
    }

    /// <summary>
    /// The user that was signed up.
    /// </summary>
    [DataContract]
    public class SignedUpUser
    {
        /// <summary>
        /// Gets or sets the Unique ID for the domain
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the domain.
        /// </summary>
        /// <value>
        /// The name of the domain.
        /// </value>
        [DataMember(Name = "domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets the domain URL.
        /// </summary>
        /// <value>
        /// The domain URL.
        /// </value>
        [DataMember(Name = "domain_url")]
        public string DomainURL { get; set; }

        /// <summary>
        /// Gets or sets the name of the domain GUI.
        /// </summary>
        /// <value>
        /// The name of the domain GUI.
        /// </value>
        [DataMember(Name = "domain_gui_name")]
        public string DomainGUIName { get; set; }

        /// <summary>
        /// Gets or sets the plan.
        /// </summary>
        /// <value>
        /// The plan.
        /// </value>
        [DataMember(Name = "plan")]
        public string Plan { get; set; }

        /// <summary>
        /// Gets or sets the billing day.
        /// </summary>
        /// <value>
        /// The billing day.
        /// </value>
        [DataMember(Name = "billing_day")]
        public string BillingDay { get; set; }

        /// <summary>
        /// Gets or sets the domain admin identifier.
        /// </summary>
        /// <value>
        /// The domain admin identifier.
        /// </value>
        [DataMember(Name = "domain_admin_id")]
        public string DomainAdminId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [DataMember(Name = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the partner code.
        /// </summary>
        /// <value>
        /// The partner code.
        /// </value>
        [DataMember(Name = "partner_code")]
        public string PartnerCode { get; set; }
    }
}
