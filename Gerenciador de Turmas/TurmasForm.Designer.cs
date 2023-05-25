﻿namespace Gerenciador_de_Turmas
{
    partial class TurmasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarAoMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relaçãoDeAlunosAprovadosEReprovadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaGeralPorAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxaDeAprovaçãoPorDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listTurmas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarAoMenuPrincipalToolStripMenuItem,
            this.fecharProgramaToolStripMenuItem,
            this.relaçãoDeAlunosAprovadosEReprovadosToolStripMenuItem,
            this.médiaGeralPorAlunoToolStripMenuItem,
            this.taxaDeAprovaçãoPorDisciplinaToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // voltarAoMenuPrincipalToolStripMenuItem
            // 
            this.voltarAoMenuPrincipalToolStripMenuItem.Name = "voltarAoMenuPrincipalToolStripMenuItem";
            this.voltarAoMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.voltarAoMenuPrincipalToolStripMenuItem.Text = "Voltar ao Menu Principal";
            this.voltarAoMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.voltarAoMenuPrincipalToolStripMenuItem_Click);
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar Programa";
            this.fecharProgramaToolStripMenuItem.Click += new System.EventHandler(this.fecharProgramaToolStripMenuItem_Click);
            // 
            // relaçãoDeAlunosAprovadosEReprovadosToolStripMenuItem
            // 
            this.relaçãoDeAlunosAprovadosEReprovadosToolStripMenuItem.Name = "relaçãoDeAlunosAprovadosEReprovadosToolStripMenuItem";
            this.relaçãoDeAlunosAprovadosEReprovadosToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.relaçãoDeAlunosAprovadosEReprovadosToolStripMenuItem.Text = "Relação de alunos aprovados e reprovados";
            // 
            // médiaGeralPorAlunoToolStripMenuItem
            // 
            this.médiaGeralPorAlunoToolStripMenuItem.Name = "médiaGeralPorAlunoToolStripMenuItem";
            this.médiaGeralPorAlunoToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.médiaGeralPorAlunoToolStripMenuItem.Text = "Média geral por aluno";
            // 
            // taxaDeAprovaçãoPorDisciplinaToolStripMenuItem
            // 
            this.taxaDeAprovaçãoPorDisciplinaToolStripMenuItem.Name = "taxaDeAprovaçãoPorDisciplinaToolStripMenuItem";
            this.taxaDeAprovaçãoPorDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.taxaDeAprovaçãoPorDisciplinaToolStripMenuItem.Text = "Taxa de aprovação por disciplina";
            // 
            // listTurmas
            // 
            this.listTurmas.FormattingEnabled = true;
            this.listTurmas.Location = new System.Drawing.Point(33, 84);
            this.listTurmas.Name = "listTurmas";
            this.listTurmas.Size = new System.Drawing.Size(274, 316);
            this.listTurmas.TabIndex = 1;
            this.listTurmas.Click += new System.EventHandler(this.listTurmas_singleClick);
            this.listTurmas.SelectedIndexChanged += new System.EventHandler(this.listTurmas_SelectedIndexChanged);
            this.listTurmas.DoubleClick += new System.EventHandler(this.listTurmas_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turmas Disponíveis:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(410, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Adicionar Turma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 22);
            this.button2.TabIndex = 11;
            this.button2.Text = "Excluir Turma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 22);
            this.button3.TabIndex = 12;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(411, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 22);
            this.button4.TabIndex = 13;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TurmasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 416);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTurmas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TurmasForm";
            this.Text = "Menu Turmas";
            this.DoubleClick += new System.EventHandler(this.listTurmas_DoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharProgramaToolStripMenuItem;
        private System.Windows.Forms.ListBox listTurmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem relaçãoDeAlunosAprovadosEReprovadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaGeralPorAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxaDeAprovaçãoPorDisciplinaToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}