using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;

public class CacheManager
{
	public CacheManager()
	{
        
	
    }
    public static void ResetCache(HttpApplication application)
    {
        CacheManager.ClearCache(application);
        CacheManager.BuildCache(application);
    }
    public static void ClearCache(HttpApplication application)
    {
        application.Context.Cache.Remove("Data");
    }
    public static void BuildCache(HttpApplication application)
    {
         List<String> listData = new List<string>(){"Chai","Chang","Aniseed Syrup","Northwoods Cranberry Sauce",
            "Mishi Kobe Niku","Ikura","Queso Cabrales","Queso Manchego La Pastora","Konbu","Tofu",
            "Genen Shouyu","Pavlova","Alice Mutton","Carnarvon Tigers","Teatime Chocolate Biscuits",
            "Schoggi Schokolade","Gorgonzola Telino","Mascarpone Fabioli","Geitost","Sasquatch Ale",
            "Steeleye Stout","Inlagd Sill","Gravad lax","Chartreuse verte","Boston Crab Meat",
            "Singaporean Hokkien Fried Mee","Ipoh Coffee","Gula Malacca","Rogede sild","Spegesild","Zaanse koeken"};

        
        System.Data.DataTable table = new System.Data.DataTable();
        table.Columns.Add("ProductID", typeof(int));
        table.Columns.Add("ProductName");
        table.Columns.Add("UnitPrice",typeof(decimal));
        table.PrimaryKey = new System.Data.DataColumn[] { table.Columns["ProductID"] };
        for (int i = 0; i < listData.Count; i++)
        {
            table.Rows.Add(i+1, listData[i], (i * listData[i].Length)/4);
        }

        application.Context.Cache.Insert("Data", table, null, DateTime.UtcNow.AddDays(1), System.Web.Caching.Cache.NoSlidingExpiration);
    }
}