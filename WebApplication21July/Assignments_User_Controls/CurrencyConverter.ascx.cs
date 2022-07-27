using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication21July.Assignments_User_Controls
{
    public partial class CurrencyConverter : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownList1.ClearSelection();
                DropDownList2.ClearSelection();
                DropDownList1.Items.FindByText("INR").Selected = true;
                DropDownList2.Items.FindByText("USD").Selected = true;
                TextBox1.Text = "1";
                TextBox2.Text = DropDownList2.SelectedValue;
                lblstatus.Text = $"1 INR equals {DropDownList2.SelectedValue} USD.";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            double v1 = Convert.ToDouble(DropDownList1.SelectedValue);
            double v2 = Convert.ToDouble(DropDownList2.SelectedValue);



            double convertRate = v1 / v2;

            if (TextBox1.Text==String.Empty || TextBox2.Text ==String.Empty)
            {
                TextBox1.Text = "1";
                TextBox2.Text = convertRate.ToString();
                return;
            }
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);

           

            lblstatus.Text = $"1 {DropDownList1.SelectedItem.Text} equals to {convertRate} {DropDownList2.SelectedItem.Text}.";

            double ans = num1 * convertRate;
            TextBox2.Text = ans.ToString();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(DropDownList1.SelectedValue);
            double v2 = Convert.ToDouble(DropDownList2.SelectedValue);



            double convertRate = v2 / v1;
            if (TextBox1.Text == String.Empty || TextBox2.Text == String.Empty)
            {
                TextBox1.Text = convertRate.ToString();
                TextBox2.Text = "1";
                return;
            }
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);

            

            lblstatus.Text = $"1 {DropDownList1.SelectedItem.Text} equals to {convertRate} {DropDownList2.SelectedItem.Text}.";

            double ans = num2 * convertRate;
            TextBox1.Text = ans.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(DropDownList1.SelectedValue);
            double v2 = Convert.ToDouble(DropDownList2.SelectedValue);



            double convertRate = v1 / v2;

            if (TextBox1.Text == String.Empty || TextBox2.Text == String.Empty)
            {
                TextBox1.Text = "1";
                TextBox2.Text = convertRate.ToString();
                return;
            }
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);

            

            lblstatus.Text = $"1 {DropDownList1.SelectedItem.Text} equals to {convertRate} {DropDownList2.SelectedItem.Text}.";

            double ans = num1 * convertRate;
            TextBox2.Text = ans.ToString();


        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(DropDownList1.SelectedValue);
            double v2 = Convert.ToDouble(DropDownList2.SelectedValue);

            double convertRate = v1 / v2;
            if (TextBox1.Text == String.Empty || TextBox2.Text == String.Empty)
            {
                TextBox1.Text = "1";
                TextBox2.Text = convertRate.ToString();
                return;
            }
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);

            

            lblstatus.Text = $"1 {DropDownList1.SelectedItem.Text} equals to {convertRate} {DropDownList2.SelectedItem.Text}.";

            double ans = num1 * convertRate;
            TextBox2.Text = ans.ToString();

        }
    }
}