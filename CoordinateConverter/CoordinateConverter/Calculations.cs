using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*This class creates the calculations object which will be used to convert
 * I decided to use an object because the Form1 class would be pretty messy with all these functions in there
 */
namespace CoordinateConverter
{
    class Calculations
    {
        private const double meanObliquity = 23.439 * (Math.PI/180);
        private double equatorialLatitude = 0;
        private double equatorialLongitude = 0;
        private double eclipticLatitude = 0;
        private double eclipticLongitude = 0;
        private double galacticLatitude = 0;
        private double galacticLongitude = 0;  //Variables which are private so they can't accidently get changed

        public void eclipticToEquatorial(double longitude, double latitude) //This function converts ecliptic to equatorial
        {

            double y = Math.Sin(longitude) * Math.Cos(meanObliquity) - Math.Tan(latitude) * Math.Sin(meanObliquity); //calculates the y of the longitude
            double x =  Math.Cos(longitude);                                                                           //calclates the x of the longitude
            equatorialLongitude = Math.Atan2(y , x); //gets the equatorial longitude in radians
            equatorialLatitude = Math.Asin((Math.Sin(meanObliquity) * Math.Sin(longitude) * Math.Cos(latitude)) + (Math.Cos(meanObliquity) * Math.Sin(latitude))); //calculates the latitude in radians

            if (x > 0)                                                                      //These are all the cases for when you use the aTan2 function
            {
                equatorialLongitude = Math.Round(equatorialLongitude * (180 / Math.PI), 3); //These ifs make sure your in the right quadrant of the circle.
            }
            if ((y >= 0) && (x < 0))
            {
               equatorialLongitude = Math.Round((equatorialLongitude + Math.PI) * (180 / Math.PI), 3);

            }

            if ((y < 0) && (x < 0))
            {
                equatorialLongitude = Math.Round((equatorialLongitude) * (180 / Math.PI), 3);
                equatorialLongitude = equatorialLongitude + 360;

            }

            if ((y > 0) && (x == 0))
            {
                equatorialLongitude = Math.Round((equatorialLongitude + (Math.PI / 2)) * (180 / Math.PI), 3);

            }

            if ((y < 0) && (x == 0))
            {
                equatorialLongitude = Math.Round(equatorialLongitude * (180 / Math.PI), 3);
                equatorialLongitude = equatorialLongitude - 180;

            }


            equatorialLatitude = Math.Round(equatorialLatitude * (180 / Math.PI), 3); //after all the cases have been checked it converts to degrees
        }

        public void equatorialToEcliptic(double longitude, double latitude)//converts equatorial to ecliptic
        {
            double y = (Math.Sin(longitude) * Math.Cos(meanObliquity) + Math.Tan(latitude) * Math.Sin(meanObliquity)); //y of the longitude
            double x = Math.Cos(longitude); //x of the longitude

            eclipticLongitude = Math.Atan2(y , x); //calculates longitude

            eclipticLatitude = Math.Asin(Math.Sin(latitude) * Math.Cos(meanObliquity) - Math.Cos(latitude) * Math.Sin(longitude) * Math.Sin(meanObliquity)); //calculates latitude
            
            eclipticLatitude = Math.Round(eclipticLatitude * (180 / Math.PI), 3);
            if (x > 0)                                                                  //cases for atan2
            {
                eclipticLongitude = Math.Round(eclipticLongitude * (180 / Math.PI), 3);
            }
            if ((y >= 0) && (x < 0))
            {
                eclipticLongitude = Math.Round((eclipticLongitude + Math.PI) * (180 / Math.PI), 3);

            }

            if ((y < 0) && (x < 0))
            {
                eclipticLongitude = Math.Round((eclipticLongitude) * (180 / Math.PI), 3);
                eclipticLongitude = eclipticLongitude + 360;


            }

            if ((y > 0) && (x == 0))
            {
                eclipticLongitude = Math.Round((eclipticLongitude + (Math.PI/2)) * (180 / Math.PI), 3);

            }

            if ((y < 0) && (x == 0))
            {
                eclipticLongitude = Math.Round(eclipticLongitude * (180 / Math.PI), 3);
                eclipticLongitude = eclipticLongitude - 180;

            }




        }

