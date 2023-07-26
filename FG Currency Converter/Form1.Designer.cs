namespace Fantasy_Grounds_Currency_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ppInput = new TextBox();
            gpInput = new TextBox();
            spInput = new TextBox();
            cpInput = new TextBox();
            label6 = new Label();
            ppOutput = new TextBox();
            label7 = new Label();
            gpOutput = new TextBox();
            label8 = new Label();
            spOutput = new TextBox();
            label9 = new Label();
            cpOutput = new TextBox();
            label10 = new Label();
            startConversionButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(47, 157);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 29);
            label1.TabIndex = 0;
            label1.Text = "Platin Pieces";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(261, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 0;
            label2.Text = "Gold Pieces";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(467, 157);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 29);
            label3.TabIndex = 0;
            label3.Text = "Silver Pieces";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(681, 157);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 29);
            label4.TabIndex = 0;
            label4.Text = "Copper Pieces";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(289, 37);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(329, 42);
            label5.TabIndex = 0;
            label5.Text = "Money to Convert";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ppInput
            // 
            ppInput.BackColor = Color.Tan;
            ppInput.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ppInput.Location = new Point(75, 212);
            ppInput.Margin = new Padding(4, 3, 4, 3);
            ppInput.Name = "ppInput";
            ppInput.Size = new Size(116, 35);
            ppInput.TabIndex = 0;
            ppInput.TabStop = false;
            ppInput.Text = "0";
            ppInput.TextAlign = HorizontalAlignment.Center;
            ppInput.Click += ppInput_Click;
            // 
            // gpInput
            // 
            gpInput.BackColor = Color.Tan;
            gpInput.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            gpInput.Location = new Point(280, 212);
            gpInput.Margin = new Padding(4, 3, 4, 3);
            gpInput.Name = "gpInput";
            gpInput.Size = new Size(116, 35);
            gpInput.TabIndex = 2;
            gpInput.TabStop = false;
            gpInput.Text = "0";
            gpInput.TextAlign = HorizontalAlignment.Center;
            gpInput.Click += gpInput_Click;
            // 
            // spInput
            // 
            spInput.BackColor = Color.Tan;
            spInput.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            spInput.Location = new Point(495, 212);
            spInput.Margin = new Padding(4, 3, 4, 3);
            spInput.Name = "spInput";
            spInput.Size = new Size(116, 35);
            spInput.TabIndex = 3;
            spInput.TabStop = false;
            spInput.Text = "0";
            spInput.TextAlign = HorizontalAlignment.Center;
            spInput.Click += spInput_Click;
            // 
            // cpInput
            // 
            cpInput.BackColor = Color.Tan;
            cpInput.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cpInput.Location = new Point(719, 212);
            cpInput.Margin = new Padding(4, 3, 4, 3);
            cpInput.Name = "cpInput";
            cpInput.Size = new Size(116, 35);
            cpInput.TabIndex = 4;
            cpInput.TabStop = false;
            cpInput.Text = "0";
            cpInput.TextAlign = HorizontalAlignment.Center;
            cpInput.Click += cpInput_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(271, 305);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(375, 42);
            label6.TabIndex = 5;
            label6.Text = "Money after Convert";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ppOutput
            // 
            ppOutput.BackColor = Color.Tan;
            ppOutput.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ppOutput.Location = new Point(75, 452);
            ppOutput.Margin = new Padding(4, 3, 4, 3);
            ppOutput.Name = "ppOutput";
            ppOutput.ReadOnly = true;
            ppOutput.Size = new Size(116, 35);
            ppOutput.TabIndex = 7;
            ppOutput.TabStop = false;
            ppOutput.Text = "0";
            ppOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(47, 397);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 29);
            label7.TabIndex = 6;
            label7.Text = "Platin Pieces";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gpOutput
            // 
            gpOutput.BackColor = Color.Tan;
            gpOutput.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            gpOutput.Location = new Point(280, 452);
            gpOutput.Margin = new Padding(4, 3, 4, 3);
            gpOutput.Name = "gpOutput";
            gpOutput.ReadOnly = true;
            gpOutput.Size = new Size(116, 35);
            gpOutput.TabIndex = 9;
            gpOutput.TabStop = false;
            gpOutput.Text = "0";
            gpOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(261, 397);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(156, 29);
            label8.TabIndex = 8;
            label8.Text = "Gold Pieces";
            // 
            // spOutput
            // 
            spOutput.BackColor = Color.Tan;
            spOutput.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            spOutput.Location = new Point(495, 452);
            spOutput.Margin = new Padding(4, 3, 4, 3);
            spOutput.Name = "spOutput";
            spOutput.ReadOnly = true;
            spOutput.Size = new Size(116, 35);
            spOutput.TabIndex = 11;
            spOutput.TabStop = false;
            spOutput.Text = "0";
            spOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(467, 397);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(167, 29);
            label9.TabIndex = 10;
            label9.Text = "Silver Pieces";
            // 
            // cpOutput
            // 
            cpOutput.BackColor = Color.Tan;
            cpOutput.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cpOutput.Location = new Point(719, 452);
            cpOutput.Margin = new Padding(4, 3, 4, 3);
            cpOutput.Name = "cpOutput";
            cpOutput.ReadOnly = true;
            cpOutput.Size = new Size(116, 35);
            cpOutput.TabIndex = 13;
            cpOutput.TabStop = false;
            cpOutput.Text = "0";
            cpOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(681, 397);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(187, 29);
            label10.TabIndex = 12;
            label10.Text = "Copper Pieces";
            // 
            // startConversionButton
            // 
            startConversionButton.BackColor = Color.Tan;
            startConversionButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            startConversionButton.Location = new Point(756, 9);
            startConversionButton.Margin = new Padding(4, 3, 4, 3);
            startConversionButton.Name = "startConversionButton";
            startConversionButton.Size = new Size(159, 102);
            startConversionButton.TabIndex = 14;
            startConversionButton.TabStop = false;
            startConversionButton.Text = "Start Conversion";
            startConversionButton.UseVisualStyleBackColor = false;
            startConversionButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 519);
            Controls.Add(startConversionButton);
            Controls.Add(cpOutput);
            Controls.Add(label10);
            Controls.Add(spOutput);
            Controls.Add(label9);
            Controls.Add(gpOutput);
            Controls.Add(label8);
            Controls.Add(ppOutput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cpInput);
            Controls.Add(spInput);
            Controls.Add(gpInput);
            Controls.Add(ppInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Fantasy Grounds Currency Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ppInput;
        private TextBox gpInput;
        private TextBox spInput;
        private TextBox cpInput;
        private Label label6;
        private TextBox ppOutput;
        private Label label7;
        private TextBox gpOutput;
        private Label label8;
        private TextBox spOutput;
        private Label label9;
        private TextBox cpOutput;
        private Label label10;
        private Button startConversionButton;
    }
}

