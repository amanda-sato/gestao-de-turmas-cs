namespace Gerenciador_de_Turmas
{
    partial class NotasAlunoForm
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
            this.voltarAoMenuTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNomeAluno = new System.Windows.Forms.Label();
            this.labelIdAluno = new System.Windows.Forms.Label();
            this.labelMediaNotas = new System.Windows.Forms.Label();
            this.textBoxNomeAluno = new System.Windows.Forms.TextBox();
            this.textBoxMediaNotas = new System.Windows.Forms.TextBox();
            this.textBoxIdAluno = new System.Windows.Forms.TextBox();
            this.labelListBox = new System.Windows.Forms.Label();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.listBoxDisc = new System.Windows.Forms.ListBox();
            this.labelDisciplinas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarAoMenuTurmaToolStripMenuItem,
            this.fecharProgramaToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // voltarAoMenuTurmaToolStripMenuItem
            // 
            this.voltarAoMenuTurmaToolStripMenuItem.Name = "voltarAoMenuTurmaToolStripMenuItem";
            this.voltarAoMenuTurmaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.voltarAoMenuTurmaToolStripMenuItem.Text = "Voltar ao Menu Turma";
            this.voltarAoMenuTurmaToolStripMenuItem.Click += new System.EventHandler(this.voltarAoMenuTurmaToolStripMenuItem_Click);
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar Programa";
            this.fecharProgramaToolStripMenuItem.Click += new System.EventHandler(this.fecharProgramaToolStripMenuItem_Click);
            // 
            // labelNomeAluno
            // 
            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Location = new System.Drawing.Point(540, 70);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(83, 13);
            this.labelNomeAluno.TabIndex = 2;
            this.labelNomeAluno.Text = "Nome do Aluno:";
            // 
            // labelIdAluno
            // 
            this.labelIdAluno.AutoSize = true;
            this.labelIdAluno.Location = new System.Drawing.Point(540, 98);
            this.labelIdAluno.Name = "labelIdAluno";
            this.labelIdAluno.Size = new System.Drawing.Size(55, 13);
            this.labelIdAluno.TabIndex = 3;
            this.labelIdAluno.Text = "Matrícula:";
            // 
            // labelMediaNotas
            // 
            this.labelMediaNotas.AutoSize = true;
            this.labelMediaNotas.Location = new System.Drawing.Point(540, 129);
            this.labelMediaNotas.Name = "labelMediaNotas";
            this.labelMediaNotas.Size = new System.Drawing.Size(90, 13);
            this.labelMediaNotas.TabIndex = 4;
            this.labelMediaNotas.Text = "Média das Notas:";
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.Enabled = false;
            this.textBoxNomeAluno.Location = new System.Drawing.Point(654, 70);
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(167, 20);
            this.textBoxNomeAluno.TabIndex = 5;
            // 
            // textBoxMediaNotas
            // 
            this.textBoxMediaNotas.Enabled = false;
            this.textBoxMediaNotas.Location = new System.Drawing.Point(654, 129);
            this.textBoxMediaNotas.Name = "textBoxMediaNotas";
            this.textBoxMediaNotas.Size = new System.Drawing.Size(167, 20);
            this.textBoxMediaNotas.TabIndex = 6;
            // 
            // textBoxIdAluno
            // 
            this.textBoxIdAluno.Enabled = false;
            this.textBoxIdAluno.Location = new System.Drawing.Point(654, 98);
            this.textBoxIdAluno.Name = "textBoxIdAluno";
            this.textBoxIdAluno.Size = new System.Drawing.Size(167, 20);
            this.textBoxIdAluno.TabIndex = 7;
            // 
            // labelListBox
            // 
            this.labelListBox.AutoSize = true;
            this.labelListBox.Location = new System.Drawing.Point(264, 54);
            this.labelListBox.Name = "labelListBox";
            this.labelListBox.Size = new System.Drawing.Size(159, 13);
            this.labelListBox.TabIndex = 8;
            this.labelListBox.Text = "Disciplinas cursadas pelo Aluno:";
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(639, 220);
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(182, 20);
            this.textBoxNota.TabIndex = 9;
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Location = new System.Drawing.Point(549, 203);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(52, 13);
            this.labelDisciplina.TabIndex = 11;
            this.labelDisciplina.Text = "Disciplina";
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(549, 227);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(30, 13);
            this.labelNota.TabIndex = 12;
            this.labelNota.Text = "Nota";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(639, 266);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 25);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Adicionar Nota";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(639, 297);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(100, 26);
            this.buttonRemover.TabIndex = 14;
            this.buttonRemover.Text = "Remover Nota";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(639, 193);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(182, 21);
            this.comboBoxDisciplina.TabIndex = 15;
            this.comboBoxDisciplina.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplina_SelectedIndexChanged);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(639, 329);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(100, 26);
            this.buttonLimpar.TabIndex = 14;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(267, 70);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(257, 317);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // listBoxDisc
            // 
            this.listBoxDisc.FormattingEnabled = true;
            this.listBoxDisc.Location = new System.Drawing.Point(34, 70);
            this.listBoxDisc.Name = "listBoxDisc";
            this.listBoxDisc.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxDisc.Size = new System.Drawing.Size(209, 316);
            this.listBoxDisc.TabIndex = 17;
            // 
            // labelDisciplinas
            // 
            this.labelDisciplinas.AutoSize = true;
            this.labelDisciplinas.Location = new System.Drawing.Point(34, 53);
            this.labelDisciplinas.Name = "labelDisciplinas";
            this.labelDisciplinas.Size = new System.Drawing.Size(57, 13);
            this.labelDisciplinas.TabIndex = 18;
            this.labelDisciplinas.Text = "Disciplinas";
            // 
            // NotasAlunoForm
            // 
            this.AcceptButton = this.buttonSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 409);
            this.Controls.Add(this.labelDisciplinas);
            this.Controls.Add(this.listBoxDisc);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.textBoxNota);
            this.Controls.Add(this.labelListBox);
            this.Controls.Add(this.textBoxIdAluno);
            this.Controls.Add(this.textBoxMediaNotas);
            this.Controls.Add(this.textBoxNomeAluno);
            this.Controls.Add(this.labelMediaNotas);
            this.Controls.Add(this.labelIdAluno);
            this.Controls.Add(this.labelNomeAluno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotasAlunoForm";
            this.Text = "Menu Notas";
            this.Load += new System.EventHandler(this.carregaEntidades);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharProgramaToolStripMenuItem;
        private System.Windows.Forms.Label labelNomeAluno;
        private System.Windows.Forms.Label labelIdAluno;
        private System.Windows.Forms.Label labelMediaNotas;
        public System.Windows.Forms.TextBox textBoxNomeAluno;
        public System.Windows.Forms.TextBox textBoxMediaNotas;
        public System.Windows.Forms.TextBox textBoxIdAluno;
        private System.Windows.Forms.Label labelListBox;
        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ListBox listBoxDisc;
        private System.Windows.Forms.Label labelDisciplinas;
    }
}