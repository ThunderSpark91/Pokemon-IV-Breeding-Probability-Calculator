using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_IV_Breeding_Probability_Calculator.Classes
{
    public interface IIndividualValues
    {
        bool HPIV { get; set; }
        bool DEFIV { get; set; }
        bool ATKIV{ get; set; }
        bool SPATKIV { get; set; }
        bool SPDEFIV { get; set; }
        bool SPEEDIV { get; set; }

    }
}
