using EstruturasBase;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class DisciplinasForm : BaseForm
    {
        public static DisciplinasForm instance;

        public DisciplinasForm() : base(MainForm.instance)
        {
            instance = this;
            carregaEntidade();
            resetaForm();
        }

        public override string getNomeEntidade()
        {
            return "Disciplina";
        }

        public override string getNomeEntidadePlural()
        {
            return "Disciplinas";
        }


        protected override void carregaEntidade()
        {
            foreach (Disciplina d in MainForm.instance.state.disciplinas)
            {
                listBox.Items.Add(d);
            }
        }

        protected override void salvar(Object sender, EventArgs e)
        {
            try
            {
                Disciplina novaDisciplina = new Disciplina();

                int id = int.Parse(textBoxId.Text);
                string nomeDisc = textBoxNome.Text;

                novaDisciplina.setId(id);
                novaDisciplina.setNomeDisc(nomeDisc);

                MainForm.instance.state.disciplinas.Add(novaDisciplina);
                listBox.Items.Add(novaDisciplina);

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void editar(object sender, EventArgs e)
        {
            try
            {
                Disciplina selectedDisciplina = listBox.SelectedItem as Disciplina;

                selectedDisciplina.setNomeDisc(textBoxNome.Text);
                MainForm.instance.state.disciplinas.Atualizar(selectedDisciplina);

                listBox.Items[listBox.SelectedIndex] = selectedDisciplina;

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void listBox_SingleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            modoEdicao();

            Disciplina selectedDisciplina = listBox.SelectedItem as Disciplina;

            textBoxId.Text = selectedDisciplina.getId().ToString();
            textBoxNome.Text = selectedDisciplina.getNomeDisc();
        }

        protected override void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma disciplina!");
                return;
            }
            
            Disciplina selectedDisciplina = listBox.SelectedItem as Disciplina;

            MainForm.instance.state.disciplinas.Remove(selectedDisciplina);
            listBox.Items.Remove(selectedDisciplina);

            resetaForm();
        }

        protected override void resetaForm()
        {
            textBoxId.Text = Disciplina.getNextId().ToString();
            textBoxNome.Clear();

            base.resetaForm();
        }
    }
}
