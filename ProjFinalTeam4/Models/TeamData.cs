namespace ProjFinalTeam4.Models
{
    public class TeamData
    {
        public int teamDataId { get; set; }
        public string teamDataFName { get; set; }
        public string teamDataLName { get; set; }
        public DateTime teamDataBirthdate { get; set; }
        public string teamDataCollegeProgram { get; set; }
        public string teamDataProgramYear { get; set; }


        //constructors
        public TeamData() { }
        public TeamData(int teamdataid, string teamdatafname, string teamdatalname, DateTime teamdatabirthdate, string teamdatacollegeprogram, string teamdataprogramyear)
        {
            this.teamDataId = teamdataid;
            this.teamDataFName = teamdatafname;
            this.teamDataLName= teamdatalname;
            this.teamDataBirthdate = teamdatabirthdate;
            this.teamDataCollegeProgram = teamdatacollegeprogram;
            this.teamDataProgramYear = teamdataprogramyear;
        }
    }
}