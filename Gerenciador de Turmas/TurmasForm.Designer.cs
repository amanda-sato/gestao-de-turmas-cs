namespace Gerenciador_de_Turmas
{
    partial class TurmasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelList = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarAoMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
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
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(55, 38);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(92, 13);
            this.labelList.TabIndex = 1;
            this.labelList.Text = "Itens Disponíveis:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(341, 123);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(341, 67);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID:";
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
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(386, 64);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(134, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(466, 123);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(134, 20);
            this.textBoxNome.TabIndex = 6;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(427, 175);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(135, 39);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Adicionar";
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
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLimpar.Location = new System.Drawing.Point(428, 261);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(134, 34);
            this.buttonLimpar.TabIndex = 10;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // BaseForm
            // 
            this.AcceptButton = this.buttonSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonLimpar;
            this.ClientSize = new System.Drawing.Size(649, 399);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox;
        protected System.Windows.Forms.Label labelList;
        protected System.Windows.Forms.Label labelNome;
        protected System.Windows.Forms.Label labelID;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem voltarAoMenuPrincipalToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem encerrarProgramaToolStripMenuItem;
        protected System.Windows.Forms.TextBox textBoxId;
        protected System.Windows.Forms.TextBox textBoxNome;
        protected System.Windows.Forms.Button buttonSalvar;
        protected System.Windows.Forms.Button buttonRemover;
        protected System.Windows.Forms.Button buttonLimpar;
    }
}