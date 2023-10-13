using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // disables all the buttons when the form loads.
            btnDrinkOne.Enabled = false;
            btnDrinkTwo.Enabled = false;
            btnDrinkThree.Enabled = false;
            btnDrinkFour.Enabled = false;
            btnDrinkFive.Enabled = false;
            btnDrinkSix.Enabled = false;
            btnChocoOne.Enabled = false;
            btnChocoTwo.Enabled = false;
            btnChocoThree.Enabled = false;
            btnCrispOne.Enabled = false;
            btnCrispTwo.Enabled = false;
            btnCrispThree.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbPriceThree_TextChanged(object sender, EventArgs e)
        {

        }

        private int StringSeach(string text)
        {
            Match match = Regex.Match(text, @"\d+"); // regular expression to find a number within a string.

            if (match.Success)
            {
                int num;

                if (int.TryParse(match.Value, out num))
                {
                    return num;
                }
                
            }
            return 0;

        }

        private void btnDrinkOne_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnOne.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }
                
            }
            
            //check if the current total is 0.
            if (txtBoxTotalCost.Text == "0.00")
            {
                // changes the text in the text box to display the price if first item selected.
                txtBoxTotalCost.Text = tbPriceOne.Text;
                OrderDisplayBox.Items.Add(lblBtnOne.Text + "        " + (counter + 1));

            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceOne.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnOne.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnOne.Text + "        " + (counter + 1));
            }
        }

        private void btnDrinkTwo_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnTwo.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);
                }
            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceTwo.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceTwo.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnTwo.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnTwo.Text + "        " + (counter + 1));
            }

        }

        private void btnDrinkThree_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnThree.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);
                }
            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceThree.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceThree.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnThree.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnThree.Text + "        " + (counter + 1));
            }
        }

        private void btnDrinkFour_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnFour.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceFour.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceFour.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnFour.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnFour.Text + "        " + (counter + 1));
            }
        }

        private void btnDrinkFive_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnFive.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceFive.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceFive.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnFive.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnFive.Text + "        " + (counter + 1));
            }
        }

        private void btnDrinkSix_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnSix.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceSix.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceSix.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnSix.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnSix.Text + "        " + (counter + 1));
            }
        }

        private void btnChocoOne_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnSeven.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceSeven.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceSeven.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnSeven.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnSeven.Text + "        " + (counter + 1));
            }
        }

        private void btnChocoTwo_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnEight.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceEight.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceEight.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnEight.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnEight.Text + "        " + (counter + 1));
            }
        }

        private void btnChocoThree_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnNine.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceNine.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceNine.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnNine.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnNine.Text + "        " + (counter + 1));
            }
        }

        private void btnChrispOne_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnTen.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceTen.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceTen.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnTen.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnTen.Text + "        " + (counter + 1));
            }
        }

        private void btnCrispTwo_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnEleven.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceEleven.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceEleven.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnEleven.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnEleven.Text + "        " + (counter + 1));
            }
        }

        private void btnCrispThree_Click(object sender, EventArgs e)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(lblBtnTwelve.Text))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }

            if (txtBoxTotalCost.Text == "0.00")
            {
                txtBoxTotalCost.Text = tbPriceTwelve.Text;
            }
            else
            {
                // converts the txtBoxTotalCost text box and price taken from textbox assossiated with button one. Sums and displays value.
                double temparyTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceTwelve.Text);
                // converts cost back to string and displays in the total cost box.
                txtBoxTotalCost.Text = temparyTotal.ToString();

                // for loop to loop over each item in the listBox and removing duplicated results.
                for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
                {
                    if (OrderDisplayBox.Items[i].ToString().Contains(lblBtnTwelve.Text))
                    {
                        OrderDisplayBox.Items.RemoveAt(i);
                    }
                }
                // adds the item back to the listbox with the number of items added.
                OrderDisplayBox.Items.Add(lblBtnTwelve.Text + "        " + (counter + 1));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxTotalCost.Text = "0.00";
            OrderDisplayBox.Items.Clear();
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            PowerButton.Text = "On";

            btnDrinkOne.Enabled = true;
            btnDrinkTwo.Enabled = true;
            btnDrinkThree.Enabled = true;
            btnDrinkFour.Enabled = true;
            btnDrinkFive.Enabled = true;
            btnDrinkSix.Enabled = true;
            btnChocoOne.Enabled = true;
            btnChocoTwo.Enabled = true;
            btnChocoThree.Enabled = true;
            btnCrispOne.Enabled = true;
            btnCrispTwo.Enabled = true;
            btnCrispThree.Enabled = true;
        }

        private void OrderDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
