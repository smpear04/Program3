using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3_final_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            //K6805 this program is to calculate costs for a catering company - one initial, one adjusted, one shipment, and then a total price
            int[] entreesList = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };  //entrees

            double[] entreeFee = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };
            double[] shipmentFees = { .06, 0.0717, 0.07, 0.0874 }; // for each city
            double[] serviceFees = { .15, .10, .05, 0 };
            double[] serviceFeeRange = {5, 10, 20, 21};

            double cityShipFee;
            double mealCost;
            double initialCost = 0;
            double adjustedCost;
            double shipmentCost;
            double totalCost;
            int index = 0;
            int count = 0;
            bool feeFound = false;
            

            //first check for valid city in combo box
            if(cityComboBox.SelectedIndex >= 0)
            {
                if(int.TryParse(entreeInput.Text, out int entreeNumber)) //valid entree number
                {
                    if(int.TryParse(servingsInput.Text, out int servingsNumber) && servingsNumber >= 0) //valid number of servings and also making sure it is a valid number
                    {
                        if(entreeNumber >= entreesList[0] && entreeNumber <= entreesList[entreesList.Length - 1])
                        {
                            cityShipFee = shipmentFees[cityComboBox.SelectedIndex]; //assigns the shipment fee to the correct city

                            foreach (int entreeNum in entreesList) //determine initial cost based on number of servings and the base price
                            {
                                if (entreeNumber == entreeNum)
                                {
                                    mealCost = entreeFee[count];
                                    initialCost = mealCost * servingsNumber;
                                    initialCostOutput.Text = initialCost.ToString("C");

                                }
                                count++;
                            }
                            do
                            {
                                if (servingsNumber <= serviceFeeRange[index]) //match the number of servings to the range for the service fees
                                {
                                    adjustedCost = (initialCost * serviceFees[index]) + initialCost;
                                    adjustedCostOutput.Text = adjustedCost.ToString("C");

                                    shipmentCost = adjustedCost * cityShipFee;
                                    shipmentOutput.Text = shipmentCost.ToString("C");

                                    totalCost = adjustedCost + shipmentCost;
                                    totalPrice.Text = totalCost.ToString("C");

                                    feeFound = true;
                                }
                                
                                index++;
                            } while (!feeFound && index < serviceFees.Length);

                            if (!feeFound) 
                            {
                                adjustedCost = initialCost + (initialCost * serviceFees[serviceFees.Length - 1]);
                                adjustedCostOutput.Text = adjustedCost.ToString("C");

                                shipmentCost = adjustedCost * cityShipFee;
                                shipmentOutput.Text = shipmentCost.ToString("C");

                                totalCost = adjustedCost + shipmentCost;
                                totalPrice.Text = totalCost.ToString("C");

                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid servings number");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid entree number");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the combo box");
            }


        }
    }
}
