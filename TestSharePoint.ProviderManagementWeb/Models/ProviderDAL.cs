using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSharePoint.ProviderManagementWeb.Models
{
    public class ProviderDAL
    {

         

        public ProviderDAL()
        {

        }

        public List<Provider> GetAll()
        {
            return new List<Provider>()
            {
                new Provider()
                {
                    Name = "K2 France",
                    Address = "46 R Chanzy, Paris",
                    Country = "France"
                },
                new Provider()
                {
                    Name = "Zara",
                    Address = "Av des champs élysées",
                    Country = "France"
                },
                 new Provider()
                {
                    Name = "Ford Motor",
                    Address = "Main Street, Detroit",
                    Country = "USA"
                },

            };
        }
            
    }
}