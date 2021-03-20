using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    struct Item
    {
        public string Itemname;       
        public double ItemPrice;
    }

    public partial class frmVendingMachine : Form
    {
        public frmVendingMachine()
        {
            InitializeComponent();
        }

            string[,] ItemDesc = new string[,] { { "Cola", "1"}, 
                { "Chips",".5"}, 
                { "Candy",".64"}
                };
            Item selItem;

        static int Insertedcoin = 1;
        private void rbtn_cola_CheckedChanged(object sender, EventArgs e)
        {
            selItem.Itemname = ItemDesc[0, 0];           
            selItem.ItemPrice = Convert.ToDouble(ItemDesc[0, 1]);
            if (selItem.ItemPrice <= new Coin().ValidateCoin(Insertedcoin))
            {
                lblDisplay.Text = "The total is amount for " + selItem.Itemname + " is " + selItem.ItemPrice;
            }
            else
            {
                lblDisplay.Text = "Please Insert coin";
            }

        }

        private void rbtn_chips_CheckedChanged(object sender, EventArgs e)
        {
            selItem.Itemname = ItemDesc[1, 0];
            selItem.ItemPrice = Convert.ToDouble(ItemDesc[1, 1]);
            if (selItem.ItemPrice <= new Coin().ValidateCoin(Insertedcoin))
            {
                lblDisplay.Text = "The total is amount for " + selItem.Itemname + " is " + selItem.ItemPrice;
            }
            else
            {
                lblDisplay.Text = "Please Insert coin";
            }
        }

        private void rbtn_candy_CheckedChanged(object sender, EventArgs e)
        {
            selItem.Itemname = ItemDesc[2, 0];
            selItem.ItemPrice = Convert.ToDouble(ItemDesc[2, 1]);
            if (selItem.ItemPrice <= new Coin().ValidateCoin(Insertedcoin))
            {
                lblDisplay.Text = "The total is amount for " + selItem.Itemname + " is " + selItem.ItemPrice;
            }
            else
            {
                lblDisplay.Text = "Please Insert coin";
            }
               
        }
}
    
}
