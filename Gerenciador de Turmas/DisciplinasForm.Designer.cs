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
            this.listDisciplinas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarAoMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxIdDisciplina = new System.Windows.Forms.TextBox();
            this.textBoxNomeDaDisciplina = new System.Windows.Forms.TextBox();
            this.buttonAddDisciplina = new System.Windows.Forms.Button();
            this.buttonRemoverDisciplina = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDisciplinas
            // 
            this.listDisciplinas.FormattingEnabled = true;
            this.listDisciplinas.Location = new System.Drawing.Point(43, 84);
            this.listDisciplinas.Name = "listDisciplinas";
            this.listDisciplinas.Size = new System.Drawing.Size(232, 290);
            this.listDisciplinas.TabIndex = 0;
            this.listDisciplinas.Click += new System.EventHandler(this.listAlunos_singleClick);
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
            // buttonAddDisciplina
            // 
            this.buttonAddDisciplina.Location = new System.Drawing.Point(427, 175);
            this.buttonAddDisciplina.Name = "buttonAddDisciplina";
            this.buttonAddDisciplina.Size = new System.Drawing.Size(135, 39);
            this.buttonAddDisciplina.TabIndex = 7;
            this.buttonAddDisciplina.Text = "Adicionar Disciplina";
            this.buttonAddDisciplina.UseVisualStyleBackColor = true;
            this.buttonAddDisciplina.Click += new System.EventHandler(this.buttonAddDisciplina_Click);
            // 
            // buttonRemoverDisciplina
            // 
            this.buttonRemoverDisciplina.Location = new System.Drawing.Point(427, 235);
            this.buttonRemoverDisciplina.Name = "buttonRemoverDisciplina";
            this.buttonRemoverDisciplina.Size = new System.Drawing.Size(135, 35);
            this.buttonRemoverDisciplina.TabIndex = 8;
            this.buttonRemoverDisciplina.Text = "Remover Disciplina";
            this.buttonRemoverDisciplina.UseVisualStyleBackColor = true;
            this.buttonRemoverDisciplina.Click += new System.EventHandler(this.buttonRemoverDisciplina_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(427, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Editar Disciplina";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonEditarDisciplina_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisciplinasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonRemoverDisciplina);
            this.Controls.Add(this.buttonAddDisciplina);
            this.Controls.Add(this.textBoxNomeDaDisciplina);
            this.Controls.Add(this.textBoxIdDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDisciplinas);
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

        public System.Windows.Forms.ListBox listDisciplinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxIdDisciplina;
        private System.Windows.Forms.TextBox textBoxNomeDaDisciplina;
        private System.Windows.Forms.Button buttonAddDisciplina;
        private System.Windows.Forms.Button buttonRemoverDisciplina;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}