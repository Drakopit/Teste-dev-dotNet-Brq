using BRQ_Truck.Domain;
using BRQ_Truck.Repository;
using BRQ_Truck.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BRQ_Truck.Teste
{
    public class UnitTruckIntegrationTeste
    {
        private readonly TruckRepository repository;
        public UnitTruckIntegrationTeste()
        {
            var dbOption = new DbContextOptionsBuilder<LocalDbTruck>().UseSqlServer("Server=(localdb)\\LocalDbTruck;Database=truckDb;Trusted_Connection=True;").Options;
            LocalDbTruck context = new LocalDbTruck(dbOption);
            repository = new TruckRepository(context);
        }

        [Fact]
        public async void TestGetAllDatabaseTruck()
        {
            var truckAll = await repository.GetAll();

            Assert.True(truckAll.Count >= 0);
        }

        [Fact]
        public async void TestGetDatabaseTruck()
        {
            var truck = await repository.Get(1);

            Assert.NotNull(truck);
        }

        [Fact]
        public async void TestInsertDatabaseTruck()
        {
            var newTruck = new Truck()
            {
                Model = "FH",
                YearOfManufacture = DateTime.Now,
                YearModel = DateTime.Now
            };

            var result = await repository.Insert(newTruck);

            Assert.True(result);
        }

        [Fact]
        public async void TestUpdateDatabaseTruck()
        {
            var updateTruck = new Truck()
            {
                Id = 1,
                Model = "FM",
                YearOfManufacture = DateTime.Now,
                YearModel = DateTime.Now
            };

            var result = await repository.Update(updateTruck);

            Assert.True(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async void TestDeleteDatabaseTruck(int id)
        {
            var result = await repository.Delete(id);

            Assert.True(result);
        }
    }
}
