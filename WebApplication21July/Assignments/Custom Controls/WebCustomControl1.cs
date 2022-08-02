using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication21July.Assignments.Custom_Controls
{
   
    [ToolboxData("<{0}:WebCustomControl1 runat=server></{0}:WebCustomControl1>")]
    public class WebCustomControl1 : CompositeControl
    {
       
        Label label1;
        Label label2;
        TextBox textBox1;
        TextBox textBox2;

        protected override void CreateChildControls()
        {
            label1 = new Label();
            label1.Text = "EmpNo";

            label2 = new Label();
            label2.Text = "EmpName";

            textBox1 = new TextBox();
            textBox1.ID = "txtBox1";

            textBox2 = new TextBox();
            textBox2.ID = "txtBox2";


        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            label1.RenderControl(output);
            label2.RenderControl(output);
            textBox1.RenderControl(output);
            textBox2.RenderControl(output);
        }
    }
}
