using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormGrocery
{
    public class GroceryStore
    {
        public static Random rand = new Random();

        public  int NumberOfGroceryItems 
        { 
            get
            {
                return ListOfGroceryItems.Count;
            }
        }

        public int NumberOfGrocerySuppliers
        {
            get
            {
                return ListOfGrocerySuppliers.Count;
            }
        }

        public List<GroceryItem> ListOfGroceryItems
        {
            get 
            { 
                    return listOfGroceryItems;
            }
        }

        public List<GrocerySupplier> ListOfGrocerySuppliers
        {
            get
            {
                return listOfGrocerySuppliers;
            }
        }

        static int lastIDUsed = 0;

        public void addGroceryItem(GroceryItem gi)
        {
            lastIDUsed++;
            gi.ID = lastIDUsed;
            listOfGroceryItems.Add(gi);
        }

        public static int CompareGroceryItemsByName(GroceryItem gi1,GroceryItem gi2)
        {
            return String.Compare(gi1.Name,gi2.Name);
        }

        public void sortListOfGroceryItems()
        {
            listOfGroceryItems.Sort(CompareGroceryItemsByName);
        }
       
        public void sortListOfGrocerySuppliers()
        {
            listOfGrocerySuppliers.Sort(CompareGrocerySuppliersByName);
        }
        
        private List<GroceryItem> listOfGroceryItems = new List<GroceryItem>();

       

        static int lastSUPUsed = 0;

        public void addGrocerySupplier(GrocerySupplier gs)
        {
            lastSUPUsed++;
            gs.SUP = lastSUPUsed;
            listOfGrocerySuppliers.Add(gs);
        }

        public static int CompareGrocerySuppliersByName(GrocerySupplier gs1, GrocerySupplier gs2)
        {
            return String.Compare(gs1.CompanyName, gs2.CompanyName);
        }

            private List<GrocerySupplier> listOfGrocerySuppliers = new List<GrocerySupplier>();
    }
}
