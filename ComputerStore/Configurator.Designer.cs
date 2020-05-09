namespace ComputerStore
{
    partial class Configurator
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
            this.motherboard = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ssd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // motherboard
            // 
            this.motherboard.FormattingEnabled = true;
            this.motherboard.Location = new System.Drawing.Point(252, 164);
            this.motherboard.Name = "motherboard";
            this.motherboard.Size = new System.Drawing.Size(121, 21);
            this.motherboard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motherboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPU";
            // 
            // cpu
            // 
            this.cpu.FormattingEnabled = true;
            this.cpu.Location = new System.Drawing.Point(252, 204);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(121, 21);
            this.cpu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RAM";
            // 
            // ram
            // 
            this.ram.FormattingEnabled = true;
            this.ram.Location = new System.Drawing.Point(252, 244);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(121, 21);
            this.ram.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SSD";
            // 
            // ssd
            // 
            this.ssd.FormattingEnabled = true;
            this.ssd.Location = new System.Drawing.Point(252, 285);
            this.ssd.Name = "ssd";
            this.ssd.Size = new System.Drawing.Size(121, 21);
            this.ssd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "GPU";
            // 
            // gpu
            // 
            this.gpu.FormattingEnabled = true;
            this.gpu.Location = new System.Drawing.Point(252, 325);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(121, 21);
            this.gpu.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(252, 401);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 24);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save configuration";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name (optional)";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(252, 431);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(121, 24);
            this.exportButton.TabIndex = 13;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(252, 365);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(118, 20);
            this.name.TabIndex = 14;
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 664);
            this.Controls.Add(this.name);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gpu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ssd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motherboard);
            this.Name = "Configurator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox motherboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cpu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ssd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gpu;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox name;
    }
}

