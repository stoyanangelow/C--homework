using System;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Serialization;

namespace ComputerStore
{
    public partial class Configurator : Form
    {
        public event EventHandler Click;
        public Configurator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void saveButton_Click(object sender, System.EventArgs e)
        {
            StreamWriter sw = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        public class Values
        {
            public string motherboard { get; set; }
            public string cpu { get; set; }
            public string ram { get; set; }
            public string ssd { get; set; }
            public string gpu { get; set; }
            public string name { get; set; }
        }

        void exportButton_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveExport = new SaveFileDialog();
            Values v = new Values();
            v.motherboard = this.motherboard.Text;
            v.cpu = this.cpu.Text;
            v.ram= this.ram.Text;
            v.gpu = this.gpu.Text;
            v.name = this.name.Text;
            SaveValues(v);
        }

        public void SaveValues(Values v)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Values));
            using (TextWriter textWriter = new StreamWriter(@"C:\TheFileYouWantToStore.xml")) ;
            
        }



    }

 
}
