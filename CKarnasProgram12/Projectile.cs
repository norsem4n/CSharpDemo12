/* Program:         HW05 - Assignment 12
 * Developed by:    Christopher Karnas
 * Date Created:    October 2020
 * Last Modified:   11.03.20
 * Class Name:      Projectile
 * Description:     Measures the projectile rate of an object
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKarnasProgram12
{
    class Projectile
    {
        #region"Properties"
        //4 instance properties, public get, private set
        public int InitialHeight { get; private set; }
        public int InitialVelocity { get; private set; }
        public double MaxHeight { get; private set; }
        public double LandTime { get; private set; }

        #endregion

        #region"Constructor(s)"
        //Constructor that instantiates object, and initializes properties
        public Projectile(int initialHeight, int initialVelocity)
        {
            InitialHeight = initialHeight;
            InitialVelocity = initialVelocity;

            //call method to set max height property
            MaxHeight = CalcMaxHeight();

            //call method to set land time property
            LandTime = CalcLandTime();
        }
        #endregion

        #region"Methods"
        //private method to find height of a projectile at certain time
        //initial height + (initial velocity * t) – (16 * t^2)
        //The method should receive the time (in seconds) as a parameter
        private double FindHeight(double atTime)
        {
            //declare variables
            double t = atTime;
            double height;

            height = InitialHeight + (InitialVelocity * t) - (16 * Math.Pow(t, 2));
            return height;
        }

        //private method that calculates and returns the max height of a projectile 
        //calls the FindHeight method for calculation
        private double CalcMaxHeight()
        {
            //declare variable(s)
            double maxHeight;

            maxHeight = FindHeight(Convert.ToDouble(InitialVelocity) / 32);
            return maxHeight;
        }

        //private method that determines and returns the appx. time in seconds when the projectile will hit the ground
        private double  CalcLandTime()
        {
            //declare variable
            double t = 0.0;

            //calls the FindHeight method for calculation
            //set loop to determine the height after every 0.01sec. When no longer positive, projectile hits ground. 
            while (FindHeight(t) > 0)
            {
                t += 0.1;
            }
            return t;
        }
        #endregion
    }
}
