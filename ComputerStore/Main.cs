using System;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class Main : Form
    {
        public event EventHandler Click;

        Configurator configurator = new Configurator();
        public Main()
        {
            InitializeComponent();

            void button1_Click(object sender, System.EventArgs e)
            {
                configurator.Show();
                this.Hide();
            }

            buttonConfigurator.Click += new EventHandler(button1_Click);
        }

    }

       

       
}
