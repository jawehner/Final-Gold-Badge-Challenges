using System;

namespace Challenge_2
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public string DateOfClaim { get; set; }
        public string DateOfIncident { get; set; }
        public string Validity { get; set; }

        public Claim(int claimID, string claimType, string description, decimal claimAmount,
            string dateOfClaim, string dateOfIncident, string validity)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfClaim = dateOfClaim;
            DateOfIncident = dateOfIncident;
            Validity = validity;
        }

        public Claim()
        {

        }

        public override string ToString() => $" \t\n\nClaim ID: {ClaimID} \t\n\nClaim Type: {ClaimType} " +
             $"\t\n\nDescription: {Description} \t\n\nClaim Amount: {ClaimAmount}  \t\n\nDate of Claim: {DateOfClaim}" +
             $"\t\n\nDate of Incident: {DateOfIncident} \t\n\nClaim made within 30 days of incident: {Validity}";
    }
}
