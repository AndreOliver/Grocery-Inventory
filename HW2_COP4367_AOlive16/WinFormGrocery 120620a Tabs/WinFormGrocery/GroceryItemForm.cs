using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormGrocery
{
    public partial class GroceryItemForm : Form
    {
        private GroceryItem currentGroceryItem = new GroceryItem();
        public GroceryStore gStore;
      
        public Form1 parentForm;
        public GroceryItemForm()
        {
            InitializeComponent();
            clearErrorColorOnFieldLabels();
        }

        private bool ValidateFields()
        {
            int result;
            bool isOK=true;
            isOK = isOK && int.TryParse(textBoxQOH.Text, out result);
            isOK = isOK && int.TryParse(textBoxQOO.Text, out result);
            return isOK;
        }
    
        private void clearErrorColor(Label lab)
        {
            lab.BackColor = SystemColors.Control;
            lab.ForeColor = SystemColors.ControlText;
        }

        private void clearErrorColorOnFieldLabels()
        {
            clearErrorColor(labelName);
            clearErrorColor(labelQOH);
            clearErrorColor(labelQOO);
            clearErrorColor(labelROP);
            clearErrorColor(labelRP);
            clearErrorColor(labelWP);
            labelStatus.Text = "";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            clearErrorColorOnFieldLabels();
            bool validData = true;

            currentGroceryItem.Name = GetNonBlankStringFromField(textBoxName, labelName, ref validData);

            currentGroceryItem.QuantityOnHand = GetIntFromField(textBoxQOH, labelQOH, ref validData);
            currentGroceryItem.QuantityOnOrder = GetIntFromField(textBoxQOO, labelQOO, ref validData);
            currentGroceryItem.ReorderPoint = GetIntFromField(textBoxROP, labelROP, ref validData);

            currentGroceryItem.RetailPrice = GetDecimalFromField(textBoxRP, labelRP, ref validData);
            currentGroceryItem.WholesalePrice = GetDecimalFromField(textBoxWP, labelWP, ref validData);

            if (validData)
            {
                gStore.addGroceryItem(currentGroceryItem);
                parentForm.setStatusNumberOfGroceryItems();
                Close();
            }
            else
            {
                labelStatus.Text = "Invalid Data: Correct Fields Above.";
            }
        }

        private decimal GetDecimalFromField(TextBox tb, Label lab, ref bool validData)
        {
            Decimal result;
            //Regex g = new Regex(@"(^\d+.\d{2}$)|(^.\d{2}$)|(^\d+$)|(^\d+.$)"); //works but no blanks
            //Regex g = new Regex(@"^\s*(\d*.\d{2}$)|(\d+$)|(\d+.)\s*$"); //does not work
            //Regex g = new Regex(@"(^\s*\d+.\d{2}\s*$)|(^\s*.\d{2}\s*$)|(^\s*\d+\s*$)|(^\s*\d+.\s*$)"); //works
            Regex g = new Regex(@"^\s*( (\d*.\d{2}) |(\d+)|(\d+.))\s*$"); //better
            Match m = g.Match(tb.Text);
            if (m.Success)
            {
                result = Convert.ToDecimal(m.Value);
            }
            else
            {
                result = 0.0M;
                SetLabelToErrorColor(lab);
                validData = false;
            }
            return result;
        }

        private String GetNonBlankStringFromField(TextBox tb, Label lab, ref bool validData)
        {
            String result;
            if (tb.Text.Length != 0)
            {
                result = tb.Text;
            }
            else
            {
                result = "";
                SetLabelToErrorColor(lab);
                validData = false;
            }
            return result;
        }

        private int GetIntFromField(TextBox tb, Label lab, ref bool validData)
        {
            int testValue;
            int result;

            if (int.TryParse(tb.Text, out testValue))
            {
                result = testValue;
            }
            else
            {
                result = 0;
                SetLabelToErrorColor(lab);
                validData = false;
            }
            return result;
        }

        private void SetLabelToErrorColor(Label badLabel)
        {
            badLabel.BackColor = Color.Red;
            badLabel.ForeColor = Color.Yellow;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
