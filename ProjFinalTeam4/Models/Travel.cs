namespace ProjFinalTeam4.Models
{
    public class Travel
    {

        public int travelId { get; set; }
        public string travelName { get; set; }
        public string travelCountry { get; set; }
        public int travelCost { get; set; }
        public string travelDescription {  get; set; }


        public Travel() { }

        public Travel(int travelId, string travelName, string travelCountry, int travelCost, string travelDescription)
        {
            this.travelId = travelId;
            this.travelName = travelName;
            this.travelCountry = travelCountry;
            this.travelCost = travelCost;
            this.travelDescription = travelDescription;
        }
    }
}
