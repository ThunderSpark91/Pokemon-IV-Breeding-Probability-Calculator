using Pokemon_IV_Breeding_Probability_Calculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_IV_Breeding_Probability_Calculator
{
    public class IVSpread_text : IIndividualValues
    {


        private string IVtoString(bool IV_31)
        {
            if (IV_31 == true)
            {
                return "31";
            }
            else
            {
                return "x";
                
            }
        }

        private bool mHPIV;
        private bool mDEFIV;
        private bool mATKIV;
        private bool mSPATKIV;
        private bool mSPDEFIV;
        private bool mSPEEDIV;
        private string Str_HPIV;
        private string Str_ATKIV;
        private string Str_DEFIV;
        private string Str_SPATKIV;
        private string Str_SPDEFIV;
        private string Str_SPEEDIV;
        

        public bool HPIV
        {
            get 
            { 
                return mHPIV;
            }
            set 
            { 
                mHPIV = value;
                Str_HPIV = IVtoString(mHPIV);

            }
        }

        public bool ATKIV
        {
            get 
            { 
                return mATKIV; 

            }
            set 
            { 
                mATKIV = value;
                Str_ATKIV = IVtoString(mATKIV);
            }
        }
        public bool DEFIV
        {
            get 
            { 
                return mDEFIV; 
            }
            set 
            { 
                mDEFIV = value;
                Str_DEFIV = IVtoString(mDEFIV);
            }
        }
       

        public bool SPATKIV
        {
            get 
            { 

                return mSPATKIV;
            }
            set 
            {
                mSPATKIV = value;
                Str_SPATKIV = IVtoString(mSPATKIV);
            }
        }
        public bool SPDEFIV
        {
            get 
            { 
                return mSPDEFIV; 
            }
            set 
            {
                mSPDEFIV = value;
                Str_SPDEFIV = IVtoString(mSPDEFIV);
            }
        }
        public bool SPEEDIV
        {
            get 
            { 
                return mSPEEDIV; 
            }
            set 
            { 
                mSPEEDIV = value;
                Str_SPEEDIV = IVtoString(mSPEEDIV);

            }
        }
        private string IVtoString(int IVtoString)
        {
            if (IVtoString == 31)
            {
                return "31";

            }
            else
            {
                return "x";
            }


        }



        public IVSpread_text()
        {
            this.HPIV = false;
            this.ATKIV = false;
            this.DEFIV = false;
            this.SPATKIV = false;
            this.SPDEFIV = false;
            this.SPDEFIV = false;
            this.SPEEDIV = false;
        }

        public IVSpread_text( bool hpiv, bool atkiv, bool defiv, bool spatkiv, bool spdefiv, bool speediv)
        {
            this.HPIV = hpiv;
            this.ATKIV = atkiv;
            this.DEFIV = defiv;
            this.SPATKIV = spatkiv;
            this.SPDEFIV = spdefiv;
            this.SPEEDIV = speediv;
        }


        public string IVSPREAD()
        {
            //return $"{Naam + "(" + Leeftijd.ToString() + ")",‐30} ‐ {MinScore(),3} ‐ { Marktwaarde,20:C};
            // of:
            return (Str_HPIV + "/" + Str_ATKIV + "/" + Str_DEFIV + "/" + Str_SPATKIV + "/" + Str_SPDEFIV + "/" + Str_SPEEDIV);
        }
    }
}
