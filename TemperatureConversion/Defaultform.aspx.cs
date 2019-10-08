using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace TemperatureConversion
{
    public partial class Defaultform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            double outputTemp; 
            double inputTemp = double.Parse(txtInputTemp.Text);

            // if the "from tempetature" = Celsius
            if (ddlFrom.SelectedItem.Text == "Celsius")
            {
                // converting from Celsius to Fahrenheit
                if (ddlTo.SelectedItem.Text == "Fahrenheit")
                {
                    
                    outputTemp = (inputTemp * 9 / 5) + 32;
                }

                // converting from Celsius to Kelvin
                else if (ddlTo.SelectedItem.Text == "Kelvin")
                {
                    outputTemp = inputTemp + 273.15;
                }

                // converting from Celsius to Celsius
                else
                {
                    outputTemp = inputTemp;
                }
                lblresult.Text = outputTemp.ToString("F2");
            }

            // if the "from tempetature" = Fahrenheit
            if (ddlFrom.SelectedItem.Text == "Fahrenheit")
            {
                // converting from Fahrenheit to Fahrenheit
                if (ddlTo.SelectedItem.Text == "Fahrenheit")
                {

                    outputTemp = inputTemp ;
                }
                
                // converting from Fahrenheit to Kelvin
                else if (ddlTo.SelectedItem.Text == "Kelvin")
                {
                    outputTemp = (inputTemp + 459.67) * 5/9;
                }
                
                // converting from Fahrenheit to Celsius
                else
                {
                    outputTemp = (inputTemp - 32) * 5/9;
                }
                lblresult.Text = outputTemp.ToString("F2");
            }

            // if the "from tempetature" = Kelvin
            if (ddlFrom.SelectedItem.Text == "Kelvin")
            {
                // converting from Kelvin to Fahrenheit
                if (ddlTo.SelectedItem.Text == "Fahrenheit")
                {
                   
                    outputTemp = inputTemp * 9/5 - 459.67;
                }

                // converting from Kelvin to Kelvin
                else if (ddlTo.SelectedItem.Text == "Kelvin")
                {
                    outputTemp = inputTemp;
                }

                // converting from Kelvin to Celsius
                else
                {
                    outputTemp = inputTemp - 273.15;
                }
                lblresult.Text = outputTemp.ToString("F2");
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            // Clear button  erases contents from the input text box and output lable
            // and resets the conversion selection to the default one"Celsius to Fahrenheit"

            txtInputTemp.Text = "";
            lblresult.Text = "";
            ddlFrom.SelectedIndex = 0;
            ddlTo.SelectedIndex = 0;

        }
    }
}