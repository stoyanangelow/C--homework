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
            
            Values v = new Values();
            v.motherboard = this.motherboard.Text;
            v.cpu = this.cpu.Text;
            v.ram = this.ram.Text;
            v.gpu = this.gpu.Text;
            v.name = this.name.Text;
            SaveValues(v);
        }

        public void SaveValues(Values v)
        {
            DateTime now = DateTime.Now;
           
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
 
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
 
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
 
            worksheet.Name = "Computer configuration";

            worksheet.Cells[1, 1] = "Motherboard";
            worksheet.Cells[1, 2] = "CPU";
            worksheet.Cells[1, 3] = "RAM";
            worksheet.Cells[1, 4] = "GPU";
            worksheet.Cells[1, 5] = "Name";

            worksheet.Cells[2, 1] = v.motherboard;
            worksheet.Cells[2, 2] = v.cpu;
            worksheet.Cells[2, 3] = v.ram;
            worksheet.Cells[2, 4] = v.gpu;
            worksheet.Cells[2, 5] = v.name;
            workbook.SaveAs("C:\\test\\Configuration.xls");
            app.Quit();

            Success success = new Success();
            success.Show();

        }



    }

 
}
