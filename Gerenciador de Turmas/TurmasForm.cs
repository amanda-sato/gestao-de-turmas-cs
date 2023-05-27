using EstruturasBase;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class TurmasForm : BaseForm
    {
        public static TurmasForm instance;
        public TurmasForm() : base(MainForm.instance)
        {
            InitializeComponent();
            instance = this;

            carregaEntidade();
            resetaForm();
        }

        public override string getNomeEntidade()
        {
            return "Turma";
        }

        public override string getNomeEntidadePlural()
        {
            return "Turmas";
        }

        protected override void carregaEntidade()
        {
            foreach (Turma t in MainForm.instance.state.turmas)
            {
                listBox.Items.Add(t);
            }
        }

        protected override void salvar(object sender, EventArgs e)
        {
            try
            {
                Turma novaTurma = new Turma();

                string nomeTurma = textBoxNome.Text;
                int id = int.Parse(textBoxId.Text);
                
                novaTurma.setId(id);
                novaTurma.setNomeTurma(nomeTurma);

                MainForm.instance.state.turmas.Add(novaTurma);
                listBox.Items.Add(novaTurma);

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void listTurmas_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItems !=  null)
            {
                AlunosTurmaForm form = new AlunosTurmaForm();
                form.Show();

                if (listBox.SelectedItem != null)
                {
                    Turma selectedDisciplina = listBox.SelectedItem as Turma;

                    AlunosTurmaForm.instance.textBox4.Text = selectedDisciplina.getId().ToString();
                    AlunosTurmaForm.instance.textBox5.Text = selectedDisciplina.getNomeTurma();
                }
            }
        }

        protected override void listBox_SingleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            modoEdicao();

            Turma selectedTurmas = listBox.SelectedItem as Turma;

            textBoxNome.Text = selectedTurmas.getNomeTurma();
            textBoxId.Text = selectedTurmas.getId().ToString();
        }

        protected override void editar(object sender, EventArgs e)
        {
            Turma selectedTurma = listBox.SelectedItem as Turma;

            selectedTurma.setNomeTurma(textBoxNome.Text);
            MainForm.instance.state.turmas.Atualizar(selectedTurma);

            listBox.Items[listBox.SelectedIndex] = selectedTurma;

            resetaForm();
        }

        protected override void buttonRemover_Click(object sender, EventArgs e)
        {
            Turma selectedTurmas = listBox.SelectedItem as Turma;

            MainForm.instance.state.turmas.Remove(selectedTurmas);

            listBox.Items.Remove(selectedTurmas);

            resetaForm();
        }

        protected override void resetaForm()
        {
            textBoxId.Text = Turma.getNextId().ToString();
            textBoxNome.Clear();

            base.resetaForm();
        }

        private new void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.DoubleClick += new System.EventHandler(this.listTurmas_DoubleClick);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(466, 64);
            // 
            // TurmasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(649, 399);
            this.Name = "TurmasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
