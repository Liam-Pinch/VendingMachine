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
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setImageTags();
            pbCoinSlot.AllowDrop = true;
            pbLedON1.Visible = false; 
            pbLedON2.Visible = false; 
            pbLedON3.Visible = false; 
            pbLedON4.Visible = false; 
            pbLedON5.Visible = false; 
            pbLedON6.Visible = false; 
            pbLedON7.Visible = false; 
            pbLedON8.Visible = false; 
            pbLedON9.Visible = false; 
            pbLedON10.Visible = false;
            pbLedON11.Visible = false; 
            pbLedON12.Visible = false; 



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

        private void productSelect_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            string btnPressed = button.Tag as string;

            switch (btnPressed)
            {
                case "Coca-Cola Original":

                    addItem(btnPressed);
                    return;

                case "Sprite":
                    addItem(btnPressed);
                    return;

                case "Mountain Dew":
                    addItem(btnPressed);
                    return;

                case "Pepsi":
                    addItem(btnPressed);
                    return;

                case "Monster":
                    addItem(btnPressed);
                    return;

                case "Redbull":
                    addItem(btnPressed);
                    return;

                case "Milkyway":
                    addItem(btnPressed);
                    return;

                case "KitKat":
                    addItem(btnPressed);
                    return;

                case "M&M":
                    addItem(btnPressed);
                    return;

                case "Doritos":
                    addItem(btnPressed);
                    return;

                case "Cheetos":
                    addItem(btnPressed);
                    return;

                case "Takis":
                    addItem(btnPressed);
                    return;

            }


        }
        private void addItem(string P)
        {
            // update textbox for last item ordered
            txtBoxLastAction.Text = P;
            switch (P)
            {
                // switch to control logic. Item selected by Button tag send by ref.
                case "Coca-Cola Original":
                    // function to update orderbox
                    OrderBoxUpdate(P);
                    // function to update stock available.
                    stockAvailable(P);
                    double tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceOne.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "Sprite":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceTwo.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "Mountain Dew":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceThree.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "Pepsi":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceFour.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "Monster":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceFive.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "Redbull":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceSix.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "Milkyway":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceSeven.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "KitKat":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceEight.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "M&M":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceNine.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "Doritos":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceTen.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "Cheetos":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceEleven.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;

                case "Takis":
                    OrderBoxUpdate(P);
                    stockAvailable(P);
                    tempTotal = double.Parse(txtBoxTotalCost.Text) + double.Parse(tbPriceTwelve.Text);
                    txtBoxTotalCost.Text = tempTotal.ToString();
                    return;



            }


        }

        private void OrderBoxUpdate(string P)
        {
            // variable to count how many items have been added on this purchase.
            int counter = 0;

            // loop over each item in list box and store in a tempory string.
            foreach (var item in OrderDisplayBox.Items)
            {
                string tempString = item.ToString();

                // counter becomes equal to the number returned from the string.
                if (tempString.Contains(P))
                {
                    counter = 0;
                    counter = StringSeach(tempString);

                }

            }
            // forloop to check if an item exists in OrderDisplay box. Replace with updated No# of orders.
            for (int i = 0; i < OrderDisplayBox.Items.Count; i++)
            {
                if (OrderDisplayBox.Items[i].ToString().Contains(P))
                {
                    OrderDisplayBox.Items.RemoveAt(i);
                }
            }
            // adds the item back to the listbox with the number of items added.
            OrderDisplayBox.Items.Add(P + "        " + (counter + 1));
        }

        private void stockAvailable(string  P)
        {
            // switch to control logic for stock available.
            switch (P)
            {
                
                case "Coca-Cola Original":
                    // check the tag for amount avialable.
                    string tempStockCheck = pbLedOff1.Tag.ToString();
                    int checker = int.Parse(tempStockCheck) - 1;
                    // check if stock is greater than 0.
                    if(checker == 0)
                    {
                        pbLedOff1.Visible = false;
                        pbLedON1.Visible = true;

                        btnDrinkOne.Enabled = false;
                    }
                    // if greater than 0, just decremement value stored in tag.
                    else
                    {
                        pbLedOff1.Tag = checker;
                    }
                    return;

                case "Sprite":
                    tempStockCheck = pbLedOff2.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff2.Visible = false;
                        pbLedON2.Visible = true;

                        btnDrinkTwo.Enabled = false;
                    }

                    else
                    {
                        pbLedOff2.Tag = checker;
                    }
                    return;

                case "Mountain Dew":
                    tempStockCheck = pbLedOff3.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff3.Visible = false;
                        pbLedON3.Visible = true;

                        btnDrinkThree.Enabled = false;
                    }

                    else
                    {
                        pbLedOff3.Tag = checker;
                    }

                    return;

                case "Pepsi":
                    tempStockCheck = pbLedOff4.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff4.Visible = false;
                        pbLedON4.Visible = true;

                        btnDrinkFour.Enabled = false;
                    }

                    else
                    {
                        pbLedOff4.Tag = checker;
                    }
                    return;

                case "Monster":
                    tempStockCheck = pbLedOff5.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff5.Visible = false;
                        pbLedON5.Visible = true;

                        btnDrinkFive.Enabled = false;
                    }

                    else
                    {
                        pbLedOff5.Tag = checker;
                    }
                    return;

                case "Redbull":
                    tempStockCheck = pbLedOff6.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff6.Visible = false;
                        pbLedON6.Visible = true;

                        btnDrinkSix.Enabled = false;
                    }

                    else
                    {
                        pbLedOff6.Tag = checker;
                    }
                    return;

                case "Milkyway":
                    tempStockCheck = pbLedOff7.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff7.Visible = false;
                        pbLedON7.Visible = true;

                        btnChocoOne.Enabled = false;
                    }

                    else
                    {
                        pbLedOff7.Tag = checker;
                    }
                    return;
                    

                case "KitKat":
                    tempStockCheck = pbLedOff8.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff8.Visible = false;
                        pbLedON8.Visible = true;

                        btnChocoTwo.Enabled = false;
                    }

                    else
                    {
                        pbLedOff8.Tag = checker;
                    }
                    return;

                case "M&M":
                    tempStockCheck = pbLedOff9.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff9.Visible = false;
                        pbLedON9.Visible = true;

                        btnChocoThree.Enabled = false;
                    }

                    else
                    {
                        pbLedOff9.Tag = checker;
                    }
                    return;

                case "Doritos":
                    tempStockCheck = pbLedOff10.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff10.Visible = false;
                        pbLedON10.Visible = true;

                        btnCrispOne.Enabled = false;
                    }

                    else
                    {
                        pbLedOff10.Tag = checker;
                    }
                    return;
                    

                case "Cheetos":
                    tempStockCheck = pbLedOff11.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff11.Visible = false;
                        pbLedON11.Visible = true;

                        btnCrispTwo.Enabled = false;
                    }

                    else
                    {
                        pbLedOff11.Tag = checker;
                    }
                    return;

                case "Takis":
                    tempStockCheck = pbLedOff12.Tag.ToString();
                    checker = int.Parse(tempStockCheck) - 1;

                    if (checker == 0)
                    {
                        pbLedOff12.Visible = false;
                        pbLedON12.Visible = true;

                        btnCrispThree.Enabled = false;
                    }

                    else
                    {
                        pbLedOff12.Tag = checker;
                    }
                    return;
            }
        } 

        private void btnClear_Click(object sender, EventArgs e)
        {
            // call the reset form function. Disabling the money buttons.
            resetForm();

        }

        private void OrderDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setImageTags()
        {
            // function to set item quantities to a random number between 1-10.
            Random random = new Random();

            // use 1, 11 because random is only inclusive of the lower limit not upper.
            pbLedOff1.Tag = random.Next(1, 11);
            pbLedOff2.Tag = random.Next(1, 11);
            pbLedOff3.Tag = random.Next(1, 11);
            pbLedOff4.Tag = random.Next(1, 11);
            pbLedOff5.Tag = random.Next(1, 11);
            pbLedOff6.Tag = random.Next(1, 11);
            pbLedOff7.Tag = random.Next(1, 11);
            pbLedOff8.Tag = random.Next(1, 11);
            pbLedOff9.Tag = random.Next(1, 11);
            pbLedOff10.Tag = random.Next(1, 11);
            pbLedOff11.Tag = random.Next(1, 11);
            pbLedOff12.Tag = random.Next(1, 11);


        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            // function to enable payment. Button only enabled when there are items to pay for.
            if (double.Parse(txtBoxTotalCost.Text) != 0)
            {
                groupBox1.Visible = true;
                pbCoinSlot.Visible = true;

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

            

        }

        private void pbFivePence_MouseDown(object sender, MouseEventArgs e)
        {
            // function to begin drag drop & capture tag data to be used as input when dropped
            pbFivePence.DoDragDrop(pbFivePence.Tag, DragDropEffects.Copy);
        }

        private void pbTenPence_MouseDown(object sender, MouseEventArgs e)
        {
            // function to begin drag drop & capture tag data to be used as input when dropped
            pbFivePence.DoDragDrop(pbTenPence.Tag, DragDropEffects.Copy);
        }

        private void pbTwentyPence_MouseDown(object sender, MouseEventArgs e)
        {
            // function to begin drag drop & capture tag data to be used as input when dropped
            pbFivePence.DoDragDrop(pbTwentyPence.Tag, DragDropEffects.Copy);
        }

        private void pbFiftyPence_MouseDown(object sender, MouseEventArgs e)
        {
            // function to begin drag drop & capture tag data to be used as input when dropped
            pbFivePence.DoDragDrop(pbFiftyPence.Tag, DragDropEffects.Copy);
        }

        private void pbOnePound_MouseDown(object sender, MouseEventArgs e)
        {
            // function to begin drag drop & capture tag data to be used as input when dropped
            pbFivePence.DoDragDrop(pbOnePound.Tag, DragDropEffects.Copy);
        }

        private void pbTwoPound_MouseDown(object sender, MouseEventArgs e)
        {
            // function to begin drag drop & capture tag data to be used as input when dropped.
            pbFivePence.DoDragDrop(pbTwoPound.Tag, DragDropEffects.Copy);
        }

        private void pbFivePound_MouseDown(object sender, MouseEventArgs e)
        {
            // // function to begin drag drop & capture tag data to be used as input when dropped
            pbFivePence.DoDragDrop(pbFivePound.Tag, DragDropEffects.Copy);
        }

        private void pbCoinSlot_DragEnter(object sender, DragEventArgs e)
        {

                e.Effect = DragDropEffects.Copy;
            
        }

        private void resetForm()
        {
            // reset the text boxes
            txtBoxTotalCost.Text = "0.00";
            OrderDisplayBox.Items.Clear();
            txtBoxLastAction.Text = "";

            // enable all buttons.
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

            // disable all the buttons in group 1 or "Money secontion"
            groupBox1.Visible = false;
            pbCoinSlot.Visible = false;

            // reset stock quanitity tags.
            setImageTags();

            //  reset leds.
            pbLedON1.Visible = false; pbLedOff1.Visible = true;
            pbLedON2.Visible = false; pbLedOff2.Visible = true;
            pbLedON3.Visible = false; pbLedOff3.Visible = true;
            pbLedON4.Visible = false; pbLedOff4.Visible = true;
            pbLedON5.Visible = false; pbLedOff5.Visible = true;
            pbLedON6.Visible = false; pbLedOff6.Visible = true;
            pbLedON7.Visible = false; pbLedOff7.Visible = true;
            pbLedON8.Visible = false; pbLedOff8.Visible = true;
            pbLedON9.Visible = false; pbLedOff9.Visible = true;
            pbLedON10.Visible = false; pbLedOff10.Visible = true;
            pbLedON11.Visible = false; pbLedOff11.Visible = true;
            pbLedON12.Visible = false; pbLedOff12.Visible = true;

        }

        private void changeCheck()
            // function to be called to check if change is owed after each coin is used.
        {
            // checks if the textbox is less than 0.
            if (double.Parse(txtBoxTotalCost.Text) < 0)
            {
                
                double change = 0 - double.Parse(txtBoxTotalCost.Text);
                // creates a message box to display the change owed.
                MessageBox.Show("Thank you. Your Change is: £" + string.Format("{0:0.00}", change));
                // write the order to file.
                writeToFile();
                // reset form once the messagebox is dismissed.
                resetForm();
                
            }
            else
                if
                (double.Parse(txtBoxTotalCost.Text) == 0)
            {
                // displays a message box to confirm successful payment with no change to be given.
                MessageBox.Show("Payment Complete. Thank You");
                // write to file.
                writeToFile();
                // reset the form once the messagebox is dismissed.
                resetForm();
            }
        }

        private void pbCoinSlot_DragDrop(object sender, DragEventArgs e)
        {
            
            
            string tag = e.Data.GetData(typeof(string)) as string;
            
            switch (tag)
            {
                case "0.05":

                    double tempStore = double.Parse(txtBoxTotalCost.Text) - 0.05;
                    txtBoxTotalCost.Text = tempStore.ToString();
                    changeCheck();
                    return;

                case "0.10":
                    tempStore = double.Parse(txtBoxTotalCost.Text) - 0.10;
                    txtBoxTotalCost.Text = tempStore.ToString();
                    changeCheck();
                    return;

                case "0.20":
                    tempStore = double.Parse(txtBoxTotalCost.Text) - 0.2;
                    txtBoxTotalCost.Text = tempStore.ToString();
                    changeCheck();
                    return;

                case "0.50":
                    tempStore = double.Parse(txtBoxTotalCost.Text) - 0.5;
                    txtBoxTotalCost.Text = tempStore.ToString();
                    changeCheck();
                    return;

                case "1":
                    tempStore = double.Parse(txtBoxTotalCost.Text) - 1;
                    txtBoxTotalCost.Text = tempStore.ToString();
                    changeCheck();
                    return;

                case "2":
                    tempStore = double.Parse(txtBoxTotalCost.Text) - 2;
                    txtBoxTotalCost.Text = tempStore.ToString();
                    changeCheck();
                    return;

                case "5":
                    tempStore = double.Parse(txtBoxTotalCost.Text) - 5;
                    txtBoxTotalCost.Text = tempStore.ToString();
                    changeCheck();
                    return;
            }


           

        }


        private void writeToFile()
        {
            // variable to store file path of the textfile.
            string filePath = @"C:\Users\liamp\OneDrive - University of South Wales\repos\vendingmachine.txt";

            try
            {
                // write the list to the file.
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    foreach (var item in OrderDisplayBox.Items)
                    {
                        writer.WriteLine(item);
                    }
                    writer.Write("\n");
                    
                    
                }
                
            }
            // catch statement to handle exceptions.
            catch (IOException e)
            {
                MessageBox.Show("Unable to Write to file" + e);
            }
        }     

       

    }

    
}
