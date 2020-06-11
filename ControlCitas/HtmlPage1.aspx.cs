using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bootstrapwebform
{
    public partial class HtmlPage1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        ControlCitas.ServiceReference1.Service1Client wcf = new ControlCitas.ServiceReference1.Service1Client();
        //ServiceReference1.Service1Client wcf = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUsuario.Text.Length == 0)
                {
                    TxtMensaje.Text = "Usuario no puede estar vacio";
                    return;
                }

                if (txtContrasena.Text.Length != 0)
                    ds = wcf.ValidarUsuario(txtUsuario.Text, txtContrasena.Text);
                if (ds != null)//Se valida si trae datos
                {
                    if (ds.Tables.Count > 0)//Se valida si trae un DataTable
                    {
                        if (ds.Tables[0].Rows.Count > 0)//Si trae Registros
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != "-1")//Si el usuario existe
                            {
                                if (!bool.Parse(ds.Tables[0].Rows[0]["Activo"].ToString()))
                                {

                                    TxtMensaje.Text = "El usuario está inactivo!";
                                    return;
                                }

                                if (int.Parse(ds.Tables[0].Rows[0]["IdRole"].ToString()) == 1)
                                {
                                    TxtMensaje.Text = "Bienvenido al Sistema " + ds.Tables[0].Rows[0][1].ToString();
                                    Session["Username"] = txtUsuario.Text;
                                    Session["IdUsuario"] = ds.Tables[0].Rows[0]["IdUsuario"].ToString();
                                    Session["IdRole"] = ds.Tables[0].Rows[0]["IdRole"].ToString();
                                    Response.Redirect("~/MenuAdmin.aspx");
                                }
                                else if (int.Parse(ds.Tables[0].Rows[0]["IdRole"].ToString()) == 3)
                                {
                                    Response.Redirect("~/MenuEmpleado.aspx");
                                }
                                else
                                    Response.Redirect("~/HtmlPage1.aspx");
                            }
                            else
                            {
                                TxtMensaje.Text = "Usuario o contraseña incorrectos!";

                                Session["Username"] = null;
                                Session["IdUsuario"] = null;
                                Session["Role"] = null;
                            }
                        }
                        else
                            TxtMensaje.Text = "Sin registros!";
                    }
                    else
                        TxtMensaje.Text = "Error en extracción de datos!";
                }
                else
                    TxtMensaje.Text = "Error en ejecución de la consulta!";
            }
            catch (Exception ex)
            {
                TxtMensaje.Text = ex.Message;
            }
        }
    }
}