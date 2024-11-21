namespace ProjFinalTeam4.Models
{
    public class Hobbies
    {
        public int hobbiesId { get; set; }
        public string hobbiesName { get; set; }
        public string hobbiesDescription { get; set; }
        public int hobbiesStart { get; set; }
        public string hobbiesResources { get; set; }

        //constructors
        public Hobbies() { }
        public Hobbies(int hobbiesid, string hobbiesname, string hobbiesdescription, int hobbiesstart, string hobbiesresources)
        {
            this.hobbiesId = hobbiesid;
            this.hobbiesName = hobbiesname;
            this.hobbiesDescription = hobbiesdescription;
            this.hobbiesStart = hobbiesstart;
            this.hobbiesResources = hobbiesresources;
        }
    }
}