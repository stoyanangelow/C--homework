namespace ComputerStore
{
    partial class Main
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
            this.buttonConfigurator = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConfigurator
            // 
            this.buttonConfigurator.Location = new System.Drawing.Point(330, 142);
            this.buttonConfigurator.Name = "buttonConfigurator";
            this.buttonConfigurator.Size = new System.Drawing.Size(120, 23);
            this.buttonConfigurator.TabIndex = 0;
            this.buttonConfigurator.Text = "Computer configurator";
            this.buttonConfigurator.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(330, 171);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add a component";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(330, 200);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(120, 24);
            this.listButton.TabIndex = 2;
            this.listButton.Text = "List of components";
            this.listButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.buttonConfigurator);
            this.Name = "Main";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfigurator;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button listButton;
    }
}