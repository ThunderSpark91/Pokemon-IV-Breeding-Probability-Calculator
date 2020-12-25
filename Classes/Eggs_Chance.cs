using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_IV_Breeding_Probability_Calculator
{
    public class Eggs_Chance
    {
        private double mEggs;
        private string mPercentage;


        public double Eggs
        {
            get { return mEggs; }
            set { mEggs = value; }
        }

        public string Percentage
        {
            get { return mPercentage; }
            set { mPercentage = value; }
        }

    }
}