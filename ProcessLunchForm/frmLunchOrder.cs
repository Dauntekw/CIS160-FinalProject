using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Daunte Williamson CIS 160 12/05/2019 Homework 10
namespace ProcessLunchForm
{
    public partial class frmLunchOrder : Form
    {
        public frmLunchOrder()
        {
            InitializeComponent();
            rbHamburger.Checked = true;
        }
        decimal subtotal = 0m;
        decimal addonPrice = 0m;
        decimal mainCoursePrice = 0m;

        public void MainCourseSelector(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if(rb.Checked == true)
            {
                //Clear check boxes
                cbAddon1.Checked = false;
                cbAddon2.Checked = false;
                cbAddon3.Checked = false;
                //Clear text boxes
                ClearTextboxes();

                //Check for Main Course selected via radio button name
                switch (rb.Name)
                {
                    case "rbHamburger":
                        //Change totals of Main Course and Add-on items
                        mainCoursePrice = 6.95m;
                        addonPrice = 0.75m;
                        //Change Add-on item's text to match selected course
                        cbAddon1.Text = "Lettuce, tomato, and onions";
                        cbAddon2.Text = "Ketchup, mustard, and mayo";
                        cbAddon3.Text = "French Fries";
                        grbAddOns.Text = "Add-on items ($.75/each)";
                        break;
                    case "rbPizza":
                        //Change totals of Main Course and Add-on items
                        mainCoursePrice = 5.95m;
                        addonPrice = 0.50m;
                        //Change Add-on item's text to match selected course
                        cbAddon1.Text = "Pepperoni";
                        cbAddon2.Text = "Sausage";
                        cbAddon3.Text = "Olives";
                        grbAddOns.Text = "Add-on items ($.50/each)";
                        break;
                    case "rbSalad":
                        //Change totals of Main Course and Add-on items
                        mainCoursePrice = 4.95m;
                        addonPrice = 0.25m;
                        //Change Add-on item's text to match selected course
                        cbAddon1.Text = "Croutons";
                        cbAddon2.Text = "Bacon bits";
                        cbAddon3.Text = "Bread sticks";
                        grbAddOns.Text = "Add-on items ($.25/each)";
                        break;
                }
            }
        }

        public int AddonsSelected(int countAddons)
        {
            int counter = 0;
             foreach (CheckBox cb in grbAddOns.Controls)
            {
                //Increase counter per selected check box
                if (cb.Checked == true)
                {
                    counter++;
                }
            }
            return counter;
        }

        private void CheckBoxChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            //Check for changed state in check box and clear text boxes
            if (cb.Checked == true || cb.Checked == false)
            {
                ClearTextboxes();
            }
        }

        public void ClearTextboxes()
        {
            //Clear all text boxes
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes form
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int addonCounter = 0;//counter variable for add-on calculation
            decimal orderTotal;
            decimal tax;
            //Transfer mainCoursePrice to subtotal
            subtotal = mainCoursePrice;

            //Check for selected add-on check boxes
            addonCounter = AddonsSelected(addonCounter);
            
            if(addonCounter > 0)
            {
                // Add combined prices of selected add-ons to subtotal
                subtotal += (addonPrice * addonCounter);
            }

            //Calculate tax (7.75% tax)
            tax = (subtotal * 0.075m);
            orderTotal = (subtotal + tax);

            //Round totals to 2 decimal places
            Math.Round(subtotal, 2);
            Math.Round(tax, 2);
            Math.Round(orderTotal, 2);

            //Display prices to user in currency format
            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtTotal.Text = orderTotal.ToString("c");
        }
    }
}