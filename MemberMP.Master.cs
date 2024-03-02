using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diseasePrediction.Member
{
    public partial class MemberMP : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Font.Bold = true;
            lblMsg.ForeColor = System.Drawing.Color.DarkRed;

            lblMsg.Font.Size = 14;

            lblMsg.Text = "HIGH RISK & LOW RISK PATIENTS CLASSIFICATION USING EFFICIENT SUPERVISED LEARNING ALGORITHMS";
        }
    }
}