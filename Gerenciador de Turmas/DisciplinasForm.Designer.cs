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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(466, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adicionar Disciplina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Remover Disciplina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(427, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Editar Disciplina";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 399);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDisciplinas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Menu Disciplinas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDisciplinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}