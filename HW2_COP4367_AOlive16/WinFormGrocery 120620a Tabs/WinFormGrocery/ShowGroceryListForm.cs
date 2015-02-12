using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormGrocery
{
    public partial class ShowGroceryListForm : Form
    {
        public List<GroceryItem> listOfGI;

        public ShowGroceryListForm()
        {
            InitializeComponent();
            Cursor = Cursors.WaitCursor;
        }

        private void ShowGroceryListForm_Shown(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void ShowGroceryListForm_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor; 
            dataGridViewGroceryList.DataSource = listOfGI;
        }

        private void dataGridViewGroceryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
