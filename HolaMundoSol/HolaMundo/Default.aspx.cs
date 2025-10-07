using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundo
{
    public partial class _Default : Page
    {
           protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(insertar.Text))
            {
                insertar.Text = "";
                insertar.Text = "Introduce algo";

            } else
            { 
            string nombre = insertar.Text;
            insertar.Text = "Hola " + nombre;
            }
        }

        protected void insertar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}