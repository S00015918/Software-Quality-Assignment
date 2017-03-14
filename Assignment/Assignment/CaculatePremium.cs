﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CaculatePremium
    {
        public float CalcPremium(int age, string gender)
        {
            float premium;

            if (gender == "Female")
            {
                if ((age >= 18) && (age <= 30))
                {
                    premium = 5f;
                }
                else
                      if (age >= 31)
                {
                    premium = 2.5f;
                }

                else
                {
                    premium = 0;
                }
            }
            else

                if (gender == "Male")
            {
                if ((age > 18) && (age <= 35))
                    premium = 6f;
                else
                    if (age >= 36)
                {
                    premium = 5f;
                }
                else
                    premium = 0;
            }

            else
                premium = 0;

            if (age >= 50)
            {
                premium = premium * 0.15f;
            }
            return premium;
        }

    }
}
