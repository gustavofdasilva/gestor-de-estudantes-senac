using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_de_estudantes
{
    public partial class FormListarEstudantes : Form
    {
        public FormListarEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante= new Estudante();

        private void FormListarEstudantes_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridViewLista.ReadOnly= true;
            DataGridViewImageColumn colunaDeImagens = new DataGridViewImageColumn();
            dataGridViewLista.RowTemplate.Height = 80;
            dataGridViewLista.DataSource = estudante.pegarEstudantes(comando);
            colunaDeImagens = (DataGridViewImageColumn)dataGridViewLista.Columns[7];
            colunaDeImagens.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewLista.AllowUserToAddRows= false;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            FormAtualizarEstudantes atualizarEstudante = new FormAtualizarEstudantes();
            atualizarEstudante.textBoxId.Text = dataGridViewLista.CurrentRow.Cells[0].Value.ToString();
            atualizarEstudante.textBoxNome.Text= dataGridViewLista.CurrentRow.Cells[1].Value.ToString();
            atualizarEstudante.textBoxSobrenome.Text = dataGridViewLista.CurrentRow.Cells[2].Value.ToString();
            atualizarEstudante.dateTimePickerNascimento.Value = (DateTime) dataGridViewLista.CurrentRow.Cells[3].Value;

            if (dataGridViewLista.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                atualizarEstudante.radioButtonFeminino.Checked = true;
            } else
            {
                atualizarEstudante.radioButtonMasculino.Checked = true;
            }

            atualizarEstudante.textBoxTelefone.Text = dataGridViewLista.CurrentRow.Cells[5].Value.ToString();
            atualizarEstudante.textBoxEndereco.Text = dataGridViewLista.CurrentRow.Cells[6].Value.ToString();

            byte[] fotoDaLista;
            fotoDaLista = (byte[]) dataGridViewLista.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoEstudante = new MemoryStream(fotoDaLista);
            atualizarEstudante.pictureBoxFoto.Image = Image.FromStream(fotoDoEstudante);
            atualizarEstudante.Show();

        }
    }
}
