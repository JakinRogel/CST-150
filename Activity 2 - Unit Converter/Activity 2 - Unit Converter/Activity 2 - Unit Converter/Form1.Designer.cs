namespace Activity_2___Unit_Converter
{
    partial class unitConverterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unitConverterForm));
            this.converterButton = new System.Windows.Forms.Button();
            this.enterYourWeightOnEarth = new System.Windows.Forms.Label();
            this.yourWeightOnMars = new System.Windows.Forms.Label();
            this.inputYourWeightOnEarth = new System.Windows.Forms.TextBox();
            this.outputYourWeightOnMars = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // converterButton
            // 
            this.converterButton.Location = new System.Drawing.Point(318, 174);
            this.converterButton.Name = "converterButton";
            this.converterButton.Size = new System.Drawing.Size(95, 36);
            this.converterButton.TabIndex = 0;
            this.converterButton.Text = "CONVERT";
            this.converterButton.UseVisualStyleBackColor = true;
            this.converterButton.Click += new System.EventHandler(this.converterButton_Click);
            // 
            // enterYourWeightOnEarth
            // 
            this.enterYourWeightOnEarth.AutoSize = true;
            this.enterYourWeightOnEarth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterYourWeightOnEarth.Location = new System.Drawing.Point(23, 49);
            this.enterYourWeightOnEarth.Name = "enterYourWeightOnEarth";
            this.enterYourWeightOnEarth.Size = new System.Drawing.Size(195, 21);
            this.enterYourWeightOnEarth.TabIndex = 1;
            this.enterYourWeightOnEarth.Text = "Enter your weight on Earth";
            // 
            // yourWeightOnMars
            // 
            this.yourWeightOnMars.AutoSize = true;
            this.yourWeightOnMars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yourWeightOnMars.Location = new System.Drawing.Point(23, 116);
            this.yourWeightOnMars.Name = "yourWeightOnMars";
            this.yourWeightOnMars.Size = new System.Drawing.Size(154, 21);
            this.yourWeightOnMars.TabIndex = 2;
            this.yourWeightOnMars.Text = "Your weight on Mars";
            // 
            // inputYourWeightOnEarth
            // 
            this.inputYourWeightOnEarth.Location = new System.Drawing.Point(257, 47);
            this.inputYourWeightOnEarth.Name = "inputYourWeightOnEarth";
            this.inputYourWeightOnEarth.Size = new System.Drawing.Size(156, 23);
            this.inputYourWeightOnEarth.TabIndex = 3;
            this.inputYourWeightOnEarth.TextChanged += new System.EventHandler(this.inputYourWeightOnEarth_TextChanged);
            // 
            // outputYourWeightOnMars
            // 
            this.outputYourWeightOnMars.Location = new System.Drawing.Point(257, 114);
            this.outputYourWeightOnMars.Name = "outputYourWeightOnMars";
            this.outputYourWeightOnMars.Size = new System.Drawing.Size(156, 23);
            this.outputYourWeightOnMars.TabIndex = 4;
            // 
            // unitConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 265);
            this.Controls.Add(this.outputYourWeightOnMars);
            this.Controls.Add(this.inputYourWeightOnEarth);
            this.Controls.Add(this.yourWeightOnMars);
            this.Controls.Add(this.enterYourWeightOnEarth);
            this.Controls.Add(this.converterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "unitConverterForm";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button converterButton;
        private Label enterYourWeightOnEarth;
        private Label yourWeightOnMars;
        private TextBox inputYourWeightOnEarth;
        private TextBox outputYourWeightOnMars;
    }
}