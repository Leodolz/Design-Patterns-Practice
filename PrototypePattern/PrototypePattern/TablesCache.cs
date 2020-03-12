using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public static class TablesCache
    {
        private static Dictionary<string, ProductTable> allBundles = new Dictionary<string, ProductTable>();
        public static ProductTable getFixedTable(string bundleName)
        {
            if (allBundles.ContainsKey(bundleName))
                return (ProductTable)allBundles[bundleName].Clone();
            else return null;
        }
        public static void LoadProductsCache()
        {
            allBundles = new Dictionary<string, ProductTable>
            {
                {"CLEAN",CustomedTables.CleanBundle() },
                {"PARTY",CustomedTables.PartyBundle()},
                {"VALENTINE",CustomedTables.ValentinesBundle()}
            };
        }
    }
}