        public void equatorialToGalactic(double longitude, double latitude) //equatorial to galactic
        {
            galacticLatitude = Math.Asin(Math.Cos(latitude)*Math.Cos((27.4 * (Math.PI/180)))*Math.Cos(longitude - (192.25 * (Math.PI/180))) + Math.Sin(latitude)*Math.Sin((27.4 * (Math.PI/180))));

            double y = Math.Sin(latitude) - (Math.Sin(galacticLatitude) * Math.Sin(.477)); //the galactic latitude has to be calculated first because it is used in the longitude equation
            double x = Math.Cos(latitude) * Math.Sin(longitude - 3.358) * Math.Cos(.477);

            galacticLongitude = Math.Atan2(y, x) + .57566;
            galacticLatitude = Math.Round(galacticLatitude * (180 / Math.PI), 3);

            if (x > 0) //cases for atan2
            {
                galacticLongitude = Math.Round(galacticLongitude * (180 / Math.PI), 3);
            }
            if ((y >= 0) && (x < 0))
            {
                galacticLongitude = Math.Round((galacticLongitude + Math.PI) * (180 / Math.PI), 3);

            }

            if ((y < 0) && (x < 0))
            {
                galacticLongitude = Math.Round((galacticLongitude) * (180 / Math.PI), 3);
                galacticLongitude = galacticLongitude - 360;
            }

            if ((y > 0) && (x == 0))
            {
                galacticLongitude = Math.Round((galacticLongitude + (Math.PI / 2)) * (180 / Math.PI), 3);

            }

            if ((y < 0) && (x == 0))
            {
                galacticLongitude = Math.Round(galacticLongitude * (180 / Math.PI), 3);
                galacticLongitude = galacticLongitude - 180;

            }

            if (galacticLongitude < 0)
                galacticLongitude = galacticLongitude + 360;
        }

        public void galacticToEquatorial(double longitude, double latitude) //galactic to equatorial
        {
            equatorialLatitude = Math.Asin(Math.Cos(latitude) * Math.Cos(.477) * Math.Sin(longitude - .57566) + Math.Sin(latitude) * Math.Sin(.477)); //very similar to the above function

            double y = Math.Cos(latitude) * Math.Cos(longitude - .57566);
            double x = Math.Sin(latitude) * Math.Cos(.477) - Math.Cos(latitude) * Math.Sin(.477) * Math.Sin(longitude - .57566);

            equatorialLongitude = Math.Atan2(y, x) + 3.353; 
            equatorialLatitude = Math.Round(equatorialLatitude * (180 / Math.PI), 3);

            if (x > 0) //cases for atan2
            {
                equatorialLongitude = Math.Round(equatorialLongitude * (180 / Math.PI), 3);
            }
            if ((y >= 0) && (x < 0))
            {
                equatorialLongitude = Math.Round((equatorialLongitude + Math.PI) * (180 / Math.PI), 3);

            }

            if ((y < 0) && (x < 0))
            {
                equatorialLongitude = Math.Round((equatorialLongitude) * (180 / Math.PI), 3);
                equatorialLongitude = equatorialLongitude - 360;
            }

            if ((y > 0) && (x == 0))
            {
                equatorialLongitude = Math.Round((equatorialLongitude + (Math.PI / 2)) * (180 / Math.PI), 3);

            }

            if ((y < 0) && (x == 0))
            {
                equatorialLongitude = Math.Round(equatorialLongitude * (180 / Math.PI), 3);
                equatorialLongitude = equatorialLongitude - 180;

            }

            if (equatorialLongitude < 0)
                equatorialLongitude = equatorialLongitude + 360;
        }

        public double getEquatorialLatitude()  //These functions are used to get the values from this class.  They will be used in the form1 class to display the values and to calculate other values
        {
            return equatorialLatitude;
        }

        public double getEquatorialLongitude()
        {
            return equatorialLongitude;
        }

        public double getEclipticLatitude()
        {
            return eclipticLatitude;
        }

        public double getEclipticLongitude()
        {
            return eclipticLongitude;
        }

        public double getGalacticLatitude()
        {
            return galacticLatitude;
        }

        public double getGalacticLongitude()
        {
            return galacticLongitude;
        }
    }
}
