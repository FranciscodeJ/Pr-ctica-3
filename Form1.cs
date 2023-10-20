namespace Práctica__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text); // se declaró que en los valores que se escriban en las cajas de texto se asignen a num1 y2. 
            int num2 = Int32.Parse(textBox2.Text);
            int sum = num1 + num2;                 //se escribió una ecuación para obtenr la suma a aprtir de num 1 y 2.
            label3.Text = "Sum = " + sum;         // se declaró que se pondrá en el cuadro para texto label el resultado, al lado del texto "Sum ="
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
