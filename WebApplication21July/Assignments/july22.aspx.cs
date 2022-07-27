using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication21July.Models;
namespace WebApplication21July
{
    public partial class july22 : System.Web.UI.Page
    {
        States st = new States();
        Cities cities = new Cities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                StateList.Items.Add("Select");
                StateList.Items.FindByText("Select").Attributes.Add("disabled", "disabled");
                foreach (var state in st)
                {
                    StateList.Items.Add(state.stateName);
                }
                var s = StateList.Text.ToString();
                string id = string.Empty;
                foreach (var state in st)
                {
                    if(state.stateName == s)
                    {
                        id = state.stateId;
                    }
                }
                CityList.Items.Add("Select");
                CityList.Items.FindByText("Select").Attributes.Add("disabled", "disabled");
                foreach (var city in cities)
                {
                    if(city.stateID == id)
                        CityList.Items.Add(city.cityName);
                }
            }

        }

        protected void CityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StateList.Items.FindByText("Select").Attributes.Add("disabled", "disabled");
            CityList.Items.FindByText("Select").Attributes.Add("disabled", "disabled");
            lbldata.Text += $"<br/> Name: {txtname.Text} State : {StateList.Text} City: {CityList.Text} ";
        }

        protected void StateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityList.Items.Clear();
            CityList.Items.Add("Select");
            CityList.Items.FindByText("Select").Attributes.Add("disabled", "disabled");
            var s = StateList.SelectedValue;
            string id = string.Empty;
            foreach (var state in st)
            {
                if (state.stateName == s)
                {
                    id = state.stateId;
                }
            }
            foreach (var city in cities)
            {
                if (city.stateID == id)
                    CityList.Items.Add(city.cityName);
            }
            StateList.DataBind();
        }
    }
}