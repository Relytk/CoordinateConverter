using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*This class calls the functions in the Calculations class.
 * It then retrieves the answers and displays them on the gui
 */

namespace CoordinateConverter
{
    public partial class Form1 : Form
    {
        private Calculations calculator = new Calculations(); //making the object calculator to call the functions
		private string failureMessage = "Cannot display value.";

        public Form1()
        {
            InitializeComponent();

			coordList.SelectedIndex = 0;
        }

		private void ConvertSetValues()
		{
			double latitude = Convert.ToDouble (latitudeText.Text);
			double longitude = Convert.ToDouble (longitudeText.Text);  //it will grab the numbers in the text boxes

			latitude = latitude * (Math.PI / 180);  //and converts them to radians and stores them in the variables latitude and longitude
			longitude = longitude * (Math.PI / 180);

			if (coordList.Text == "Ecliptic") //if you input Ecliptic degrees it will calculate galactic and equatorial
			{


				calculator.eclipticToEquatorial (longitude, latitude);                       //equatorial
				calculator.equatorialToGalactic (calculator.getEquatorialLongitude () * (Math.PI / 180), calculator.getEquatorialLatitude () * (Math.PI / 180)); //galactic

				latitude = latitude * (180 / Math.PI);
				longitude = longitude * (180 / Math.PI);

				equatorialLabel.Text = ("(" + calculator.getEquatorialLongitude () + ", " + calculator.getEquatorialLatitude () + ")"); //displays the equatorial degrees
				eclipticLabel.Text = ("(" + longitude + ", " + latitude + ")");                                                            //displays ecliptic
				galacticLabel.Text = ("(" + calculator.getGalacticLongitude () + ", " + calculator.getGalacticLatitude () + ")");   //and galactic
			}

			if (coordList.Text == "Equatorial") //if you put equatorial it will calculate galactic and ecliptic
			{

				calculator.equatorialToEcliptic (longitude, latitude); //calculates
				calculator.equatorialToGalactic (longitude, latitude);

				latitude = latitude * (180 / Math.PI); //to degrees
				longitude = longitude * (180 / Math.PI);
				eclipticLabel.Text = ("(" + calculator.getEclipticLongitude () + ", " + calculator.getEclipticLatitude () + ")");
				equatorialLabel.Text = ("(" + longitude + ", " + latitude + ")");
				galacticLabel.Text = ("(" + calculator.getGalacticLongitude () + ", " + calculator.getGalacticLatitude () + ")");
			}

			if (coordList.Text == "Galactic") // calculates ecliptic and equatorial if you put in galactic
			{
				calculator.galacticToEquatorial (longitude, latitude);
				calculator.equatorialToEcliptic (calculator.getEquatorialLongitude () * (Math.PI / 180), calculator.getEquatorialLatitude () * (Math.PI / 180));

				latitude = latitude * (180 / Math.PI);
				longitude = longitude * (180 / Math.PI);

				eclipticLabel.Text = ("(" + calculator.getEclipticLongitude () + ", " + calculator.getEclipticLatitude () + ")");
				galacticLabel.Text = ("(" + longitude + ", " + latitude + ")");
				equatorialLabel.Text = ("(" + calculator.getEquatorialLongitude () + ", " + calculator.getEquatorialLatitude () + ")");
			}
		}

		private bool ValidateValues()
		{
			double result;

			return double.TryParse (latitudeText.Text, out result)
				&& double.TryParse (longitudeText.Text, out result);
		}

		private void InvalidateDisplay()
		{
			try
			{
				if (!ValidateValues ())
				{
					SetCantDisplayValues ();
					return;
				}

				ConvertSetValues ();
			}
			catch
			{
				SetCantDisplayValues();
			}
		}

		private void SetCantDisplayValues()
		{
			eclipticLabel.Text = failureMessage;
			galacticLabel.Text = failureMessage;
			equatorialLabel.Text = failureMessage;
		}

    	private void value_TextChanged (object sender, EventArgs e)
		{
			InvalidateDisplay();
		}

		private void coordList_SelectedIndexChanged(object sender, EventArgs e)
		{
			InvalidateDisplay();
		}
    }
}
