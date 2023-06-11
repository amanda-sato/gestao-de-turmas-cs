using System;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class DisciplinasForm : Form
    {
        public DisciplinasForm()
        {
            InitializeComponent();
            init();

            carregaEntidade();
            resetaForm();
        }

        public void init()
        {
            Text = $"Menu {getNomeEntidade()}";

            labelID.Text = "ID";
            labelNome.Text = $"Nome {getNomeEntidade()}";
            labelList.Text = $"{getNomeEntidadePlural()} Disponiveis";

            buttonSalvar.Text = $"Adicionar {getNomeEntidade()}";
            buttonRemover.Text = $"Remover {getNomeEntidade()}";
        }


        public string getNomeEntidade()
        {
            return "Disciplina";
        }

        public string getNomeEntidadePlural()
        {
            return "Disciplinas";
        }


        protected void carregaEntidade()
        {
            foreach (Disciplina d in Program.GetState().disciplinas)
            {
                listBox.Items.Add(d);
            }
        }

        protected void voltarAoMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void encerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                salvar(sender, e);
                return;
            }

            editar(sender, e);
        }

        protected void salvar(object sender, EventArgs e)
        {
            try
            {
                Disciplina novaDisciplina = new Disciplina();

                string nomeDisc = textBoxNome.Text;

                novaDisciplina.setNomeDisc(nomeDisc);

                Program.GetState().disciplinas.Add(novaDisciplina);
                listBox.Items.Add(novaDisciplina);

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void editar(object sender, EventArgs e)
        {
            try
            {
                Disciplina selectedDisciplina = listBox.SelectedItem as Disciplina;

                selectedDisciplina.setNomeDisc(textBoxNome.Text);
                Program.GetState().disciplinas.Atualizar(selectedDisciplina);

                listBox.Items[listBox.SelectedIndex] = selectedDisciplina;

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void listBox_SingleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            modoEdicao();

            Disciplina selectedDisciplina = listBox.SelectedItem as Disciplina;

            textBoxId.Text = selectedDisciplina.getId().ToString();
            textBoxNome.Text = selectedDisciplina.getNomeDisc();
        }

        protected void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma disciplina!");
                return;
            }
            
            Disciplina selectedDisciplina = listBox.SelectedItem as Disciplina;

            Program.GetState().disciplinas.Remove(selectedDisciplina);
            listBox.Items.Remove(selectedDisciplina);

            resetaForm();
        }

        protected void buttonLimpar_Click(object sender, EventArgs e)
        {
            resetaForm();
        }

        protected void resetaForm()
        {
            textBoxId.Text = Program.GetState().disciplinas.getNextId().ToString();
            textBoxNome.Clear();

            listBox.ClearSelected();

            buttonSalvar.Text = $"Adicionar {getNomeEntidade()}";
            buttonRemover.Enabled = false;
        }

        protected void modoEdicao()
        {
            buttonRemover.Enabled = true;
            buttonSalvar.Text = $"Editar {getNomeEntidade()}";
        }
    }
}
