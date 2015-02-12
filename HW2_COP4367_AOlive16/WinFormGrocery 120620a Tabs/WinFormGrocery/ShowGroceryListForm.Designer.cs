namespace WinFormGrocery
{
    partial class ShowGroceryListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewGroceryList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroceryList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGroceryList
            // 
            this.dataGridViewGroceryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGroceryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroceryList.Location = new System.Drawing.Point(-1, 2);
            this.dataGridViewGroceryList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewGroceryList.Name = "dataGridViewGroceryList";
            this.dataGridViewGroceryList.RowTemplate.Height = 24;
            this.dataGridViewGroceryList.Size = new System.Drawing.Size(741, 573);
            this.dataGridViewGroceryList.TabIndex = 0;
            this.dataGridViewGroceryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroceryList_CellContentClick);
            // 
            // ShowGroceryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 574);
            this.Controls.Add(this.dataGridViewGroceryList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowGroceryListForm";
            this.Text = "ShowGroceryListForm";
            this.Load += new System.EventHandler(this.ShowGroceryListForm_Load);
            this.Shown += new System.EventHandler(this.ShowGroceryListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroceryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGroceryList;
    }
}