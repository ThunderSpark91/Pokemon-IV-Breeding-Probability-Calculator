using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_IV_Breeding_Probability_Calculator
{
    public class Eggs_Chance
    {
        private double[] egg = { 1, 5, 10, 30, 50, 100, 200, 500, 1000 };
        private string[] percentage = { };
        private double mEggs;

        public double Eggs
        {
            get { return mEggs; }
            set { mEggs = value; }
        }

        private double mChance;

        public double Chance
        {
            get { return mChance; }
            set { mChance = value; }
        }



    }
}
