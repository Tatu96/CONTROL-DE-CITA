using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlCitas
{
    public partial class DOCTORES2 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        DataSet User = new DataSet();
        DataSet Espec = new DataSet();
        ServiceReference1.Service1Client wcf = new ServiceReference1.Service1Client();
      

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                User = wcf.ListarUsuario();
                DropDownRUsuario.DataSource = User.Tables[0];
                DropDownRUsuario.DataValueField = User.Tables[0].Columns[0].ColumnName;
                DropDownRUsuario.DataTextField = User.Tables[0].Columns[1].ColumnName;
                DropDownRUsuario.DataBind();

                Espec = wcf.ListarEspecialidad();
                DropDownREspecialidad.DataSource = Espec.Tables[0];
                DropDownREspecialidad.DataValueField = Espec.Tables[0].Columns[0].ColumnName;
                DropDownREspecialidad.DataTextField = Espec.Tables[0].Columns[1].ColumnName;
                DropDownREspecialidad.DataBind();


            }
        }

        protected void btnDuscarDoc_Click(object sender, EventArgs e)
        {
                try
                {
                    if (txtIdDoc.Text.Length == 0) txtIdDoc.Text = "0";

                    ds = wcf.BuscarDoc(int.Parse(txtIdDoc.Text));

                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                if (ds.Tables[0].Rows[0][0].ToString() != "-1")
                                {
                                    txtIdDoc.Text = ds.Tables[0].Rows[0][0].ToString();
                                    txtNombreDoc.Text = ds.Tables[0].Rows[0][1].ToString();
                                    txtApellidoDoc.Text = ds.Tables[0].Rows[0][2].ToString();
                                    txtTelCelDOC.Text = ds.Tables[0].Rows[0][3].ToString();
                                    txtEmailDoc.Text = ds.Tables[0].Rows[0][4].ToString();
                                    DropDownREspecialidad.SelectedValue = ds.Tables[0].Rows[0][5].ToString();
                                    DropDownRUsuario.SelectedValue = ds.Tables[0].Rows[0][6].ToString();


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

        protected void btnGuardarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdDoc.Text.Length == 0) txtIdDoc.Text = "0";

                ds = wcf.InsertDoctor(txtNombreDoc.Text, txtApellidoDoc.Text, txtTelCelDOC.Text, txtEmailDoc.Text, int.Parse(DropDownREspecialidad.SelectedValue), int.Parse(DropDownRUsuario.SelectedValue));

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
                                lblMensaje.Text = "Empleado no encontrado!";
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

        protected void btnEliminarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdDoc.Text.Length == 0) txtIdDoc.Text = "0";

                ds = wcf.BorrarDoc(int.Parse(txtIdDoc.Text));

                if (ds != null)
                {
                    txtIdDoc.Text = "";
                    txtNombreDoc.Text = "";
                    txtApellidoDoc.Text = "";
                    txtTelCelDOC.Text = "";
                    txtEmailDoc.Text = "";
                    DropDownREspecialidad.ClearSelection();
                    DropDownRUsuario.ClearSelection();
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

        protected void btnActualizarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdDoc.Text.Length == 0) txtIdDoc.Text = "0";

                ds = wcf.ModificarDoctor(int.Parse(txtIdDoc.Text), txtNombreDoc.Text, txtApellidoDoc.Text, txtTelCelDOC.Text, txtEmailDoc.Text, int.Parse(DropDownREspecialidad.SelectedValue), int.Parse(DropDownRUsuario.SelectedValue));

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

        protected void txtIdDoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}