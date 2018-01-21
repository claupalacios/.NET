using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjListadoAlumnosWinForm
{
    public partial class frmPrincipal : Form
    {
        private ulong cantAlumnos;
        private float acumPromGeneral;
        private string mejorPromedioApellido;
        private float mejorPromedioPromedio;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string strApe, strProm;
            float prom;

            strApe = txtApellido.Text;
            strProm = txtPromedio.Text;

            if (strApe != "" && float.TryParse(strProm, out prom))
            {
                this.cantAlumnos++;
                this.acumPromGeneral += prom;
                lblCantidadValor.Text = this.cantAlumnos.ToString();
                lblPromedioGeneralValor.Text = (this.acumPromGeneral / this.cantAlumnos).ToString();
                if ((this.mejorPromedioApellido == null) || (prom > this.mejorPromedioPromedio))
                {
                    this.mejorPromedioApellido = strApe;
                    this.mejorPromedioPromedio = prom;
                    lblApellidoValor.Text = this.mejorPromedioApellido;
                    lblPromedioValor.Text = this.mejorPromedioPromedio.ToString();

                }
            }
            txtApellido.Text = "";
            txtPromedio.Text = "";
            txtPromedio.Enabled = false;
            btnIngresar.Enabled = false;

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "") txtPromedio.Enabled = true;
        }

        private void txtPromedio_TextChanged(object sender, EventArgs e)
        {
            if (txtPromedio.Text != "") btnIngresar.Enabled = true;
        }
    }
}
