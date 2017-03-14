using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAssignment;

    namespace FitFixture
{
    public class FitTest :fit.ColumnFixture
    {
        public int age;
        public string gender;


        CaculatePremium cp = new CaculatePremium();

        public double Premium()
        {

            return cp.CalcPremium(age, gender);
        }
    }
}
