using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonAgrandar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BotonAgrandar.Visible = false;
            BotonAchicar.Visible = true;
        }

        private void BotonAchicar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BotonAchicar.Visible = false;
            BotonAgrandar.Visible = true;
        }

        private void BotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonAbiertos_Click(object sender, EventArgs e)
        {
            PanelAbiertos.Visible = true;
        }

        private void BotonCerrados_Click(object sender, EventArgs e)
        {
            PanelCerrados.Visible = true;
        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            PanelAbiertos.Visible = false;
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            PanelAbiertos.Visible = false;
        }

        private void Boton3_Click(object sender, EventArgs e)
        {
            PanelCerrados.Visible = false;
        }

        private void Boton4_Click(object sender, EventArgs e)
        {
            PanelCerrados.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
