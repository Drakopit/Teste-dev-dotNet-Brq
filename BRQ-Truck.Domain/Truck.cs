using System;

namespace BRQ_Truck.Domain
{
    public class Truck : Entity
    {
        public string Model { get; set; }

        public DateTime YearOfManufacture { get; set; }

        public DateTime YearModel { get; set; }

        public bool CheckModel()
        {
            if (Model != null)
            {
                if (Model.ToUpper() == "FH" || Model.ToUpper() == "FM")
                    return true;
            }
            return false;
        }

        public bool CheckYearOfManufacture()
        {
            if (YearOfManufacture != null)
            {
                if (YearOfManufacture.Year == DateTime.Now.Year)
                    return true;
            }
            return false;
        }

        public bool CheckYearModel()
        {
            if (YearModel.Year == DateTime.Now.Year || YearModel.Year == DateTime.Now.Year + 1)
            {
                return true;
            }
            return false;
        }
    }
}
