using System;

namespace StudentRegForm
{
    public partial class Default : System.Web.UI.Page

{
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!chkTerms.Checked)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "Please accept Terms and Conditions!";
                return;
            }

            string gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : "Not Selected");

            string dob = calDOB.SelectedDate == DateTime.MinValue
                ? "Not Selected"
                : calDOB.SelectedDate.ToShortDateString();
            lblOutput.ForeColor = System.Drawing.Color.Green;
            lblOutput.Text = $"Registration Successful!<br/>"
                + $"Name: {txtName.Text}<br/>"
                + $"Gender: {gender}<br/>"
                + $"Course: {ddlCourse.SelectedValue}<br/>"
                + $"DOB: {dob}";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            ddlCourse.SelectedIndex = 0;
            chkTerms.Checked = false;
            lblOutput.Text = "";
        }
    }
}
