using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlCitas
{
    public partial class PACIENTES2 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        DataSet User = new DataSet();
        DataSet Espec = new DataSet();
        ServiceReference1.Service1Client wcf = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPaciente.Text.Length == 0) txtIdPaciente.Text = "0";

                ds = wcf.BuscarPaciente(int.Parse(txtIdPaciente.Text));

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != "-1")
                            {
                                txtIdPaciente.Text = ds.Tables[0].Rows[0][0].ToString();
                                txtNombrePaciente.Text = ds.Tables[0].Rows[0][1].ToString();
                                txtApellidosPaciente.Text = ds.Tables[0].Rows[0][2].ToString();
                                txtDirecPaciente.Text = ds.Tables[0].Rows[0][3].ToString();
                                txttexlPaciente.Text = ds.Tables[0].Rows[0][4].ToString();
                                txtEmailPaciente.Text = ds.Tables[0].Rows[0][5].ToString();
                                txtFechaNaciPaciente.Text = ds.Tables[0].Rows[0][6].ToString();
                                txtDUIPaciente0.Text = ds.Tables[0].Rows[0][7].ToString();

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
                if (txtIdPaciente.Text.Length == 0) txtIdPaciente.Text = "0";

                ds = wcf.InsertPaciente(txtNombrePaciente.Text, txtApellidosPaciente.Text, txtDirecPaciente.Text, txttexlPaciente.Text, txtEmailPaciente.Text, DateTime.Parse(txtFechaNaciPaciente.Text), txtDUIPaciente0.Text);

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
                                lblMensaje.Text = "Paciente no encontrado!";
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

        protected void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPaciente.Text.Length == 0) txtIdPaciente.Text = "0";

                ds = wcf.BorrarPaciente(int.Parse(txtIdPaciente.Text));

                if (ds != null)
                {
                    txtIdPaciente.Text = "";
                    txtNombrePaciente.Text = "";
                    txtApellidosPaciente.Text = "";
                    txtDirecPaciente.Text = "";
                    txttexlPaciente.Text = "";
                    txtEmailPaciente.Text = "";
                    txtFechaNaciPaciente.Text = "";
                    txtDUIPaciente0.Text = "";
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
                if (txtIdPaciente.Text.Length == 0) txtIdPaciente.Text = "0";

                ds = wcf.ActualizarPaciente(int.Parse(txtIdPaciente.Text), txtNombrePaciente.Text, txtApellidosPaciente.Text, txtDirecPaciente.Text, txttexlPaciente.Text, txtEmailPaciente.Text, DateTime.Parse(txtFechaNaciPaciente.Text), txtDUIPaciente0.Text);

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

        protected void btnActualizarPacienet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPaciente.Text.Length == 0) txtIdPaciente.Text = "0";

                ds = wcf.ActualizarPaciente(int.Parse(txtIdPaciente.Text), txtNombrePaciente.Text, txtApellidosPaciente.Text, txtDirecPaciente.Text, txttexlPaciente.Text, txtEmailPaciente.Text, DateTime.Parse(txtFechaNaciPaciente.Text), txtDUIPaciente0.Text);

                if (ds != null)
                {
                    lblMensaje.Text = "Modificado";
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