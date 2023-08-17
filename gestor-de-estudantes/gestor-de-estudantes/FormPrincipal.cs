using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_de_estudantes
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante inserirEstudante = new FormInserirEstudante();
            inserirEstudante.Show(this);
        }

        private void listarEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarEstudantes formListarEstudantes = new FormListarEstudantes();
            formListarEstudantes.Show(this);

        }
    }
}
