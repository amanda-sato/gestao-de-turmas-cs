using System;
using System.Windows.Forms;

namespace BaseLibrary
{
    public partial class BaseForm : Form
    {
        public static BaseForm? instance;
        public Form? mainForm;


        public BaseForm(Form? mainForm = null)
        {
            InitializeComponent();
            instance = this;

            Text = $"Menu {getNomeEntidade()}";

            labelID.Text = "ID";
            labelNome.Text = $"Nome {getNomeEntidade()}";
            labelList.Text = $"{getNomeEntidadePlural()} Disponiveis";

            buttonSalvar.Text = $"Adicionar {getNomeEntidade()}";
            buttonRemover.Text = $"Remover {getNomeEntidade()}";

            if ( mainForm != null )
            {
                this.mainForm = mainForm;
            }
        }
        
        public virtual string getNomeEntidade()
        {
            return "";
        }

        public virtual string getNomeEntidadePlural()
        {
            return "";
        }

        protected virtual void carregaEntidade()
        {
            throw new NotImplementedException("Voce deve implementar o metodo carregaEntidade");
        }

        protected virtual void salvar(object sender, EventArgs e)
        {
            throw new NotImplementedException("Voce deve implementar o metodo salvar");

        }

        protected virtual void editar(object sender, EventArgs e)
        {
            throw new NotImplementedException("Voce deve implementar o metodo editar");

        }

        protected virtual void listBox_SingleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException("Voce deve implementar o metodo listBox_SingleClick");

        }

        protected virtual void buttonRemover_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Voce deve implementar o metodo buttonRemover_Click");
        }


        protected void voltarAoMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (mainForm != null)
            {
                mainForm.Focus();
            }

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

        protected void buttonLimpar_Click(object sender, EventArgs e)
        {
            resetaForm();
        }

        protected virtual void resetaForm()
        {
            listBox.ClearSelected();

            buttonSalvar.Text = $"Adicionar {getNomeEntidade()}";
            buttonRemover.Enabled = false;
        }

        protected virtual void modoEdicao()
        {
            buttonRemover.Enabled = true;
            buttonSalvar.Text = $"Editar {getNomeEntidade()}";
        }
    }
}
