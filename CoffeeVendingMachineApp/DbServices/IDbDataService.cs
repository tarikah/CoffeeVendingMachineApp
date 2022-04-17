using CoffeeVendingMachineApp.DbData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachineApp.DbServices
{
    public interface IDbDataService
    {
        Task<List<Data>> GetCoffeesFromDB();
        Task<List<Data>> GetIngredientsFromDb(int id);
    }
    public class DbDataService : IDbDataService
    {
        public async Task<List<Data>> GetIngredientsFromDb(int id)
        {
            List<Data> ingredients = new List<Data>();
            using (var client = new HttpClient()) 
            {
                var responser = await client.GetAsync("https://localhost:44358/api/VendingMachine/ingredients/"+id);
                ingredients = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(await responser.Content.ReadAsStringAsync());
            }

            return ingredients;
        }

        public async Task<List<Data>> GetCoffeesFromDB()
        {
            List <Data> coffees=new List<Data> ();
            using (var client = new HttpClient())   
            {
                var response = await client.GetAsync("https://localhost:44358/api/VendingMachine/coffees");
                if (response is null)
                {
                    throw new Exception("Not Found");
                }
                 coffees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(await response.Content.ReadAsStringAsync());
            }

            return coffees;
           
        }
    }
}
