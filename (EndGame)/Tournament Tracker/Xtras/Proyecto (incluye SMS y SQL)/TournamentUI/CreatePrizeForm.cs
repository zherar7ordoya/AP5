using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.DataAccess;
using TournamentLibrary.Models;

namespace TournamentUI
{
    public partial class CreatePrizeForm : Form
    {
        private IPrizeRequester callingForm;                        

        public CreatePrizeForm(IPrizeRequester caller)      
        {
            InitializeComponent();
            callingForm = caller;
            WireUpLists();    
        }

        private void WireUpLists()
        {
            List<int> placeNumbers = new List<int>{ 1 };
            placeNumberDropDown.DataSource = placeNumbers;
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)     
            {
                PrizeModel model = new PrizeModel(placeNameValue.Text, (int)placeNumberDropDown.SelectedItem, prizeAmountValue.Text, prizePercentageValue.Text);
                GlobalConfig.Connection.CreatePrize(model);             
                callingForm.PrizeComplete(model);       

                this.Close();                           
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            
            if (placeNumberDropDown.SelectedItem != null)                   
            {                                                               
                int placeNumber = (int)placeNumberDropDown.SelectedItem;    
                                                                            
                if (placeNumber < 1 || placeNumber > 1)
                {
                    output = false;
                }
            }
            else
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)            
            {
                output = false;
            }

            decimal prizeAmount = 0;                                            
            double prizePercentage = 0;

            bool validPrizeAmount = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);           
            bool validPrizePercentage = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (validPrizeAmount == false || validPrizePercentage == false)                             
            {
                output = false;
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            
            return output;
        }
    }
}
