/*
Cash Register Project

C-SHARP Blades Co.

March 3, 2025
Nathan Ehnes


DISCOUNT CODE: "CHOPCHOP20" for 20% off
Password for order history: "NATHAN2025"
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        //running list of previous transactions and password to access
        List<double> orderHistory = new List<double>();
        string historyPassword = "NATHAN2025";

        //running transaction counter
        int transactionNumber = 0;

        //to hold item prices
        const double daggerCost = 49.99;
        const double kukriCost = 79.99;
        const double scytheCost = 109.99;

        //item quantities
        int daggerQty = 0;
        int kukriQty = 0;
        int scytheQty = 0;

        //variables to hold discount details
        double discountRate = 0;
        double discountAmount = 0;
        const string discountCode = "CHOPCHOP20";

        //variables to hold sale details
        double tendered = 0;
        double change;
        double subtotal = 0;
        double total = 0;
        double taxAmount = 0;
        const double taxRate = 0.13;

        //default receipt layout
        string[] receipt = new string[18] {
            "******C-SHARP Blades Co.******",
            "",
            "   Transaction Number: 0001   ",
            "",
            "DAGGER             1 @  $59.99",
            "KUKRI              2 @  $79.99",
            "SCYTHE             3 @ $109.99",
            "",
            "",
            "            Subtotal = $100.00",
            "         20% DISCOUNT = $20.00",
            "                  Tax = $10.11",
            "                Total = $98.11",
            "",
            "            Tendered = $100.00",
            "                Change = $2.89",
            "",
            "******THANKS FOR SHOPPING******"
            };

        public Form1()
        {
            InitializeComponent();

            //reset
            newOrder();
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            discountButton.Visible = false;
            //replace button with input box and indicator
            discountBox.Visible = true;
            discountIndicator.Visible = true;
        }

        //validate discount code whenever the text changes
        private void discountBox_TextChanged(object sender, EventArgs e)
        {
            if (discountBox.Text == discountCode)
            {
                discountIndicator.BackColor = Color.Green; //dscount code is good
                discountRate = .20;
            }
            else
            {
                discountIndicator.BackColor = Color.Red; //discount code is bad
                discountRate = 0;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //set blank fields to 0
                if (daggerInput.Text == "")
                {
                    daggerInput.Text = "0";
                }
                if (kukriInput.Text == "")
                {
                    kukriInput.Text = "0";
                }
                if (scytheInput.Text == "")
                {
                    scytheInput.Text = "0";
                }

                //update quantity variables
                daggerQty = Convert.ToInt32(daggerInput.Text);
                kukriQty = Convert.ToInt32(kukriInput.Text);
                scytheQty = Convert.ToInt32(scytheInput.Text);

                //update the calculation variables 	↓ ↓ ↓
                subtotal = daggerQty * daggerCost + kukriQty * kukriCost + scytheQty * scytheCost;
                totalsBox.Text = "Subtotal: $" + subtotal.ToString("0.#0") + '\n';

                if (discountRate != 0) //only prints if discount is applied
                {
                    discountAmount = subtotal * discountRate;
                    totalsBox.Text += "20% Discount: -$" + (discountAmount).ToString("0.#0") + '\n';
                }

                taxAmount = subtotal * taxRate;
                totalsBox.Text += "Tax: $" + (taxAmount).ToString("0.#0") + '\n' + '\n';

                total = subtotal * (1 - discountRate) * (1 + taxRate);
                totalsBox.Text += "Total: $" + total.ToString("0.#0") + '\n' + '\n';

                //disable input fields
                changeButton.Enabled = true;
                calculateButton.Enabled = false;
                daggerInput.Enabled = false;
                kukriInput.Enabled = false;
                scytheInput.Enabled = false;
                discountButton.Enabled = false;
                discountBox.Enabled = false;

                tenderedInput.Enabled = true;
            }
            catch
            {
                totalsBox.Text = "ENTER INTEGERS ONLY";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //subtract total from tendered and print
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                tendered = Math.Round(tendered, 2);

                if (tendered > total)
                {
                    change = tendered - total;

                    changeBox.Text = "Change Due: " + (change).ToString("0.#0");

                    receiptButton.Enabled = true;
                    changeButton.Enabled = false;
                    tenderedInput.Enabled = false;

                }
                else
                {
                    changeBox.Text = "Not Enough Money";
                }
            }
            catch
            {
                changeBox.Text = "ENTER NUMEBRS ONLY";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            transactionNumber++;

            //update strings for receipt printout - theres gotta be a better way
            receipt[2] = $"    Transaction Number: {transactionNumber.ToString("0000")}        ";
            receipt[4] = $"DAGGER     {daggerQty} @  $59.99";
            receipt[5] = $"KUKRI     {kukriQty} @  $79.99";
            receipt[6] = $"SCYTHE     {scytheQty} @ $109.99";

            receipt[9] = $"  Subtotal = ${subtotal.ToString("0.00")}";
            receipt[10] = $"  20% DISCOUNT = -${discountAmount.ToString("00.00")}";
            receipt[11] = $"  Tax =  ${taxAmount.ToString("0.00")}";
            receipt[12] = $"  Total = ${total.ToString("0.00")}";
            receipt[14] = $"  Tendered = ${tendered.ToString("0.00")}";
            receipt[15] = $"  Change = ${change.ToString("0.00")}";

            SoundPlayer receiptNoise = new SoundPlayer(Properties.Resources.receiptPrint);
            receiptNoise.Play();

            //disable buttons during printing
            newOrderButton.Enabled = false;
            receiptButton.Enabled= false;
            historyButton.Enabled = false;

            for (int i = 0; i < 18; i++) //prints one line at a time, mimicing printer
            {
                //skip lines if N/A
                //using 'continue' doesnt update properly
                if (daggerQty == 0 && i == 4)
                {
                    i++;        
                }
                if (kukriQty == 0 && i == 5)
                {
                    i++;        
                }
                if (scytheQty == 0 && i == 6)
                {
                    i++;        
                }
                if (discountRate == 0 && i == 10)
                {
                    i++;          
                }

                //increment y-size and y-coordinate
                int ySize = 13 * i;
                int yLocation = 13 * i;

                //update size and location
                receiptBox.Size = new Size(196, 22 + ySize);
                receiptBox.Location = new Point(266, 361 - yLocation);

                //print the line
                receiptBox.Text += receipt[i] + '\n';

                Refresh();

                Thread.Sleep(70);
            }

            newOrderButton.Enabled = true;
            historyButton.Enabled = true;

            orderHistory.Add(total);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            //open password field
            historyButton.Visible = false;
            historyPasswordInput.Visible = true;
        }

        
        private void historyPasswordInput_TextChanged(object sender, EventArgs e)
        {
            //validate password whenever text changes 
            if (historyPasswordInput.Text == historyPassword)
            {
                historyPasswordInput.Enabled = false;

                //widen form and create/modify a label

                this.Size = new Size(650, 500);

                Label historyOutput = new Label();

                historyOutput.Location = new Point(510, 25);
                historyOutput.Size = new Size(120, 400);
                historyOutput.BackColor = Color.Beige;

                this.Controls.Add(historyOutput);

                //header
                historyOutput.Text = "ORDER//TOTAL" + '\n' + '\n';

                //print every element in list - could use foreach
                for (int i = 0; i < orderHistory.Count; i++)
                {
                    historyOutput.Text += $"{i + 1}" + "---------------" + Math.Round(orderHistory[i], 2) + '\n';

                    Thread.Sleep(300);
                    Refresh();
                }

                historyOutput.Text += '\n' + "Press 'new order' to exit";
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            newOrder();

            historyButton.Enabled = true;
        }

        void newOrder()
        {
            //reset quantity fields
            daggerInput.Text = "";
            kukriInput.Text = "";
            scytheInput.Text = "";
            tenderedInput.Text = "";

            //clear text fields
            totalsBox.Text = "";
            changeBox.Text = "";
            receiptBox.Text = "";
            discountBox.Text = "";
            discountBox.Text = "Discount Code Here";

            //allow this to be edited
            discountBox.Enabled = true;

            //enable/disable necessary buttons
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            historyButton.Enabled = false;
            calculateButton.Enabled = true;
            discountButton.Enabled = true;

            //enable/disable necessary input boxes
            daggerInput.Enabled = true;
            kukriInput.Enabled = true;
            scytheInput.Enabled = true;
            tenderedInput.Enabled = false;

            //reset item quantities - not actually needed
            daggerQty = 0;
            kukriQty = 0;
            scytheQty = 0;

            //clear calculation variables
            discountRate = 0;
            discountAmount = 0;
            tendered = 0;
            subtotal = 0;
            total = 0;
            taxAmount = 0;

            //reset discount elements
            discountButton.Visible = true;
            discountBox.Visible = false;
            discountIndicator.Visible = false;
            discountIndicator.BackColor = Color.Red;

            //reset receipt
            receiptBox.Size = new Size(196, 22);
            receiptBox.Location = new Point(266, 361);

            //reset history viewer
            this.Size = new Size(500, 500);
            historyButton.Visible = true;
            historyPasswordInput.Visible = false;
        }

    }
}
