namespace ejemplo1
{
    partial class Form1
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
            btnRegistrar = new Button();
            textBox1 = new TextBox();
            lbResultado = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(670, 117);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 23);
            textBox1.TabIndex = 1;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BackColor = SystemColors.GradientInactiveCaption;
            lbResultado.Location = new Point(289, 194);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "lbResultado";
            lbResultado.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 298);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 129);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(670, 220);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "btnPromed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 471);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(lbResultado);
            Controls.Add(textBox1);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private TextBox textBox1;
        private Label lbResultado;
        private TextBox textBox2;
        private Button button1;
    }
}
