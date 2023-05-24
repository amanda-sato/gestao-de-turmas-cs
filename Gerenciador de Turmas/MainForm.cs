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
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public State state;

        public MainForm()
        {
            InitializeComponent();
            instance = this;

            state = new State();

            state.disciplinas.Add(new Disciplina(id: 1, nomeDisc: "Matemática"));
            state.disciplinas.Add(new Disciplina(id: 2, nomeDisc: "Programação"));
            state.disciplinas.Add(new Disciplina(id: 3, nomeDisc: "Biologia"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurmasForm form = new TurmasForm();
            form.Show();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisciplinasForm form = new DisciplinasForm();
            form.Show();
        }
    }
}
