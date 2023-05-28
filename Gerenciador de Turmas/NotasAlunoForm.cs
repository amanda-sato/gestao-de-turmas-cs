using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class NotasAlunoForm : Form
    {
        public static NotasAlunoForm instance;
        private Aluno aluno;


        public NotasAlunoForm(Aluno aluno)
        {
            InitializeComponent();
            instance = this;
            this.aluno = aluno;

            textBoxIdAluno.Text = aluno.getMatricula().ToString();
            textBoxNomeAluno.Text = aluno.getNomeAluno();

            foreach (Nota n in Program.GetState().notas)
            {
                if (n.getAlunoId() == this.aluno.getId())
                {
                    listBox.Items.Add(n);
                }
            }
        }

        private string getNomeEntidade()
        {
            return "Nota";
        }

        private void carregaEntidades(object sender, EventArgs e)
        {
            foreach (Disciplina d in Program.GetState().disciplinas)
            {
                comboBoxDisciplina.Items.Add(d);
            }

            resetaForm();
        }

        private void voltarAoMenuTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunosTurmaForm.instance.Focus();
            this.Close();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void listBox_singleClick(object sender, EventArgs e)
        {
            modoEdicao();

            Nota nota = listBox.SelectedItem as Nota;

            comboBoxDisciplina.SelectedItem = Program.GetState().disciplinas.GetPorId(nota.getDisciplinaId());
            textBoxNota.Text = nota.getNota().ToString();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                adicionar(sender, e);
                return;
            }

            editar(sender, e);
        }

        private void adicionar(object sender, EventArgs e)
        {
            try
            {
                Nota nota = new Nota();

                int alunoId = int.Parse(textBoxIdAluno.Text);
                int disciplinaId = (comboBoxDisciplina.SelectedItem as Disciplina).getId();
                double valorNota = double.Parse(textBoxNota.Text);

                nota.setAlunoId(alunoId);
                nota.setDisciplinaId(disciplinaId);
                nota.setNota(valorNota);

                listBox.Items.Add(nota);

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editar(object sender, EventArgs e)
        {
            try
            {
                Nota nota = listBox.SelectedItem as Nota;

                nota.setNota(double.Parse(textBoxNota.Text));

                listBox.Items[listBox.SelectedIndex] = nota;

                resetaForm();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetaForm()
        {
            comboBoxDisciplina.SelectedItem = null;
            comboBoxDisciplina.SelectedText = "--Selecione--";

            buttonSalvar.Enabled = false;
            textBoxNota.Clear();
        }

        protected void modoEdicao()
        {
            buttonRemover.Enabled = true;
            buttonSalvar.Text = $"Editar {getNomeEntidade()}";
        }

        private void comboBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSalvar.Enabled = comboBoxDisciplina.SelectedItem != null;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            resetaForm();
        }
    }
}
