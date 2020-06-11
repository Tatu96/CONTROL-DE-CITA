using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlCitas
{
    public partial class CITA : System.Web.UI.Page
    {

        DataSet ds = new DataSet();
        DataSet ddl = new DataSet();
        ServiceReference1.Service1Client wcf = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl = wcf.Rollist();
            DropDownNombreDoc.DataSource = ddl.Tables[0];
            DropDownNombreDoc.DataValueField = ddl.Tables[0].Columns[0].ColumnName;
            DropDownNombreDoc.DataTextField = ddl.Tables[0].Columns[1].ColumnName;
            DropDownNombreDoc.DataBind();
        }

        protected void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPaciente0.Text.Length == 0) txtIdPaciente0.Text = "0";

                ds = wcf.BuscarPaciente(int.Parse(txtIdPaciente0.Text));

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != "-1")
                            {
                                txtIdPaciente0.Text = ds.Tables[0].Rows[0][0].ToString();
                                txtNombrePaciente.Text = ds.Tables[0].Rows[0][1].ToString();
                                txtApellidosPaciente.Text = ds.Tables[0].Rows[0][2].ToString();
                                txtDireccionPaciente.Text = ds.Tables[0].Rows[0][3].ToString();
                                txttexlPaciente.Text = ds.Tables[0].Rows[0][4].ToString();
                                txtEmailPaciente.Text = ds.Tables[0].Rows[0][5].ToString();
                                txtNacimiento.Text = ds.Tables[0].Rows[0][6].ToString();
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

        protected void CalendarioCita_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void bntGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCITA.Text.Length == 0) txtIdCITA.Text = "0";

                ds = wcf.InsertarCita(DateTime.Parse(txtCalendario.Text), txtHoraCita.Text, int.Parse(DropDownNombreDoc.SelectedValue), int.Parse(txtIdPaciente0.Text));

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
                                lblMensaje.Text = "Cita no encontrado!";
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

        protected void bntEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCITA.Text.Length == 0) txtIdCITA.Text = "0";

                ds = wcf.BorrarCita(int.Parse(txtIdCITA.Text));

                if (ds != null)
                {
                    txtIdCITA.Text = "";
                    txtCalendario.Text = "";
                    txtHoraCita.Text = "";
                    DropDownNombreDoc.ClearSelection();
                    txtIdPaciente0.Text = "";


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

        protected void bntBuscarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCITA.Text.Length == 0) txtIdCITA.Text = "0";

                ds = wcf.BuscarCita(int.Parse(txtIdCITA.Text));

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != "-1")
                            {
                                txtIdCITA.Text = ds.Tables[0].Rows[0][0].ToString();
                                txtCalendario.Text = ds.Tables[0].Rows[0][1].ToString();
                                txtHoraCita.Text = ds.Tables[0].Rows[0][2].ToString();
                                DropDownNombreDoc.SelectedValue = ds.Tables[0].Rows[0][3].ToString();
                                txtIdPaciente0.Text =  ds.Tables[0].Rows[0][4].ToString();
                                lblMensaje.Text = "";
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

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCITA.Text.Length == 0) txtIdCITA.Text = "0";

                ds = wcf.ModificarCitas(int.Parse(txtIdCITA.Text),DateTime.Parse( txtCalendario.Text), txtHoraCita.Text, int.Parse(DropDownNombreDoc.SelectedValue), int.Parse(txtIdPaciente0.Text)); 

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