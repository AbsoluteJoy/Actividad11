namespace ejemplo2
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
            btnPromedio = new Button();
            textBox2 = new TextBox();
            lbResultado = new Label();
            textBox1 = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(437, 128);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(118, 60);
            btnPromedio.TabIndex = 9;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 206);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 129);
            textBox2.TabIndex = 8;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BackColor = SystemColors.GradientInactiveCaption;
            lbResultado.Location = new Point(56, 102);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 7;
            lbResultado.Text = "lbResultado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 23);
            textBox1.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(437, 25);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(118, 69);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 369);
            Controls.Add(btnPromedio);
            Controls.Add(textBox2);
            Controls.Add(lbResultado);
            Controls.Add(textBox1);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPromedio;
        private TextBox textBox2;
        private Label lbResultado;
        private TextBox textBox1;
        private Button btnRegistrar;
    }
}
