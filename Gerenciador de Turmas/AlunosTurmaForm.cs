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
    
    public partial class AlunosTurmaForm : Form
    {
        public static AlunosTurmaForm instance;
        public AlunosTurmaForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void voltarAoMenuTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurmasForm.instance.Focus();
            this.Close();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno1 = new Aluno();

                int matricula = int.Parse(textBox1.Text);
                string nomeAluno = textBox2.Text;
                string genero = textBox3.Text;

                aluno1.setMatricula(matricula);
                aluno1.setNomeAluno(nomeAluno);
                aluno1.setGenero(genero);

                listAlunos.Items.Add(aluno1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listAlunos_DoubleClick(object sender, EventArgs e)
        {
            if (listAlunos.SelectedItems != null)
            {
                NotasAlunoForm form = new NotasAlunoForm();
                form.Show();

                if (listAlunos.SelectedItem != null)
                {
                    Aluno selectedDisciplina = listAlunos.SelectedItem as Aluno;

                    NotasAlunoForm.instance.textBox3.Text = selectedDisciplina.getMatricula().ToString();
                    NotasAlunoForm.instance.textBox1.Text = selectedDisciplina.getNomeAluno();
                    
                }
            }

        }


        private void listAlunos_singleClick(object sender, EventArgs e)
        {
            if (listAlunos.SelectedItem != null)
            {
                Aluno selectedDisciplina = listAlunos.SelectedItem as Aluno;

                textBox1.Text = selectedDisciplina.getMatricula().ToString();
                textBox2.Text = selectedDisciplina.getNomeAluno();
                textBox3.Text = selectedDisciplina.getGenero();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listAlunos.SelectedItem != null)
            {
                Aluno selectedDisciplina = listAlunos.SelectedItem as Aluno;

                listAlunos.Items.Remove(selectedDisciplina);
            }
            else
            {
                MessageBox.Show("Selecione uma disciplina!");
            }

        }
    }
}
