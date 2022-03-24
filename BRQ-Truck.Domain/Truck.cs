using System.ComponentModel.DataAnnotations;

namespace BRQ_Truck.Domain
{
    public class Truck : Entity
    {

        public Truck() {}

        [MaxLength(2)]
        public string Model
        {
            get
            {
                return this.Model;
            }
            set
            {
                if (value.ToString().ToUpper() == "FH" || value.ToString().ToUpper() == "FM")
                    this.Model = value;
                else
                    throw new ArgumentException("Invalid Value!");
            }
        }
        public DateTime YearOfManufacture
        {
            get
            {
                return this.YearOfManufacture;
            }
            set
            {
                if (value.Year == DateTime.Now.Year)
                    this.YearOfManufacture = value;
                else
                    throw new ArgumentException("Invalid Year!");
            }
        }
        public DateTime YearModel
        {
            get
            {
                return this.YearModel;
            }
            set
            {
                if (value.Year == DateTime.Now.Year || value.Year == (DateTime.Now.Year + 1))
                    this.YearModel = value;
                else
                    throw new ArgumentException("Invalid Year!");
            }
        }
    }
}