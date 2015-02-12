using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormGrocery
{
    public class GroceryItem
    {
        public String Name
        {
            get{return name;}
            set{name = value;}
        }

        public int QuantityOnHand
        {
            get { return quantityOnHand; }
            set { quantityOnHand = value; }
        }

        public int QuantityOnOrder
        {
            get { return quantityOnOrder; }
            set { quantityOnOrder = value; }
        }

        public int ReorderPoint
        {
            get { return reorderPoint; }
            set { reorderPoint = value; }
        }

        public Decimal WholesalePrice{get; set;}
        public Decimal RetailPrice{get; set;}

        public Decimal WholesaleValue
        {
            get
            {
                return WholesalePrice * QuantityOnHand;
            }
        }

        public int ID { get; set; }

        private String name;
        private int quantityOnHand;
        private int quantityOnOrder;
        private int reorderPoint;
        //private Decimal wholesalePrice;
        //private Decimal retailPrice;

        public void randomize()
        {
            name = randString(7, 15);
            quantityOnHand = GroceryStore.rand.Next(1000);
            quantityOnOrder = GroceryStore.rand.Next(1000);
            reorderPoint = GroceryStore.rand.Next(1000);
            RetailPrice = Convert.ToDecimal(GroceryStore.rand.Next(10000)) / 100M;
            WholesalePrice = Convert.ToDecimal(GroceryStore.rand.Next(10000)) / 100M;
        }

        string randString(int minLength,int maxLength)
        {
            string result=new String('x',0);
            int length = GroceryStore.rand.Next(minLength, maxLength + 1);
            for (int i = 0; i < length; i++)
            {
                result += (char)((char)(GroceryStore.rand.Next(26)) + 'A');
            }
            return result;
        }


    }
    public class GrocerySupplier
    {
        public String CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        
        public int SUP { get; set; }
        private String companyName;
        private String contactName;
        private String phoneNumber;

        public void randomizeSUP()
        {
            companyName = randString(7, 15);
            contactName = randString(7, 15);
            phoneNumber = randString(7, 15);
           // RetailPrice = Convert.ToDecimal(GroceryStore.rand.Next(10000)) / 100M;
          
            
        }

        string randString(int minLength, int maxLength)
        {
            string result = new String('x', 0);
            int length = GroceryStore.rand.Next(minLength, maxLength + 1);
            for (int i = 0; i < length; i++)
            {
                result += (char)((char)(GroceryStore.rand.Next(26)) + 'A');
            }
            return result;
        }

    }
}
