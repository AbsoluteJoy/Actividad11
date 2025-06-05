namespace ejemplo2
{
    public partial class Form1 : Form
    {
        double acumulador = 0;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            double valor = Convert.ToDouble(textBox1.Text);

            acumulador += valor;

            contador++;


        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;//promedio
            lbResultado.Text = $"{promedio,10:f2}";
            textBox2.Text = $"{promedio,10:f2}";
        }

    }
}
