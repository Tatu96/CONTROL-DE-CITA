using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlCitas
{
    public partial class INGRESARUSUARIO2 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        DataSet ddl = new DataSet();
        ServiceReference1.Service1Client wcf = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddl = wcf.Rollist();
                ddlRol.DataSource = ddl.Tables[0];
                ddlRol.DataValueField = ddl.Tables[0].Columns[0].ColumnName;
                ddlRol.DataTextField = ddl.Tables[0].Columns[1].ColumnName;
                ddlRol.DataBind();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdUsuario.Text.Length == 0) txtIdUsuario.Text = "0";

                ds = wcf.BuscarUsuario(int.Parse(txtIdUsuario.Text));

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != "-1")
                            {
                                txtIdUsuario.Text = ds.Tables[0].Rows[0][0].ToString();
                                txtUsername.Text = ds.Tables[0].Rows[0][1].ToString();
                                txtPassword.Text = ds.Tables[0].Rows[0][2].ToString();
                                ddlRol.SelectedValue = ds.Tables[0].Rows[0][3].ToString();
                                CbEstado.Checked = bool.Parse(ds.Tables[0].Rows[0][4].ToString());
                                lbMensaje.Text = "";
                            }
                            else
                                lbMensaje.Text = "Control no encontrado!";
                        }
                        else
                            lbMensaje.Text = "Sin registros!";
                    }
                    else
                        lbMensaje.Text = "Sin datos!";
                }
                else
                    lbMensaje.Text = "Error en la consulta!";
            }
            catch (Exception ex)
            {
                lbMensaje.Text = ex.Message;
            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlRol.Text.Length == 0) ddlRol.Text = "0";

                ds = wcf.InsertarUsuario(txtUsername.Text, txtPassword.Text, int.Parse(ddlRol.SelectedValue), CbEstado.Checked);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != "-1")
                            {
                                lbMensaje.Text = "Registro agregado!. Id: " + ds.Tables[0].Rows[0][0].ToString();
                            }
                            else
                                lbMensaje.Text = "Empleado no encontrado!";
                        }
                        else
                            lbMensaje.Text = "Sin registros!";
                    }
                    else
                        lbMensaje.Text = "Sin datos!";
                }
                else
                    lbMensaje.Text = "Error en la inserción de datos!";
            }
            catch (Exception ex)
            {
                lbMensaje.Text = ex.Message;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlRol.Text.Length == 0) ddlRol.Text = "0";

                ds = wcf.ModificarUsuario(int.Parse(txtIdUsuario.Text), txtUsername.Text, txtPassword.Text, int.Parse(ddlRol.SelectedValue), CbEstado.Checked);

                if (ds != null)
                {
                    lbMensaje.Text = "Modificado";
                }
                else
                    lbMensaje.Text = "Error en la inserción de datos!";
            }
            catch (Exception ex)
            {
                lbMensaje.Text = ex.Message;
            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdUsuario.Text.Length == 0) txtIdUsuario.Text = "0";

                ds = wcf.EliminarUsuario(int.Parse(txtIdUsuario.Text));

                if (ds != null)
                {
                    txtIdUsuario.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    ddlRol.ClearSelection();
                    bool check = CbEstado.Checked;
                    if (check)
                    {
                        CbEstado.Checked = false;
                    }
                    lbMensaje.Text = "";
                    lbMensaje.Text = "Eliminado";
                }
                else
                    lbMensaje.Text = "Error en la consulta!";
            }
            catch (Exception ex)
            {
                lbMensaje.Text = ex.Message;
            }
        }


    }
}