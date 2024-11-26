namespace ProjFinalTeam4.Models
{
    public class Hobbies
    {
        public int hobbiesId { get; set; }
        public string hobbiesName { get; set; }
        public string hobbiesDescription { get; set; }
        public int hobbiesStartDay { get; set; }
        public int hobbiesStartMonth { get; set; }
        public int hobbiesStartYear { get; set; }
        public string hobbiesResources { get; set; }

        //constructors
        public Hobbies() { }
        public Hobbies(int hobbiesid, string hobbiesname, string hobbiesdescription, int hobbiesstartday, int hobbiesstartmonth, int hobbiesstartyear, string hobbiesresources)
        {
            this.hobbiesId = hobbiesid;
            this.hobbiesName = hobbiesname;
            this.hobbiesDescription = hobbiesdescription;
            this.hobbiesStartDay = hobbiesstartday;
            this.hobbiesStartMonth = hobbiesstartmonth;
            this.hobbiesStartYear = hobbiesstartyear;
            this.hobbiesResources = hobbiesresources;
        }
    }
}