using System.ComponentModel.DataAnnotations;

namespace ProjFinalTeam4.Models
{
    public class ExtracurricularActivity
    {
        [Key]
        public int activityId { get; set; }
        public string activityName { get; set; }
        public string activityDescription { get; set; }
        public string activityLocation { get; set; }
        public string activitySchedule { get; set; }
        //constructors
        public ExtracurricularActivity() { }
        public ExtracurricularActivity(int ActivityId, string ActivityName, string ActivityDescription, string ActivityLocation, string ActivitySchedule)
        {
            this.activityId = ActivityId;
            this.activityName = ActivityName;
            this.activityDescription = ActivityDescription;
            this.activityLocation = ActivityLocation;
            this.activitySchedule = ActivitySchedule;
        }
    }
}
