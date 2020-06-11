using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlCitas
{
    public partial class ROLES2 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        DataSet ddl = new DataSet();
        ServiceReference1.Service1Client wcf = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdRol.Text.Length == 0) txtIdRol.Text = "0";

                ds = wcf.BuscarRol(int.Parse(txtIdRol.Text));

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != "-1")
                            {
                                txtIdRol.Text = ds.Tables[0].Rows[0][0].ToString();
                                txtNombreRoles.Text = ds.Tables[0].Rows[0][1].ToString();


                            }
                            else
                                lblMensaje.Text = "Control no encontrado!";
                        }
                        else
                            lblMensaje.Text = "Sin registros!";
                    }
                    else
                        lblMensaje.Text = "Sin datos!";
                }
                else
                    lblMensaje.Text = "Error en la consulta!";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                ds = wcf.InsertRol(txtNombreRoles.Text);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != "-1")
                            {
                                lblMensaje.Text = "Registro agregado!. Id: " + ds.Tables[0].Rows[0][0].ToString();
                            }
                            else
                                lblMensaje.Text = "Roles no encontrado!";
                        }
                        else
                            lblMensaje.Text = "Sin registros!";
                    }
                    else
                        lblMensaje.Text = "Sin datos!";
                }
                else
                    lblMensaje.Text = "Error en la inserción de datos!";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtIdRol.Text.Length == 0) txtIdRol.Text = "0";

                ds = wcf.EliminarRol(int.Parse(txtIdRol.Text));

                if (ds != null)
                {
                    txtIdRol.Text = "";
                    txtNombreRoles.Text = "";
                    lblMensaje.Text = "";
                    lblMensaje.Text = "Eliminado";
                }
                else
                    lblMensaje.Text = "Error en la consulta!";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnActualizarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdRol.Text.Length == 0) txtIdRol.Text = "0";

                ds = wcf.EditRol(int.Parse(txtIdRol.Text), txtNombreRoles.Text);
                if (ds != null)
                {
                    lblMensaje.Text = "Actualizado";
                }
                else
                    lblMensaje.Text = "Error en la inserción de datos!";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }

 
}
