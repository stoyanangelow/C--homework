using System;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class Main : Form
    {
        public event EventHandler Click;

        Configurator configurator = new Configurator();
        AddComponent addComponent = new AddComponent();
        List list = new List();

        public Main()
        {
            InitializeComponent();

            void buttonConfigurator_Click(object sender, System.EventArgs e)
            {
                configurator.Show();
                this.Hide();
            }

            buttonConfigurator.Click += new EventHandler(buttonConfigurator_Click);

            void buttonAdd_Click(object sender, System.EventArgs e)
            {
                addComponent.Show();
                this.Hide();
            }

            addButton.Click += new EventHandler(buttonAdd_Click);

            void buttonList_Click(object sender, System.EventArgs e)
            {
                list.Show();
                this.Hide();
            }

            listButton.Click += new EventHandler(buttonList_Click);
        }

    }




}
