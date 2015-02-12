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
    public partial class ShowGrocerySupplierForm : Form
    {
        public List<GrocerySupplier> listOfGS;

        public ShowGrocerySupplierForm()
        {
            InitializeComponent();
            Cursor = Cursors.WaitCursor;
        }

        private void ShowGrocerySupplierForm_Shown(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void ShowGrocerySupplierForm_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            dataGridView1.DataSource = listOfGS;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
