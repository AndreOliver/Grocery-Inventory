namespace WinFormGrocery
{
    partial class GroceryItemForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.textBoxQOO = new System.Windows.Forms.TextBox();
            this.textBoxROP = new System.Windows.Forms.TextBox();
            this.textBoxRP = new System.Windows.Forms.TextBox();
            this.textBoxWP = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelQOH = new System.Windows.Forms.Label();
            this.labelQOO = new System.Windows.Forms.Label();
            this.labelROP = new System.Windows.Forms.Label();
            this.labelRP = new System.Windows.Forms.Label();
            this.labelWP = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 17);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.Location = new System.Drawing.Point(124, 44);
            this.textBoxQOH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(198, 20);
            this.textBoxQOH.TabIndex = 1;
            // 
            // textBoxQOO
            // 
            this.textBoxQOO.Location = new System.Drawing.Point(124, 71);
            this.textBoxQOO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQOO.Name = "textBoxQOO";
            this.textBoxQOO.Size = new System.Drawing.Size(198, 20);
            this.textBoxQOO.TabIndex = 2;
            // 
            // textBoxROP
            // 
            this.textBoxROP.Location = new System.Drawing.Point(124, 98);
            this.textBoxROP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxROP.Name = "textBoxROP";
            this.textBoxROP.Size = new System.Drawing.Size(198, 20);
            this.textBoxROP.TabIndex = 3;
            // 
            // textBoxRP
            // 
            this.textBoxRP.Location = new System.Drawing.Point(124, 124);
            this.textBoxRP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRP.Name = "textBoxRP";
            this.textBoxRP.Size = new System.Drawing.Size(198, 20);
            this.textBoxRP.TabIndex = 4;
            // 
            // textBoxWP
            // 
            this.textBoxWP.Location = new System.Drawing.Point(124, 151);
            this.textBoxWP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxWP.Name = "textBoxWP";
            this.textBoxWP.Size = new System.Drawing.Size(198, 20);
            this.textBoxWP.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(27, 17);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelQOH
            // 
            this.labelQOH.AutoSize = true;
            this.labelQOH.Location = new System.Drawing.Point(27, 44);
            this.labelQOH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQOH.Name = "labelQOH";
            this.labelQOH.Size = new System.Drawing.Size(92, 13);
            this.labelQOH.TabIndex = 7;
            this.labelQOH.Text = "Quantity On Hand";
            // 
            // labelQOO
            // 
            this.labelQOO.AutoSize = true;
            this.labelQOO.Location = new System.Drawing.Point(27, 71);
            this.labelQOO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQOO.Name = "labelQOO";
            this.labelQOO.Size = new System.Drawing.Size(92, 13);
            this.labelQOO.TabIndex = 8;
            this.labelQOO.Text = "Quantity On Order";
            // 
            // labelROP
            // 
            this.labelROP.AutoSize = true;
            this.labelROP.Location = new System.Drawing.Point(27, 98);
            this.labelROP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelROP.Name = "labelROP";
            this.labelROP.Size = new System.Drawing.Size(72, 13);
            this.labelROP.TabIndex = 9;
            this.labelROP.Text = "Reorder Point";
            // 
            // labelRP
            // 
            this.labelRP.AutoSize = true;
            this.labelRP.Location = new System.Drawing.Point(27, 124);
            this.labelRP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRP.Name = "labelRP";
            this.labelRP.Size = new System.Drawing.Size(61, 13);
            this.labelRP.TabIndex = 10;
            this.labelRP.Text = "Retail Price";
            // 
            // labelWP
            // 
            this.labelWP.AutoSize = true;
            this.labelWP.Location = new System.Drawing.Point(27, 151);
            this.labelWP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWP.Name = "labelWP";
            this.labelWP.Size = new System.Drawing.Size(84, 13);
            this.labelWP.TabIndex = 11;
            this.labelWP.Text = "Wholesale Price";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(70, 199);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(69, 42);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 199);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 42);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(26, 249);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(295, 19);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "Status String";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GroceryItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 277);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelWP);
            this.Controls.Add(this.labelRP);
            this.Controls.Add(this.labelROP);
            this.Controls.Add(this.labelQOO);
            this.Controls.Add(this.labelQOH);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxWP);
            this.Controls.Add(this.textBoxRP);
            this.Controls.Add(this.textBoxROP);
            this.Controls.Add(this.textBoxQOO);
            this.Controls.Add(this.textBoxQOH);
            this.Controls.Add(this.textBoxName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroceryItemForm";
            this.Text = "Grocery Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.TextBox textBoxQOO;
        private System.Windows.Forms.TextBox textBoxROP;
        private System.Windows.Forms.TextBox textBoxRP;
        private System.Windows.Forms.TextBox textBoxWP;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelQOH;
        private System.Windows.Forms.Label labelQOO;
        private System.Windows.Forms.Label labelROP;
        private System.Windows.Forms.Label labelRP;
        private System.Windows.Forms.Label labelWP;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelStatus;
    }
}