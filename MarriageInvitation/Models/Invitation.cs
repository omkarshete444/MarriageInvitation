namespace MarriageInvitation.Models
{
    public class Invitation
    {
        public string GroomName { get; set; }
        public string BrideName { get; set; }
        public string InvitationMessage { get; set; }
        public string Date { get; set; }      // you can use DateTime also
        public string Time { get; set; }
        public string Venue { get; set; }
        public string PhotoPath { get; set; } // path of image
    }
}
