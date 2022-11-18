namespace ClaimProject.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Vin { get; set; }

        public string Color { get; set; }

        public string Year { get; set; }

        public int OwnerID { get; set; }
        public virtual Owner? Owner { get; set; }

        public virtual ICollection<Claim> Claims { get; set; }

        public Vehicle() { 
        Claims = new List<Claim>();
        //Owner = new Owner();
        }
    }
}
