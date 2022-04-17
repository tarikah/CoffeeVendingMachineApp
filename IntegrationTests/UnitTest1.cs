using CoffeeVendingMachineApp.DbData;
using CoffeeVendingMachineApp.DbServices;
using System;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public async Task CheckIfReturningRightNumberOfData()
        {
            var service = new DbDataService();

            var response = await service.GetCoffeesFromDB();


            Assert.Equal(3, response.Count);

        }
        [Fact]
        public async Task CheckIfExist()
        {
            var service = new DbDataService();

            var response = await service.GetIngredientsFromDb(1);
            var response1 = await service.GetIngredientsFromDb(10);


            Assert.NotEmpty(response);
            Assert.Empty(response1);

        }

        [Fact]
        public async Task CheckIfRightIngredientsAreReturned()
        {
            var service = new DbDataService();

            var response = await service.GetIngredientsFromDb(3);

            Assert.True(response.Exists(x=>x.name== "Liqueur"));

        }
    }
}
