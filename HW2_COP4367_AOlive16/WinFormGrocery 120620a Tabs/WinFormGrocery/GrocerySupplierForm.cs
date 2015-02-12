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
    public partial class GrocerySupplierForm : Form
    {
        private GrocerySupplier currentGrocerySupplier = new GrocerySupplier();
        public GroceryStore gSupplier;

        public Form1 parentForm;
        public GrocerySupplierForm()
        {
            InitializeComponent();
            clearErrorColorOnFieldLabels();
        }
        private bool ValidateFields()
        {
            int result;
            bool isOK = true;
            isOK = isOK && int.TryParse(textBoxCompanyName.Text, out result);
            isOK = isOK && int.TryParse(textBoxCN.Text, out result);
            isOK = isOK && int.TryParse(textBoxPN.Text, out result);
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
            clearErrorColor(label1);
            clearErrorColor(label2);
            //labelStatus.Text = "";
        }

        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            clearErrorColorOnFieldLabels();
            bool validData = true;

            currentGrocerySupplier.CompanyName = GetNonBlankStringFromField(textBoxCompanyName, labelName, ref validData);
            currentGrocerySupplier.ContactName = GetNonBlankStringFromField(textBoxCN, label1, ref validData);
            currentGrocerySupplier.PhoneNumber = GetNonBlankStringFromField(textBoxPN, label2, ref validData);

            if (validData)
            {
                gSupplier.addGrocerySupplier(currentGrocerySupplier);
                parentForm.setStatusNumberOfGrocerySuppliers();
                Close();
            }
            else
            {
                //labelStatus.Text = "Invalid Data: Correct Fields Above.";
            }
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
