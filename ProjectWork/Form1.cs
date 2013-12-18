using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectWork
{
    public partial class DerekPOS : Form
    {
        public DerekPOS()
        {
            InitializeComponent();
        }

        decimal ttotal = 0;
        private void AddToChart_Click(object sender, EventArgs e)
        {
            int qty = 0;
            if (cboItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item!");
                cboItems.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                try
                {
                    qty = int.Parse(txtQty.Text);
                    ttotal = ttotal + decimal.Parse((4.5 * qty) + "");
                    txtDue.Text = ttotal.ToString();
                }
                catch (Exception eex)
                {
                    MessageBox.Show("Invalid quantity, please re-enter",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(eex.Message + " occurred in btnAddtoCart");
                    return;
                }

            }
            else if (string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Please specify qty!");
                txtQty.Focus();
                return;
            }

            string item = cboItems.Text;
            decimal price = 4.5m;
            //int qty =0;
            //int.TryParse(txtQty.Text, out qty);
            decimal ExtPrice = price * qty;

            string[] cartline = {
                                     item, 
                                     price.ToString("F2"),
                                     qty.ToString(),
                                     ExtPrice.ToString("F2")
                                 };

            dgvCart.Rows.Add(cartline);
            ClearEntry();
        }

        private void ClearEntry()
        {
            cboItems.SelectedIndex = -1;
            txtQty.Text = "";

        }

        private void Finish_Click(object sender, EventArgs e)
        {
             decimal paid = decimal.Parse((txtPaid.Text) + "");
            if (paid >= ttotal)
            {
                decimal change = paid - ttotal;
                txtChange.Text = change.ToString();
                MessageBox.Show("Done with transaction!");
            }
            else
            {
                MessageBox.Show("Amount paid is less than item cost");
            }

        }

    }
}