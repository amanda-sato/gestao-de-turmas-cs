﻿using System;
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
        public NotasAlunoForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void voltarAoMenuTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunosTurmaForm.instance.Focus();
            this.Close();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void listNotas_singleClick(object sender, EventArgs e)
        {
            if (listNotas.SelectedItem != null)
            {
               // Aluno selectedAluno = listNotas.SelectedItem as Aluno;

                //textBox5.Text = selectedAluno.get().ToString();
               // textBox6.Text = selectedAluno.getNomeDisc();
            }
        }

        private void notas_Enter(object sender, EventArgs e)
        {
            foreach (Disciplina d in DisciplinasForm.instance.listDisciplinas.Items)
            {
                MessageBox.Show(d.ToString());
            }
        }
    }
}
