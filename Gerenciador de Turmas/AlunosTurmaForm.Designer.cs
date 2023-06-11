namespace Gerenciador_de_Turmas
{
    partial class AlunosTurmaForm
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
            this.voltarAoMenuTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelAlunos = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.textBoxIdTurma = new System.Windows.Forms.TextBox();
            this.labelTurma = new System.Windows.Forms.Label();
            this.textBoxTurma = new System.Windows.Forms.TextBox();
            this.labelIdTurma = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarAoMenuTurmasToolStripMenuItem,
            this.fecharProgramaToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // voltarAoMenuTurmasToolStripMenuItem
            // 
            this.voltarAoMenuTurmasToolStripMenuItem.Name = "voltarAoMenuTurmasToolStripMenuItem";
            this.voltarAoMenuTurmasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.voltarAoMenuTurmasToolStripMenuItem.Text = "Voltar ao Menu Turmas";
            this.voltarAoMenuTurmasToolStripMenuItem.Click += new System.EventHandler(this.voltarAoMenuTurmasToolStripMenuItem_Click);
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar Programa";
            this.fecharProgramaToolStripMenuItem.Click += new System.EventHandler(this.fecharProgramaToolStripMenuItem_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(31, 86);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(277, 316);
            this.listBox.TabIndex = 1;
            this.listBox.Click += new System.EventHandler(this.listAlunos_singleClick);
            this.listBox.DoubleClick += new System.EventHandler(this.listAlunos_DoubleClick);
            // 
            // labelAlunos
            // 
            this.labelAlunos.AutoSize = true;
            this.labelAlunos.Location = new System.Drawing.Point(43, 60);
            this.labelAlunos.Name = "labelAlunos";
            this.labelAlunos.Size = new System.Drawing.Size(42, 13);
            this.labelAlunos.TabIndex = 2;
            this.labelAlunos.Text = "Alunos:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(355, 198);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 13);
            this.labelGenero.TabIndex = 3;
            this.labelGenero.Text = "Gênero:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(355, 139);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(355, 86);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(55, 13);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "Matrícula:";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(439, 82);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(139, 20);
            this.textBoxId.TabIndex = 6;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(439, 132);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(139, 20);
            this.textBoxNome.TabIndex = 8;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(433, 238);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(145, 29);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Adicionar Aluno";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(433, 312);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(144, 35);
            this.buttonRemover.TabIndex = 10;
            this.buttonRemover.Text = "Remover Aluno";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // textBoxIdTurma
            // 
            this.textBoxIdTurma.Enabled = false;
            this.textBoxIdTurma.Location = new System.Drawing.Point(70, 27);
            this.textBoxIdTurma.Name = "textBoxIdTurma";
            this.textBoxIdTurma.Size = new System.Drawing.Size(53, 20);
            this.textBoxIdTurma.TabIndex = 11;
            // 
            // labelTurma
            // 
            this.labelTurma.AutoSize = true;
            this.labelTurma.Location = new System.Drawing.Point(139, 30);
            this.labelTurma.Name = "labelTurma";
            this.labelTurma.Size = new System.Drawing.Size(40, 13);
            this.labelTurma.TabIndex = 12;
            this.labelTurma.Text = "Turma:";
            // 
            // textBoxTurma
            // 
            this.textBoxTurma.Enabled = false;
            this.textBoxTurma.Location = new System.Drawing.Point(185, 27);
            this.textBoxTurma.Name = "textBoxTurma";
            this.textBoxTurma.Size = new System.Drawing.Size(392, 20);
            this.textBoxTurma.TabIndex = 13;
            // 
            // labelIdTurma
            // 
            this.labelIdTurma.AutoSize = true;
            this.labelIdTurma.Location = new System.Drawing.Point(43, 30);
            this.labelIdTurma.Name = "labelIdTurma";
            this.labelIdTurma.Size = new System.Drawing.Size(21, 13);
            this.labelIdTurma.TabIndex = 14;
            this.labelIdTurma.Text = "ID:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(433, 277);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(145, 29);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBoxGenero.Location = new System.Drawing.Point(439, 195);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(138, 21);
            this.comboBoxGenero.TabIndex = 15;
            // 
            // AlunosTurmaForm
            // 
            this.AcceptButton = this.buttonSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 428);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.labelIdTurma);
            this.Controls.Add(this.textBoxTurma);
            this.Controls.Add(this.labelTurma);
            this.Controls.Add(this.textBoxIdTurma);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelAlunos);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AlunosTurmaForm";
            this.Text = "Menu Turma";
            this.Click += new System.EventHandler(this.buttonLimpar_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharProgramaToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelAlunos;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonRemover;
        public System.Windows.Forms.TextBox textBoxIdTurma;
        private System.Windows.Forms.Label labelTurma;
        public System.Windows.Forms.TextBox textBoxTurma;
        private System.Windows.Forms.Label labelIdTurma;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ComboBox comboBoxGenero;
    }
}