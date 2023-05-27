﻿using EstruturasBase;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class DisciplinasForm : Form
    {
        public static DisciplinasForm instance;

        public DisciplinasForm()
        {
            InitializeComponent();
            init();

            instance = this;
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
            foreach (Disciplina d in MainForm.instance.state.disciplinas)
            {
                listBox.Items.Add(d);
            }
        }

        protected void voltarAoMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.instance.Focus();
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

        protected void salvar(Object sender, EventArgs e)
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

        protected void editar(object sender, EventArgs e)
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

            MainForm.instance.state.disciplinas.Remove(selectedDisciplina);
            listBox.Items.Remove(selectedDisciplina);

            resetaForm();
        }

        protected void buttonLimpar_Click(object sender, EventArgs e)
        {
            resetaForm();
        }

        protected void resetaForm()
        {
            textBoxId.Text = Disciplina.getNextId().ToString();
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
