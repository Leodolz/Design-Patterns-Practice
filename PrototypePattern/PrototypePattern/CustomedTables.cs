using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public static class CustomedTables
    {
        public static ProductTable CleanBundle()
        {
            ProductTable cleanBundle = new ProductTable();
            cleanBundle.name = "Clean Bundle";
            List<Product> cleanProductsList = new List<Product>
            {
                new Product("BroomStick",10.99),
                new Product("Mop",7.99),
                new Product("Floor Cleaner 5LT",15.99),
                new Product("TrashCan",5.99)
            };
            cleanBundle.products.AddRange(cleanProductsList);
            return cleanBundle;
        }
        public static ProductTable PartyBundle()
        {
            ProductTable partyBundle = new ProductTable();
            partyBundle.name = "Party Bundle";
            List<Product> cleanProductsList = new List<Product>
            {
                new Product("Chips",3.99),
                new Product("Soda",1.99),
                new Product("Beer - Six Pack",15.99),
                new Product("Dip Sauce",4.99)
            };
            partyBundle.products.AddRange(cleanProductsList);
            return partyBundle;
        }
        public static ProductTable ValentinesBundle()
        {
            ProductTable valentinesBundle = new ProductTable();
            valentinesBundle.name = "Valentine's Bundle";
            List<Product> cleanProductsList = new List<Product>
            {
                new Product("Chocolates",10.99),
                new Product("Teddy Bear",14.99),
                new Product("Rose",1.99),
                new Product("Gift Card",2.99)
            };
            valentinesBundle.products.AddRange(cleanProductsList);
            return valentinesBundle;
        }
    }
}
