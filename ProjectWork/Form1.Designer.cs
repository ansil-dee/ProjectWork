namespace ProjectWork
{
    partial class DerekPOS
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
            this.Finish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(573, 322);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(69, 29);
            this.Finish.TabIndex = 0;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Due";
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(542, 30);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 2;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(542, 88);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(100, 20);
            this.txtPaid.TabIndex = 3;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(542, 133);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Change";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(79, 67);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Qty";
            // 
            // cboItems
            // 
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Items.AddRange(new object[] {
            "Milo",
            "Sugar",
            "Rice",
            "Milk",
            "Beans",
            "Gari",
            "Nido",
            "Chocolate"});
            this.cboItems.Location = new System.Drawing.Point(70, 20);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(121, 21);
            this.cboItems.TabIndex = 11;
            this.cboItems.Text = "Items";
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Items,
            this.Price,
            this.Qty,
            this.Total});
            this.dgvCart.Location = new System.Drawing.Point(79, 201);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(439, 150);
            this.dgvCart.TabIndex = 12;
            // 
            // Items
            // 
            this.Items.HeaderText = "Item";
            this.Items.Name = "Items";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // AddToChart
            // 
            this.AddToChart.Location = new System.Drawing.Point(79, 135);
            this.AddToChart.Name = "AddToChart";
            this.AddToChart.Size = new System.Drawing.Size(100, 23);
            this.AddToChart.TabIndex = 13;
            this.AddToChart.Text = "Add To Chart";
            this.AddToChart.UseVisualStyleBackColor = true;
            this.AddToChart.Click += new System.EventHandler(this.AddToChart_Click);
            // 
            // DerekPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 378);
            this.Controls.Add(this.AddToChart);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.cboItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Finish);
            this.Name = "DerekPOS";
            this.Text = "Derek POS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button AddToChart;
    }
}

