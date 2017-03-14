using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaculatePremium
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCalculate_Click(object sender, EventArgs e)
        {
            string gender = TextBoxGender.Text.ToLower();
            int age = Convert.ToInt32(TextBoxAge.Text);

            PremiumCalculator cp = new PremiumCalculator();

            LabelResult.Text = $"{cp.CalcPremium(age, gender)}";
        }
    }
}