using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Curso_de_C.DataAccess.Conexion;
using Curso_de_C.DataAccess.Models;

namespace Curso_de_C.Presentacion
{
    public partial class ConferenciaForm : Form
    {
        private AppDbcontext dbContext;
        public ConferenciaForm()
        {
            InitializeComponent();
            dbContext = new AppDbcontext();
        }
        private void CargarPaises()
        {
            // Lista de países
            List<string> paises = new List<string>
            {
                "Argentina",
                "Brasil",
                "Chile",
                "Colombia",
                "México",
                "Perú",
                "Estados Unidos",
                "España",
                "Ecuador"
            };

            // Llenar el ComboBox
            CmbPais.DataSource = paises; // Usa DataSource para enlazar directamente
            CmbPais.DropDownStyle = ComboBoxStyle.DropDownList; // Opcional: Solo permite selección
        }
        private void ConferenciaForm_Load(object sender, EventArgs e)
        {
            CargarPaises();
            RbCursoMatutino.Checked = true;
            
        }

        private void BtnEnviarFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreApellido = txtNombreApellido.Text;
                string organizacion = txtOrganizacion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                string domicilio = txtDireccion.Text;
                string callestransv = txtCalletransversal.Text;
                string ciudad = txtCiudad.Text;
                string region = txtRegion.Text;
                string codigoPostal = txtCodigoPostal.Text;
                string tituloConferencia = txtTituloConferencia.Text;
                string pais=CmbPais.SelectedItem.ToString();
                string participante = "Curso por la mañana";

                if(RbCursoMatutino.Checked)
                {
                    participante = "Curso por la mañana";
                }
                
                if(RbCursoTarde.Checked)
                {
                    participante = "Curso por la tarde";
                }
                
                if(RbWorkshops.Checked)
                {
                    participante = "Workshops";
                }

                if (string.IsNullOrEmpty(nombreApellido))
                {
                    MessageBox.Show("El nombre y apellido son requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreApellido.Focus();

                    return;
                }

                if (string.IsNullOrEmpty(organizacion))
                {
                    MessageBox.Show("La organización es requerida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOrganizacion.Focus();

                    return;
                }

                if (string.IsNullOrEmpty(telefono))
                {
                    MessageBox.Show("El telefono es requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();

                    return;
                }
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("El Email es requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();

                    return;
                }
                if (string.IsNullOrEmpty(domicilio))
                {
                    MessageBox.Show("El Domicilio es requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Focus();

                    return;
                }
                if (string.IsNullOrEmpty(callestransv))
                {
                    MessageBox.Show("La calle Transeversal es requerida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCalletransversal.Focus();

                    return;
                }
                if (string.IsNullOrEmpty(ciudad))
                {
                    MessageBox.Show("La Cuidad es requerida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCiudad.Focus();

                    return;
                }
                if (string.IsNullOrEmpty(region))
                {
                    MessageBox.Show("La Region es requerida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRegion.Focus();

                    return;
                }
                if (string.IsNullOrEmpty(codigoPostal))
                {
                    MessageBox.Show("El Codigo Postal es requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigoPostal.Focus();

                    return;
                }
                 if(string.IsNullOrEmpty(tituloConferencia))
                {
                    MessageBox.Show("El Titulo De COnferencia es requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTituloConferencia.Focus();
                    return;
                }


                var conferencia = new Conferencia()
                {
                    Nombre = nombreApellido,
                    Compania = organizacion,
                    Telefono = telefono,
                    Email = email,
                    Direccion = domicilio,
                    Calles = callestransv,
                    Ciudad = ciudad,
                    Region = region,
                    Codigo = codigoPostal,
                    Pais = pais,
                    TituloConferencia = tituloConferencia,
                    Participacion = participante
                };

                dbContext.Conferencia.Add(conferencia);
                dbContext.SaveChanges();
                MessageBox.Show("Conferencia Guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al momento de guardar la conferencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
