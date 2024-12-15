using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Curso_de_C.DataAccess.Conexion;

namespace Curso_de_C.Presentacion
{
    public partial class LIstadoConferenciaForm : Form
    {
        private AppDbcontext dbContext;
        public LIstadoConferenciaForm()
        {
            InitializeComponent();
            dbContext = new AppDbcontext();
        }

        private void LIstadoConferenciaForm_Load(object sender, EventArgs e)
        {
            DgvConferencia.DataSource = dbContext.Conferencia.ToList();
        }
    }
}
