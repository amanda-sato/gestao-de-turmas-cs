namespace Gerenciador_de_Turmas
{
    partial class DisciplinasForm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarAoMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxIdDisciplina = new System.Windows.Forms.TextBox();
            this.textBoxNomeDaDisciplina = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(43, 84);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(232, 290);
            this.listBox.TabIndex = 0;
            this.listBox.Click += new System.EventHandler(this.listBox_SingleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disciplinas Disponíveis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarAoMenuPrincipalToolStripMenuItem,
            this.encerrarProgramaToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // voltarAoMenuPrincipalToolStripMenuItem
            // 
            this.voltarAoMenuPrincipalToolStripMenuItem.Name = "voltarAoMenuPrincipalToolStripMenuItem";
            this.voltarAoMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.voltarAoMenuPrincipalToolStripMenuItem.Text = "Voltar ao Menu Principal";
            this.voltarAoMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.voltarAoMenuPrincipalToolStripMenuItem_Click);
            // 
            // encerrarProgramaToolStripMenuItem
            // 
            this.encerrarProgramaToolStripMenuItem.Name = "encerrarProgramaToolStripMenuItem";
            this.encerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.encerrarProgramaToolStripMenuItem.Text = "Encerrar Programa";
            this.encerrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.encerrarProgramaToolStripMenuItem_Click);
            // 
            // textBoxIdDisciplina
            // 
            this.textBoxIdDisciplina.Enabled = false;
            this.textBoxIdDisciplina.Location = new System.Drawing.Point(386, 64);
            this.textBoxIdDisciplina.Name = "textBoxIdDisciplina";
            this.textBoxIdDisciplina.Size = new System.Drawing.Size(134, 20);
            this.textBoxIdDisciplina.TabIndex = 5;
            // 
            // textBoxNomeDaDisciplina
            // 
            this.textBoxNomeDaDisciplina.Location = new System.Drawing.Point(466, 123);
            this.textBoxNomeDaDisciplina.Name = "textBoxNomeDaDisciplina";
            this.textBoxNomeDaDisciplina.Size = new System.Drawing.Size(134, 20);
            this.textBoxNomeDaDisciplina.TabIndex = 6;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(427, 175);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(135, 39);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Adicionar Disciplina";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRemover.Enabled = false;
            this.buttonRemover.Location = new System.Drawing.Point(428, 220);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(135, 35);
            this.buttonRemover.TabIndex = 8;
            this.buttonRemover.Text = "Remover Disciplina";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(428, 261);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(134, 34);
            this.buttonLimpar.TabIndex = 10;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // DisciplinasForm
            // 
            this.AcceptButton = this.buttonSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonLimpar;
            this.ClientSize = new System.Drawing.Size(649, 399);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxNomeDaDisciplina);
            this.Controls.Add(this.textBoxIdDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DisciplinasForm";
            this.Text = "Menu Disciplinas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxIdDisciplina;
        private System.Windows.Forms.TextBox textBoxNomeDaDisciplina;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonLimpar;
    }
}