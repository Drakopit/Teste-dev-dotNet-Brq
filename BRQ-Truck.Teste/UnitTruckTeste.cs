using BRQ_Truck.Domain;
using System;
using Xunit;

namespace BRQ_Truck.Teste
{
    public class UnitTruckTeste
    {
        [Fact]
        public void TestIf_Model_HasWrongValue()
        {
            string modelValue = "FH";
            string[] modelValueExpected = new string[2] { "FM", "FH" };

            Truck truck = new Truck();
            truck.Model = modelValue;

            Assert.Single(modelValueExpected, modelValue);
        }

        [Fact]
        public void TestIf_YearOfManufacture_HasWrongYear()
        {
            DateTime yearOfManufacture = DateTime.Parse("2022-03-25");
            DateTime yearOfManufactureExpected = DateTime.Now;

            Truck truck = new Truck();
            truck.YearOfManufacture = yearOfManufacture;

            Assert.Equal(yearOfManufactureExpected.Year, truck.YearOfManufacture.Year);
        }

        [Fact]
        public void TestIf_YearModel_HasWrongYear()
        {
            DateTime yearModel = DateTime.Parse("2022-03-25");
            int[] yearModelExpected = new int[2] { DateTime.Now.Year, (DateTime.Now.Year + 1) };

            Truck truck = new Truck();
            truck.YearModel = yearModel;

            Assert.Single(yearModelExpected, yearModel.Year);
        }
    }
}
