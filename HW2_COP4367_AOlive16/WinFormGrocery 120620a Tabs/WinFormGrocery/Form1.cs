using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WinFormGrocery
{
    public partial class Form1 : Form
    {
        GroceryStore groceryStore;
        GrocerySupplier grocerySupplier;
        SoundPlayer My_JukeBox = new SoundPlayer(@"C:\Users\Tom\Documents\Projects\Classes\GAD\WinFormGrocery\DisplayReorderList.wav");
        public Form1()
        {
            InitializeComponent();
            groceryStore = new GroceryStore();
            grocerySupplier = new GrocerySupplier();
            labelStatus.Text = "";
        }

        public void setStatusString(string status)
        {
            labelStatus.Text = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGroceryItem();
        }

        private void AddGroceryItem()
        {
            GroceryItemForm gif = new GroceryItemForm();
            gif.gStore = groceryStore;
            gif.parentForm = this;
            gif.ShowDialog();
        }

        private void buttonShowGroceryList_Click(object sender, EventArgs e)
        {
            ShowGroceryListForm sglf = new ShowGroceryListForm();
            groceryStore.sortListOfGroceryItems();
            sglf.listOfGI = groceryStore.ListOfGroceryItems;
            sglf.Show();
        }

        public void setStatusNumberOfGroceryItems()
        {
            setStatusString(String.Format("{0} Grocery Items", groceryStore.NumberOfGroceryItems));
        }

        public void setStatusNumberOfGrocerySuppliers()
        {
            setStatusString(String.Format("{0} Grocery Items", groceryStore.NumberOfGroceryItems));
        }

        private void buttonAddRandomGIs_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int count = (int)numericUpDownRandomAddCount.Value;
            for (int i = 0; i < count; i++)
            {
                GroceryItem gi = new GroceryItem();
                gi.randomize();
                groceryStore.addGroceryItem(gi);
            }
            setStatusNumberOfGroceryItems();
            Cursor = Cursors.Default;
        }

        private void buttonShowReorderList_Click(object sender, EventArgs e)
        {
            My_JukeBox.Play();           
            List<GroceryItem> reorderList = new List<GroceryItem>();
            foreach (GroceryItem gi in groceryStore.ListOfGroceryItems)
            {
                if (gi.QuantityOnHand + gi.QuantityOnOrder < gi.ReorderPoint)
                {
                    reorderList.Add(gi);
                }
            }
            reorderList.Sort(GroceryStore.CompareGroceryItemsByName);
            ShowGroceryListForm sglf = new ShowGroceryListForm();
            sglf.listOfGI = reorderList;
            sglf.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddGroceryItem();
        }

        private void buttonShowSupplierList_Click(object sender, EventArgs e)
        {
            ShowGroceryListForm sglf = new ShowGroceryListForm();
            groceryStore.sortListOfGroceryItems();
            sglf.listOfGI = groceryStore.ListOfGroceryItems;
            sglf.Show();

            /*ShowGrocerySupplierForm sgsf = new ShowGrocerySupplierForm();
            groceryStore.sortListOfGrocerySuppliers();
            sgsf.listOfGS = groceryStore.ListOfGrocerySuppliers;
            sgsf.Show();*/
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            GrocerySupplierForm gsf = new GrocerySupplierForm();
            gsf.gSupplier = groceryStore;
            gsf.parentForm = this;
            gsf.ShowDialog();
        }

        private void buttonAddRandomSupplier_Click(object sender, EventArgs e)
        {
            
            Cursor = Cursors.WaitCursor;
            int count = (int)numericUpDownRandomAddCount.Value;
            for (int i = 0; i < count; i++)
            {
                GrocerySupplier gs = new GrocerySupplier();                
                gs.randomizeSUP();
                groceryStore.addGrocerySupplier(gs);
            }
            setStatusNumberOfGrocerySuppliers();
            Cursor = Cursors.Default;         
            
        }
    }
}
