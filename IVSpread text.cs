using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_IV_Breeding_Probability_Calculator
{
    public class IVSpread_text
    {
        Random bepaalWillekeurig = new System.Random();

        private int IVtoInt(bool IV_31)
        {
            if (IV_31 == true)
            {
                return 31;
            }
            else
            {
                return bepaalWillekeurig.Next(1,30);
                
            }
        }
        private bool mHPIV;
        private bool mDEFIV;
        private bool mATKIV;
        private bool mSPATKIV;
        private bool mSPDEFIV;
        private bool mSPEEDIV;
        private int Int_HPIV;
        private int Int_ATKIV;
        private int Int_DEFIV;
        private int Int_SPATKIV;
        private int Int_SPDEFIV;
        private int Int_SPEEDIV;
        

        public bool HPIV
        {
            get 
            { 
                return mHPIV;
            }
            set 
            { 
                mHPIV = value;
                Int_HPIV = IVtoInt(mHPIV);

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
                Int_ATKIV = IVtoInt(mATKIV);
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
                Int_DEFIV = IVtoInt(mDEFIV);
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
                Int_SPATKIV = IVtoInt(mSPATKIV);
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
                Int_SPDEFIV = IVtoInt(mSPDEFIV);
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
                Int_SPEEDIV = IVtoInt(mSPEEDIV);

            }
        }

        public void  IVPSREAD(string IVSPREAD )
        {


        }
        

    }
}
