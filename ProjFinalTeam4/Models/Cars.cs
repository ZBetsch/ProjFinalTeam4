using System.ComponentModel.DataAnnotations;

namespace ProjFinalTeam4.Models
{
    public class Cars
    {
        [Key]
        public int carId { get; set; }
        public string carMake { get; set; }
        public string carModel { get; set; }
        public int carYear { get; set; }
       
        //constructors
        public Cars() { }
        public Cars(int carId, string carMake, string carModel, int carYear)
        {
            this.carId = carId;
            this.carMake = carMake;
            this.carModel = carModel;
            this.carYear = carYear;
        }
    }
}
