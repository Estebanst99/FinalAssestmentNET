namespace ClaimProject.Models
{
    public class Owner
    {

        
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DriverLicense { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

        public Owner() {

            Vehicles = new List<Vehicle>();
        }
    }
}
