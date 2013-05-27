using System;
using Microsoft.Win32;  //This allows access the Registry.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PizzaGuys
{
    public partial class FormPizzaOrder : Form
    {
        public FormPizzaOrder()
        {
            InitializeComponent();
        }

        /* Written by: Michael J. Rieben
         * Date: Fall 2006 Semester at MJC
         * Instructor: Chris Vaughn
         * Class: MCMPSC-204-0747 , Intro to Programming
         *
         * Thanks to Rick Cable (Classmate) for some formating assistance.
         */

        #region Public Variables - These are default values
        //Declare Variable dblSizePrice for Large Pizza Price Default
        double dblSizePrice = 20.00;
        //Declare Variable dblToppPrice NONE Picked Default
        double dblToppPrice = 0.00;
        //Declare Variable dblXCheesePrice Yes Default and set price
        double dblXCheesePrice = 0.50;//If this changes You must change the module RadBtnCheYes_CheckedChanged as well.
        //Declare intQuanValue as a public variable
        int intQuanValue;
        //Declare dblCouponRate as a public variable
        double dblCouponRate = 0.00;
        //Declare dblSubTotValue as a public variable
        double dblSubTotValue;
        //Declare Individual Pizza Cost as a public variable
        double dblIndivPizzaValue;
        //This is used in print pizza cost to form
        string strSubTotal;
        //This is used for continuous SubTotal calcs
        string strContSubTotal;
        //Decalre order number
        int intOrderNo;
        //Set CA Tax Rate as default. See module for each Store Location Tax Rate
        double dblTaxRate = 0.07375; //7.375%               
        //This is the cost for topppings excluding extra cheese
        double dblIndividualToppPrice = 0.75;
        //Price for Large Pizza
        double dblLargePizzaValue = 20.00;
        //Price for Medium Pizza
        double dblMediumPizzaValue = 15.00;
        //Price for Small Pizza
        double dblSmallPizzaValue = 10.00;
        //Price for Personal Pizza
        double dblPersPizzaValue = 7.00;


        //This sets a bool value to test to add Order # and Date/Time to the top of pizza order
        bool boolAddPizza = false;
        #endregion

        public void FormPizzaOrder_Activated(object sender, EventArgs e)
        {   //When form is launched do this...

            //Set First Name Text Box as default cursor location
            TxtBoxFirstName.Focus();

            //Set Order No Value to 1
            intOrderNo = 1;
            LblOrderNo.Text = intOrderNo.ToString();

            #region Order Number to Registry ***NEEDS WORK***
            //const string userRoot = "HKEY_CURRENT_USER";
            //const string subKey = "Riebens Pizza Guys";
            //const string keyName = userRoot + "\\" + subKey;
            //string KeyValue = Registry.CurrentUser.GetValue(keyName).ToString();
            //MessageBox.Show(KeyValue);

            //This method only works if 1 user uses this form
            //If the CurrentUser is changed to
            //if (GETVALE == null)
            //{
            //    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Riebens Pizza Guys");
            //    key.SetValue("OrderNo", "1");
            //    key.Close();
            //}
            //else
            //{
            //    intOrderNo = "Get Reg Key Value"
            //    intOrderNo = intOrderNo + 1;
            //}
            #endregion

            //Set City based on CA as default
            TxtBoxCity.Text = "Modesto";

            //Set State CA default
            ComBoxState.Text = "CA";

            //Set Zip based on CA as default
            TxtBoxZip.Text = "95354";

            //Set Date based on system date to Form
            LblDate.Text = DateTime.Now.ToString();

            //Set Quantity Combo Box value to 1
            ComBoxQuan.Text = "1";

            //disable CC# and CVC# text fields.  Cash is default.
            TxtBoxCC.Enabled = false;
            LblCCNo.Enabled = false;
            TxtBoxCVC.Enabled = false;
            LblCVCNo.Enabled = false;
            ComDatePicker.Enabled = false;
            LblExpirDate.Enabled = false;

            //Set the coupon label to null
            LblCouponValid.Text = "";

            //Set SubTot, Tax, Total labels to $0.00
            LblSubTot.Text = "$0.00";
            LblTax.Text = "$0.00";
            LblTotalPrice.Text = "$0.00";
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {   //Do this when "Place Order" button is pressed...

            //Reset Form Size back to Original Size.
            //See Post Customer and Add Pizza Buttons for form size changes.
            FormPizzaOrder.ActiveForm.Size = new Size(415, 675);
            //Center form after resize
            CenterToScreen();
            MessageBox.Show("Order Placed", "Order UP", MessageBoxButtons.OK);//Temp Dialog

            //Get values of Expiration Date
            //These would be used to place in database and to process the Credit Card.
            string ExpYear = ComDatePicker.Value.Year.ToString();
            string ExpMonth = ComDatePicker.Value.Month.ToString();
            string ExpDay = ComDatePicker.Value.Day.ToString(); //ExpDay may not be used.

            //At this point the reciept would print and to a medium for the Cheff.  ***No code included***
            ClearCustomer(); //Clear Customer information from form.
            ClearPizza(); //Clear Pizza information from form.
            TxtBoxFirstName.Focus(); //Move cursor focus to First Name.
            LblDate.Text = DateTime.Now.ToString(); //Update Date/Time for new customer.

            //More Registry Attempts - Disregard
            //key.SetValue("OrderNo", "1");
            //key.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {   //Do this when Cancel is pressed...
            Application.Exit(); //Close Program
        }

        private void BtnClearForm_Click(object sender, EventArgs e)
        {   //Do this when the 'Clear Pizzas" button is pressed
            CenterToScreen(); //Center form to screen
            ClearPizza(); //Go to "ClearPizza" module
        }

        private void TxtBoxMI_TextChanged(object sender, EventArgs e)
        {   //Test for one character in text box then move cursor to last name.
            //Allows for quick input.
            if (TxtBoxMI.Text.Length == 1) TxtBoxLastName.Focus();
        }

        private void TxtBoxMI_KeyPress(object sender, KeyPressEventArgs e)
        {   //Don't allow more than 1 character.
            //Allow Backspace Key. ASCII Dec: 8
            if (TxtBoxMI.Text.Length > 0 && e.KeyChar != 8) e.Handled = true;
        }

        private void ComBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {   //When the State drop down box is used test for which one is selected
            //This assumes that the Pizza Delivery will not be out of the City, State, and Zip from the Store.
            Object selectedItem = ComBoxState.SelectedItem;
            string TaxRateArea = selectedItem.ToString();
            if (TaxRateArea == "CA")
            {   //Modesto, California 7.375%
                dblTaxRate = 0.07375;
                TxtBoxCity.Text = "Modesto";
                TxtBoxZip.Text = "95354";
            }
            else if (TaxRateArea == "NV")
            {   //Reno, Nevada 7.375%
                dblTaxRate = 0.07375;
                TxtBoxCity.Text = "Reno";
                TxtBoxZip.Text = "89595";
            }
            else if (TaxRateArea == "AZ")
            {   //Phoenix, Arizona 8.1%
                dblTaxRate = 0.081;
                TxtBoxCity.Text = "Phoenix";
                TxtBoxZip.Text = "85051";
            }
            else if (TaxRateArea == "OR")
            {   //Portland, Oregon 0.0%
                dblTaxRate = 0.0;
                TxtBoxCity.Text = "Portland";
                TxtBoxZip.Text = "97201";
            }
            CalculateTaxAndTotal(); //Go to "CalculateTaxAndTotal" module.
        }

        private void ComBoxState_KeyPress(object sender, KeyPressEventArgs e)
        {   //Limit users ability to use the keyboard.  Use drop down box.
            //Don't allow more than 2 characters to be entered.
            //Don't allow Backspace Key. ASCII Dec: 8
            //ASCII 127 states it's for the Delete Key but it doesn't work.
            if (ComBoxState.Text.Length > 1 || e.KeyChar == 8 || e.KeyChar == 127) e.Handled = true;
        }

        private void ComBoxState_KeyUp(object sender, KeyEventArgs e)
        {   //Limit users ability to use the keyboard.  Use drop down box.
            //Don't allow a blank text box.
            if (ComBoxState.Text == "")
            {
                MessageBox.Show("Use drop down", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ComBoxState.Text = "CA";
            }

        }

        private void TxtBoxAreaCode_TextChanged(object sender, EventArgs e)
        {   //When the "Area Code" field reaches 3 characters then move cursor to next field.
            if (TxtBoxAreaCode.Text.Length == 3) TxtBoxPh3Dig.Focus();
        }

        private void TxtBoxAreaCode_KeyPress(object sender, KeyPressEventArgs e)
        {   //Test for numeric values and allow Backspace (ASCII Dec 8)
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8) e.Handled = true;
            //Don't allow for more than 3 numbers.
            if (TxtBoxAreaCode.Text.Length > 2 && e.KeyChar != 8) e.Handled = true;
        }

        private void TxtBoxPh3Dig_TextChanged(object sender, EventArgs e)
        {   //When the "Phone 3 Digit" field reaches 3 characters then move cursor to next field.
            if (TxtBoxPh3Dig.Text.Length == 3) TxtBoxPh4Dig.Focus();
        }

        private void TxtBoxPh3Dig_KeyPress(object sender, KeyPressEventArgs e)
        {   //Test for numeric values and allow Backspace (ASCII Dec 8)
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8) e.Handled = true;
            //Don't allow for more than 3 numbers.
            if (TxtBoxPh3Dig.Text.Length > 2 && e.KeyChar != 8) e.Handled = true;
        }

        private void TxtBoxPh4Dig_TextChanged(object sender, EventArgs e)
        {   //When the "Phone 4 Digit" field reaches 4 characters then move cursor to "Post Customer" button.
            if (TxtBoxPh4Dig.Text.Length == 4) BtnPostCust.Focus();
        }

        private void TxtBoxPh4Dig_KeyPress(object sender, KeyPressEventArgs e)
        {   //Test for numeric values and allow Backspace (ASCII Dec 8)
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8) e.Handled = true;
            //Don't allow for more than 4 numbers.
            if (TxtBoxPh4Dig.Text.Length > 3 && e.KeyChar != 8) e.Handled = true;
        }

        private void BtnLookUp_Click(object sender, EventArgs e)
        {   //This would look up the customer in a database based on their phone number.
            //Not included in this release.
            MessageBox.Show("Not included with this release. \n\nThis would look up the Customer \ninformation using their Phone Number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPostCust_Click(object sender, EventArgs e)
        {   //This prints all customer information to the form
            //It would also be ideal to post to a database. Not Included.

            #region Fill the Customer Information for testing purposes
            //TxtBoxFirstName.Text = "Michael";
            //TxtBoxMI.Text = "J";
            //TxtBoxLastName.Text = "Rieben";
            //TxtBoxStrAdd.Text = "5555 Modesto LN";
            //TxtBoxAptNo.Text = "133";
            //TxtBoxAreaCode.Text = "555";
            //TxtBoxPh3Dig.Text = "555";
            //TxtBoxPh4Dig.Text = "5555";
            #endregion

            #region Test for Blank Fields
            if (TxtBoxFirstName.Text == "")
            {
                MessageBox.Show("First Name is Blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtBoxFirstName.Focus();
            }
            else if (TxtBoxLastName.Text == "")
            {
                MessageBox.Show("Last Name is Blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtBoxLastName.Focus();
            }
            else if (TxtBoxStrAdd.Text == "")
            {
                MessageBox.Show("Address is Blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtBoxStrAdd.Focus();
            }
            else if (TxtBoxCity.Text == "")
            {
                MessageBox.Show("City is Blank! \nUse State Drop Down Box", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ComBoxState.Focus();
            }
            else if (TxtBoxZip.Text == "")
            {
                MessageBox.Show("Zip Code is Blank! \nUse State Drop Down Box", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ComBoxState.Focus();
            }
            else if (TxtBoxAreaCode.Text == "")
            {
                MessageBox.Show("Area Code is Blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtBoxAreaCode.Focus();
            }
            else if (TxtBoxPh3Dig.Text == "")
            {
                MessageBox.Show("Phone Number is Blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtBoxPh3Dig.Focus();
            }
            else if (TxtBoxPh4Dig.Text == "")
            {
                MessageBox.Show("Phone Number is Blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtBoxPh4Dig.Focus();
            }
            #endregion

            else
            {   //Resize Form to show order on Right Side.
                FormPizzaOrder.ActiveForm.Size = new Size(675, 675);
                CenterToScreen(); //Center Form to screen.

                //Test if Apartment Number entered. If so then print Apt. # to form.
                string strPrintApt;
                if (TxtBoxAptNo.Text == "")
                    strPrintApt = " ";
                else
                    strPrintApt = " , Apt. #: ";

                //Print Customer to Form.
                //This CONCATENATE all customer information to 1 multiline text box.
                //Use Environment.Newline to print to next line.
                TxtBoxCustInfo.Text = (TxtBoxFirstName.Text + " " + TxtBoxMI.Text + " " + TxtBoxLastName.Text);
                TxtBoxCustInfo.Text = TxtBoxCustInfo.Text + Environment.NewLine + TxtBoxStrAdd.Text + strPrintApt + TxtBoxAptNo.Text;
                TxtBoxCustInfo.Text = TxtBoxCustInfo.Text + Environment.NewLine + TxtBoxCity.Text + ", " + ComBoxState.Text + "  " + TxtBoxZip.Text;
                TxtBoxCustInfo.Text = TxtBoxCustInfo.Text + Environment.NewLine + "(" + TxtBoxAreaCode.Text + ") " + TxtBoxPh3Dig.Text + "-" + TxtBoxPh4Dig.Text;

                BtnPostCust.Focus(); //Keep cursor on this Button.
            }
        }

        private void RadBtnLrg_CheckedChanged(object sender, EventArgs e)
        {   //If Radio Button was clicked then go to "PizzaSizeCalc" module.
            PizzaSizeCalc();
        }

        private void RadBtnMed_CheckedChanged(object sender, EventArgs e)
        {   //If Radio Button was clicked then go to "PizzaSizeCalc" module.
            PizzaSizeCalc();
        }

        private void RadBtnSml_CheckedChanged(object sender, EventArgs e)
        {   //If Radio Button was clicked then go to "PizzaSizeCalc" module.
            PizzaSizeCalc();
        }

        private void RadBtnPerSize_CheckedChanged(object sender, EventArgs e)
        {   //If Radio Button was clicked then go to "PizzaSizeCalc" module.
            PizzaSizeCalc();
        }

        private void PizzaSizeCalc()
        {   //Calculate $$ when Radio Buttons for Sizes are clicked
            if (RadBtnLrg.Checked == true)
            {
                dblSizePrice = 0.00;
                dblSizePrice = dblSizePrice + dblLargePizzaValue;
            }
            else if (RadBtnMed.Checked == true)
            {
                dblSizePrice = 0.00;
                dblSizePrice = dblSizePrice + dblMediumPizzaValue;
            }
            else if (RadBtnSml.Checked == true)
            {
                dblSizePrice = 0.00;
                dblSizePrice = dblSizePrice + dblSmallPizzaValue;
            }
            else if (RadBtnPerSize.Checked == true)
            {
                dblSizePrice = 0.00;
                dblSizePrice = dblSizePrice + dblPersPizzaValue;
            }
        }

        private void ChkBoxSaus_CheckedChanged(object sender, EventArgs e)
        {   //Test if Toppings are checked.
            if (ChkBoxSaus.Checked) dblToppPrice = dblToppPrice + dblIndividualToppPrice;
            else dblToppPrice = dblToppPrice - dblIndividualToppPrice;
        }

        private void ChkBoxPepp_CheckedChanged(object sender, EventArgs e)
        {   //Test if Toppings are checked.
            if (ChkBoxPepp.Checked) dblToppPrice = dblToppPrice + dblIndividualToppPrice;
            else dblToppPrice = dblToppPrice - dblIndividualToppPrice;
        }

        private void ChkBoxOliv_CheckedChanged(object sender, EventArgs e)
        {   //Test if Toppings are checked.
            if (ChkBoxOliv.Checked) dblToppPrice = dblToppPrice + dblIndividualToppPrice;
            else dblToppPrice = dblToppPrice - dblIndividualToppPrice;
        }

        private void ChkBoxAnch_CheckedChanged(object sender, EventArgs e)
        {   //Test if Toppings are checked.
            if (ChkBoxAnch.Checked) dblToppPrice = dblToppPrice + dblIndividualToppPrice;
            else dblToppPrice = dblToppPrice - dblIndividualToppPrice;
        }

        private void ChkBoxOnio_CheckedChanged(object sender, EventArgs e)
        {   //Test if Toppings are checked.
            if (ChkBoxOnio.Checked) dblToppPrice = dblToppPrice + dblIndividualToppPrice;
            else dblToppPrice = dblToppPrice - dblIndividualToppPrice;
        }

        private void RadBtnCheYes_CheckedChanged(object sender, EventArgs e)
        {   //Test if Extra Cheese radio button is Yes.
            if (RadBtnCheYes.Checked)
            {
                if (dblXCheesePrice == 0.00) dblXCheesePrice = 0.50;
            }
            else dblXCheesePrice = 0.00;
        }

        private void ComBoxQuan_SelectedIndexChanged(object sender, EventArgs e)
        {   //Get and Store value from Pizza Quantity combo box if it changes.
            intQuanValue = Convert.ToInt16(ComBoxQuan.SelectedItem);
        }

        private void ComBoxQuan_KeyUp(object sender, KeyEventArgs e)
        {   //Limit user keyboard input.
            //Test if field is blank.  If so reset to 1 and prompt user to use drop down.
            if (ComBoxQuan.Text == "")
            {
                MessageBox.Show("Use drop down", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ComBoxQuan.Text = "1";
            }
        }

        private void ComBoxQuan_KeyPress(object sender, KeyPressEventArgs e)
        {   //This doesn't even allow # 1 to be pressed.  WHY?????
            //The idea is not allow the user to use the keyboard.  Use drop down box ONLY!
            if (e.KeyChar != 1) e.Handled = true;
        }

        private void BtnAddPizza_Click(object sender, EventArgs e)
        {   //Do this when "Add Pizza" button is pressed...
            FormPizzaOrder.ActiveForm.Size = new Size(675, 675); //Resize form to show order information.
            CenterToScreen(); //Center form to sceen.
            CalculateEachPizzaPrice(); //Go to "CalculateEachPizzaPrice" module.
            AddPizzaToReceipt(); //Go to "AddPizzaToReceipt" module.
            CalcualtePrice(); //Go to "CalcualtePrice" module.
        }

        private void AddPizzaToReceipt()
        {   //This module prints each Pizza to Order.
            if (boolAddPizza == false)
            {
                //Print Order Number.
                TxtBoxPizzaOrder.Text = "Order #: " + LblOrderNo.Text;
                //Print Date to Order.
                TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + "Date: " + DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToShortDateString();
                //Print Time to Order.
                TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + "  Time: " + DateTime.Now.ToShortTimeString();
                //Add a blank line to give room between Date/Time and 1st Pizza Ordered.
                TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + " ";
                boolAddPizza = true; //This is used to determine if this if Order information has been printed.
            }
            //Print Quantity and Cost for Pizza.
            TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + ComBoxQuan.Text + " - ";
            //Test and Print Pizza Size
            if (RadBtnLrg.Checked == true) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + "Large Size";
            else if (RadBtnMed.Checked == true) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + "Medium Size";
            else if (RadBtnSml.Checked == true) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + "Small Size";
            else if (RadBtnPerSize.Checked == true) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + "Personal Size";
            TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + " - " + strSubTotal;
            //Test and Print Toppings
            if (ChkBoxSaus.Checked) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + "Sausage";
            if (ChkBoxPepp.Checked) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + "Pepperoni";
            if (ChkBoxOliv.Checked) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + "Olives";
            if (ChkBoxAnch.Checked) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + "Anchovies";
            if (ChkBoxOnio.Checked) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + "Onions";
            if (RadBtnCheYes.Checked) TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + "Extra Cheese";
            //Add a blank line to give room between multiple Pizzas Ordered.
            TxtBoxPizzaOrder.Text = TxtBoxPizzaOrder.Text + Environment.NewLine + " ";
        }

        private void RadBtnVisa_CheckedChanged(object sender, EventArgs e)
        {   //Do this if Visa radio button is clicked...
            if (RadBtnVisa.Checked == true)
            {
                TxtBoxCC.Enabled = true; //Enable the Credit Card Number Field.
                LblCCNo.Enabled = true; //Enable the Credit Card Label.
                TxtBoxCVC.Enabled = true; //Enable the Credit Card CVC# Field.
                LblCVCNo.Enabled = true; //Enable the Credit Card CVC# Label.
                ComDatePicker.Enabled = true; //Enable the Date Picker Object.
                LblExpirDate.Enabled = true; //Enable the Date Picker Label.
                //Prompt user to do the Store's policies.
                MessageBox.Show("Request to see ID and Visa Card", "Visa Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RadBtnMstr_CheckedChanged(object sender, EventArgs e)
        {   //Do this if MasterCard radio button is clicked...
            if (RadBtnMstr.Checked == true)
            {
                TxtBoxCC.Enabled = true; //Enable the Credit Card Number Field.
                LblCCNo.Enabled = true; //Enable the Credit Card Label.
                TxtBoxCVC.Enabled = true; //Enable the Credit Card CVC# Field.
                LblCVCNo.Enabled = true; //Enable the Credit Card CVC# Label.
                ComDatePicker.Enabled = true; //Enable the Date Picker Object.
                LblExpirDate.Enabled = true; //Enable the Date Picker Label.
                //Prompt user to do the Store's policies.
                MessageBox.Show("Request to see ID and MasterCard", "MasterCard Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RadBtnATM_CheckedChanged(object sender, EventArgs e)
        {   //Do this if Debit radio button is clicked...
            if (RadBtnATM.Checked == true)
            {
                TxtBoxCC.Enabled = false; //Disable the Credit Card Number Field.
                LblCCNo.Enabled = false; //Disable the Credit Card Label.
                TxtBoxCVC.Enabled = false; //Disable the Credit Card CVC# Field.
                LblCVCNo.Enabled = false; //Disable the Credit Card CVC# Label.
                ComDatePicker.Enabled = false; //Disable the Date Picker Object.
                LblExpirDate.Enabled = false; //Disable the Date Picker Label.
                //Prompt user to do the Store's policies.
                MessageBox.Show("Customer may swipe card now", "Debit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RadBtnCheck_CheckedChanged(object sender, EventArgs e)
        {   //Do this if Check radio button is clicked...
            if (RadBtnCheck.Checked == true)
            {
                TxtBoxCC.Enabled = false; //Disable the Credit Card Number Field.
                LblCCNo.Enabled = false; //Disable the Credit Card Label.
                TxtBoxCVC.Enabled = false; //Disable the Credit Card CVC# Field.
                LblCVCNo.Enabled = false; //Disable the Credit Card CVC# Label.
                ComDatePicker.Enabled = false; //Disable the Date Picker Object.
                LblExpirDate.Enabled = false; //Disable the Date Picker Label.
                //Prompt user to do the Store's policies.
                MessageBox.Show(" - Please request ID \n - Verify Address on Check \n - Write Lic# on Check \n - Write Phone # on Check", "Check Information          ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RadBtnCash_CheckedChanged(object sender, EventArgs e)
        {   //Do this if Cash radio button is clicked...  Cash is default.
            if (RadBtnCash.Checked == true)
            {
                TxtBoxCC.Enabled = false; //Disable the Credit Card Number Field.
                LblCCNo.Enabled = false; //Disable the Credit Card Label.
                TxtBoxCVC.Enabled = false; //Disable the Credit Card CVC# Field.
                LblCVCNo.Enabled = false; //Disable the Credit Card CVC# Label.
                ComDatePicker.Enabled = false; //Disable the Date Picker Object.
                LblExpirDate.Enabled = false; //Disable the Date Picker Label.
            }
        }

        private void TxtBoxCC_TextChanged(object sender, EventArgs e)
        {   //When the "Credit Card #" field reaches 16 characters then move cursor to next field.
            if (TxtBoxCC.Text.Length == 16) TxtBoxCVC.Focus();
        }

        private void TxtBoxCC_KeyPress(object sender, KeyPressEventArgs e)
        {   //Test for numeric values and allow backspace.
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8) e.Handled = true;
            //Don't allow more than 16 characters.
            if (TxtBoxCC.Text.Length > 15 && e.KeyChar != 8) e.Handled = true;
        }

        private void TxtBoxCVC_TextChanged(object sender, EventArgs e)
        {   //When the "CVC #" field reaches 3 characters then move cursor to next field.
            if (TxtBoxCVC.Text.Length == 3) TxtBoxCouponID.Focus();
        }

        private void TxtBoxCVC_KeyPress(object sender, KeyPressEventArgs e)
        {   //Test for numeric values and allow backspace.
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8) e.Handled = true;
            //Don't allow more than 3 characters.
            if (TxtBoxCVC.Text.Length > 2 && e.KeyChar != 8) e.Handled = true;
        }

        private void ComDatePicker_ValueChanged(object sender, EventArgs e)
        {   //Change cursor position after user uses object.
            TxtBoxCouponID.Focus();
        }

        private void TextBoxCouponID_TextChanged(object sender, EventArgs e)
        {
            /* This works only if the last thing done to the form is input coupon.
             * Additional pizzas won't get calculated.
             * If the coupon is removed it will not return to full price.
             * 1st thought is to reformat the calculation modules.
             */
            string CouponIDValue = TxtBoxCouponID.Text;
            if (CouponIDValue == "10PERCPG") //If user inputs "10PERCPG" into the text box then...
            {
                dblCouponRate = 0.10; //Set 10% Off.
                LblSubTot.ForeColor = Color.Green; //Change lable to green.
                LblCouponID.ForeColor = Color.Green; //Change lable to green.
                LblSubTotTitle.ForeColor = Color.Green; //Change lable to green.
                TxtBoxCouponID.ForeColor = Color.Green; //Change lable to green.
                BtnOrder.Focus(); //Change cursor position to "Place Order" button.
                CalculateCoupon(); //Go to "CalculateCoupon" module.
                LblCouponValid.Text = "10% Coupon"; //Update label value. Below the Total on Order.
                MessageBox.Show("10% Coupon Entered", "Coupon"); //Tell user what was entered.
            }
            else if (CouponIDValue == "20PERCPG") //If user inputs "20PERCPG" into the text box then...
            {
                dblCouponRate = 0.20; //Set 10% Off.
                LblSubTot.ForeColor = Color.Green; //Change lable to green.
                LblCouponID.ForeColor = Color.Green; //Change lable to green.
                LblSubTotTitle.ForeColor = Color.Green; //Change lable to green.
                TxtBoxCouponID.ForeColor = Color.Green; //Change lable to green.
                BtnOrder.Focus(); //Change cursor position to "Place Order" button.
                CalculateCoupon(); //Go to "CalculateCoupon" module.
                LblCouponValid.Text = "20% Coupon"; //Update label value. Below the Total on Order.
                MessageBox.Show("20% Coupon Entered", "Coupon"); //Tell user what was entered.
            }
            else if (CouponIDValue == "") //Test if user deleted text box contents.
            {   //I thought this would work if the user removed the coupon.  ***NEEDS WORK***
                dblCouponRate = 0.00; //Set to 0%
                CalculateCoupon(); //Go to "CalculateCoupon" module.
            }
        }

        private void CalculateEachPizzaPrice()
        {   //This will calc each pizza to print to form.
            dblIndivPizzaValue = dblSizePrice + dblToppPrice + dblXCheesePrice;
            dblIndivPizzaValue = dblIndivPizzaValue * intQuanValue;

            //Format Pizza Cost as a Dollar value.
            strSubTotal = dblIndivPizzaValue.ToString();
            strSubTotal = String.Format("{0:c}", double.Parse(strSubTotal));
        }

        private void CalcualtePrice()
        {   //This Calculates the continuous Sub-Total.

            //Test to see if a Pizza has been added to the order
            if (LblSubTot.Text == "$0.00") dblSubTotValue = dblIndivPizzaValue;
            //If there's an existing $$ then add to it after additional pizzas are added.
            else dblSubTotValue = dblSubTotValue + dblIndivPizzaValue;

            CalculateTaxAndTotal(); //Go to "CalculateTaxAndTotal" module.
        }

        private void CalculateCoupon()
        {   //This Calculates a "% off" if a Coupon is entered.
            double CalcSubTot = 0.00;
            if (dblCouponRate == 0.00)
            {
                //CalcSubTot = 0.00; //This may not actually be needed. ***Coupon Entry NEEDS WORK***
                dblSubTotValue = dblSubTotValue + CalcSubTot;
            }
            else //If a coupon is valid then calculate new Sub-Total.
            {
                CalcSubTot = dblSubTotValue - (dblCouponRate * dblSubTotValue);
                dblSubTotValue = CalcSubTot;
            }
            CalculateTaxAndTotal(); //Go to "CalculateTaxAndTotal" module.
        }

        private void CalculateTaxAndTotal()
        {
            //Format Sub-Total as a Dollar value.
            strContSubTotal = dblSubTotValue.ToString();
            strContSubTotal = String.Format("{0:c}", double.Parse(strContSubTotal));

            //Set Sub-Total LABEL.
            LblSubTot.Text = strContSubTotal;

            //Calculate Tax based on the City's rate set in "ComBoxState_SelectedIndexChanged" module.
            double CalcTaxTot = dblSubTotValue * dblTaxRate;
            CalcTaxTot = (Math.Round(CalcTaxTot, 2)); //This works if the value consists beyond the hundredth place.

            //Calculate GrandTotal
            double GrandTotal = dblSubTotValue + CalcTaxTot;

            //Set Tax% LABEL
            //If "ComBoxState_SelectedIndexChanged" changes then this will recalculate.
            Object selectedItem = ComBoxState.SelectedItem;
            string TaxRateArea = selectedItem.ToString();
            LblTax.Text = "$" + CalcTaxTot.ToString() + " - " + TaxRateArea; //Add State next to tax value.

            //Set Total LABEL
            string strTotal;
            strTotal = GrandTotal.ToString();
            strTotal = String.Format("{0:c}", double.Parse(strTotal));
            LblTotalPrice.Text = strTotal;
        }

        private void ClearPizza()
        {   //Clear All Pizzas Ordered, Payment Info, and Reset to Pizza Defaults.
            ComBoxQuan.Text = "1";
            TxtBoxCouponID.Text = "";
            TxtBoxCC.Text = "";
            TxtBoxCVC.Text = "";
            LblSubTot.ForeColor = Color.Black;
            LblCouponID.ForeColor = Color.Black;
            LblSubTotTitle.ForeColor = Color.Black;
            TxtBoxCouponID.ForeColor = Color.Black;
            TxtBoxPizzaOrder.Text = "";
            boolAddPizza = false;
            LblCouponValid.Text = "";
            LblSubTot.Text = "$0.00";
            LblTax.Text = "$0.00";
            LblTotalPrice.Text = "$0.00";
            dblSubTotValue = 0.00;
            RadBtnLrg.Checked = true;
            ChkBoxSaus.Checked = false;
            ChkBoxPepp.Checked = false;
            ChkBoxOliv.Checked = false;
            ChkBoxAnch.Checked = false;
            ChkBoxOnio.Checked = false;
            RadBtnCheYes.Checked = true;
            RadBtnCash.Checked = true;
            RadBtnLrg.Focus(); //Change cusor position to Large Pizza. You can't see it but the arrow keys will work.
        }

        private void ClearCustomer()
        {   //Clear Customer Info Only.
            TxtBoxFirstName.Text = "";
            TxtBoxMI.Text = "";
            TxtBoxLastName.Text = "";
            TxtBoxStrAdd.Text = "";
            TxtBoxAptNo.Text = "";
            //Don't change the City when the form is cleared.
            //Don't change the State when the form is cleared.
            //Don't change the Zip when the form is cleared.
            TxtBoxAreaCode.Text = "";
            TxtBoxPh3Dig.Text = "";
            TxtBoxPh4Dig.Text = "";
            TxtBoxCustInfo.Text = "";
            TxtBoxFirstName.Focus(); //Change cusor position to First Name.
        }

    }
}