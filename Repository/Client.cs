//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public int ClientID { get; set; }
        public string LegacyID { get; set; }
        public int CustomerID { get; set; }
        public int ClientStatusID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> ClientOutcomeID { get; set; }
        public string SalutationID { get; set; }
        public string Suffix { get; set; }
        public string Nickname { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> MaritalStatusID { get; set; }
        public string SpouseName { get; set; }
        public string SpouseOccupation { get; set; }
        public Nullable<int> NumberOfChildren { get; set; }
        public string ChildrenAges { get; set; }
        public Nullable<int> ChildrenAtHome { get; set; }
        public string LinkedInProfile { get; set; }
        public Nullable<bool> HadInterview { get; set; }
        public Nullable<bool> HadJobOffer { get; set; }
        public Nullable<System.DateTime> CompletedOn { get; set; }
        public Nullable<int> SpouseAge { get; set; }
        public string SpousePhone { get; set; }
        public bool IsSpousePhoneEmergency { get; set; }
        public Nullable<System.DateTime> HoldStartDate { get; set; }
        public Nullable<System.DateTime> HoldEndDate { get; set; }
        public Nullable<System.DateTime> UnresponsiveStartDate { get; set; }
        public Nullable<System.DateTime> UnresponsiveEndDate { get; set; }
        public Nullable<System.DateTime> TrainingStartDate { get; set; }
        public Nullable<System.DateTime> TrainingEndDate { get; set; }
        public Nullable<System.DateTime> BillingGeneratedOn { get; set; }
        public Nullable<int> TimeZoneID { get; set; }
        public string PreferredContactMethod { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string TrainingLocation { get; set; }
        public Nullable<int> DatamineStatusID { get; set; }
        public Nullable<System.DateTime> DatamineCompletedOn { get; set; }
        public Nullable<int> OriginalResumeStatusID { get; set; }
        public Nullable<System.DateTime> OriginalResumeReceivedOn { get; set; }
        public Nullable<bool> IsStartResume { get; set; }
        public Nullable<System.DateTime> ResumeStartDate { get; set; }
        public Nullable<int> ResumeClientDocumentID { get; set; }
        public bool DoNotShareApprovedResume { get; set; }
        public bool IsInvoiceCompleted { get; set; }
        public string ClientPO { get; set; }
    }
}