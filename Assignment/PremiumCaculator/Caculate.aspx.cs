using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingAssignment;

namespace PremiumCaculator
{
    public partial class Caculate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCalculate_Click(object sender, EventArgs e)
        {
            string gender = txtGender.Text;
            int age = Convert.ToInt32(txtAge.Text);

            CaculatePremium cp = new CaculatePremium();

            lblResult.Text = (cp.CalcPremium(age, gender)).ToString();
        }
    }
}