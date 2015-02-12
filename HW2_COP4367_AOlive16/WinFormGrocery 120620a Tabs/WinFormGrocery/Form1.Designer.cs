namespace WinFormGrocery
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonShowGroceryList = new System.Windows.Forms.Button();
            this.buttonAddRandomGIs = new System.Windows.Forms.Button();
            this.numericUpDownRandomAddCount = new System.Windows.Forms.NumericUpDown();
            this.buttonShowReorderList = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonAddRandomSupplier = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonShowSupplierList = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomAddCount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Grocery Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(-27, 292);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(248, 24);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status String";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonShowGroceryList
            // 
            this.buttonShowGroceryList.Location = new System.Drawing.Point(32, 75);
            this.buttonShowGroceryList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowGroceryList.Name = "buttonShowGroceryList";
            this.buttonShowGroceryList.Size = new System.Drawing.Size(137, 51);
            this.buttonShowGroceryList.TabIndex = 2;
            this.buttonShowGroceryList.Text = "Show Grocery List";
            this.buttonShowGroceryList.UseVisualStyleBackColor = true;
            this.buttonShowGroceryList.Click += new System.EventHandler(this.buttonShowGroceryList_Click);
            // 
            // buttonAddRandomGIs
            // 
            this.buttonAddRandomGIs.Location = new System.Drawing.Point(32, 188);
            this.buttonAddRandomGIs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddRandomGIs.Name = "buttonAddRandomGIs";
            this.buttonAddRandomGIs.Size = new System.Drawing.Size(137, 51);
            this.buttonAddRandomGIs.TabIndex = 3;
            this.buttonAddRandomGIs.Text = "Add Random G.I.";
            this.buttonAddRandomGIs.UseVisualStyleBackColor = true;
            this.buttonAddRandomGIs.Click += new System.EventHandler(this.buttonAddRandomGIs_Click);
            // 
            // numericUpDownRandomAddCount
            // 
            this.numericUpDownRandomAddCount.Location = new System.Drawing.Point(32, 244);
            this.numericUpDownRandomAddCount.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownRandomAddCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownRandomAddCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRandomAddCount.Name = "numericUpDownRandomAddCount";
            this.numericUpDownRandomAddCount.Size = new System.Drawing.Size(137, 20);
            this.numericUpDownRandomAddCount.TabIndex = 4;
            this.numericUpDownRandomAddCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonShowReorderList
            // 
            this.buttonShowReorderList.Location = new System.Drawing.Point(32, 19);
            this.buttonShowReorderList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowReorderList.Name = "buttonShowReorderList";
            this.buttonShowReorderList.Size = new System.Drawing.Size(137, 51);
            this.buttonShowReorderList.TabIndex = 5;
            this.buttonShowReorderList.Text = "Show Reorder List";
            this.toolTip1.SetToolTip(this.buttonShowReorderList, "This Button will display a report showing you which groceries need to be reordere" +
        "d.");
            this.buttonShowReorderList.UseVisualStyleBackColor = true;
            this.buttonShowReorderList.Click += new System.EventHandler(this.buttonShowReorderList_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(215, 320);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonShowReorderList);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.numericUpDownRandomAddCount);
            this.tabPage1.Controls.Add(this.labelStatus);
            this.tabPage1.Controls.Add(this.buttonAddRandomGIs);
            this.tabPage1.Controls.Add(this.buttonShowGroceryList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(207, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grocery Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.buttonAddRandomSupplier);
            this.tabPage2.Controls.Add(this.buttonAddSupplier);
            this.tabPage2.Controls.Add(this.buttonShowSupplierList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(207, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suppliers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(32, 244);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(137, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddRandomSupplier
            // 
            this.buttonAddRandomSupplier.Location = new System.Drawing.Point(32, 131);
            this.buttonAddRandomSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddRandomSupplier.Name = "buttonAddRandomSupplier";
            this.buttonAddRandomSupplier.Size = new System.Drawing.Size(137, 51);
            this.buttonAddRandomSupplier.TabIndex = 8;
            this.buttonAddRandomSupplier.Text = "Add Random Supplier";
            this.toolTip1.SetToolTip(this.buttonAddRandomSupplier, "This Button will display a report showing you which groceries need to be reordere" +
        "d.");
            this.buttonAddRandomSupplier.UseVisualStyleBackColor = true;
            this.buttonAddRandomSupplier.Click += new System.EventHandler(this.buttonAddRandomSupplier_Click);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Location = new System.Drawing.Point(32, 75);
            this.buttonAddSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(137, 51);
            this.buttonAddSupplier.TabIndex = 7;
            this.buttonAddSupplier.Text = "Add Supplier";
            this.toolTip1.SetToolTip(this.buttonAddSupplier, "This Button will display a report showing you which groceries need to be reordere" +
        "d.");
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // buttonShowSupplierList
            // 
            this.buttonShowSupplierList.Location = new System.Drawing.Point(32, 19);
            this.buttonShowSupplierList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowSupplierList.Name = "buttonShowSupplierList";
            this.buttonShowSupplierList.Size = new System.Drawing.Size(137, 51);
            this.buttonShowSupplierList.TabIndex = 6;
            this.buttonShowSupplierList.Text = "Show Supplier List";
            this.toolTip1.SetToolTip(this.buttonShowSupplierList, "This Button will display a report showing you which groceries need to be reordere" +
        "d.");
            this.buttonShowSupplierList.UseVisualStyleBackColor = true;
            this.buttonShowSupplierList.Click += new System.EventHandler(this.buttonShowSupplierList_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripDropDownButton1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(229, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.ToolTipText = "Add Grocery Item";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(76, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 384);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Win Forms Grocery ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomAddCount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonShowGroceryList;
        private System.Windows.Forms.Button buttonAddRandomGIs;
        private System.Windows.Forms.NumericUpDown numericUpDownRandomAddCount;
        private System.Windows.Forms.Button buttonShowReorderList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonAddRandomSupplier;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonShowSupplierList;
    }
}

