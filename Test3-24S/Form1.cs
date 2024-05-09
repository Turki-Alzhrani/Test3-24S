namespace Test3_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {


            int x = int.Parse(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 0;
            textBox1.Text = y.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox3.Text);
            y = 1;
            int z = int.Parse(textBox3.Text);
            z=(x+y)/2;
            textBox4.Text = z.ToString();
            textBox2.Text=x.ToString(); 
            textBox3.Text=y.ToString();
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

