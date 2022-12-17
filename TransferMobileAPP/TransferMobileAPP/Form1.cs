namespace TransferMobileAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilograms = double.Parse(kgBox.Text);

            if (kilograms >= 20 / 2.2 && kilograms < 23 / 2.2) {

                actualCalculation.Text = "test";
            }

            else if (kilograms >= 23 / 2.2 && kilograms < 24 / 2.2)
            {
                actualCalculation.Text = "test2";

            }

            else if (kilograms >= 30 / 2.2 && kilograms < 31 / 2.2)
            {

           

            }

            else if (kilograms >= 31 / 2.2 && kilograms < 36 / 2.2)
            {

            

            }

            else if (kilograms >= 36 / 2.2 && kilograms < 38 / 2.2)
            {

            

            }

            else if (kilograms >= 38 / 2.2 && kilograms < 42 / 2.2)
            {

             

            }

            else if (kilograms >= 42 / 2.2 && kilograms < 46 / 2.2)
            {

          
            }

            else if (kilograms >= 46 / 2.2 && kilograms < 48 / 2.2)
            {

         

            }



            else if (kilograms >= 48 / 2.2 && kilograms < 51 / 2.2)
            {

         

            }

            else if (kilograms >= 51 / 2.2 && kilograms < 56 / 2.2)
            {

             

            }

            else if (kilograms >= 56 / 2.2 && kilograms < 60 / 2.2)
            {

     

            }

            else if (kilograms >= 60 / 2.2 && kilograms < 62 / 2.2)
            {

  

            }


            else if (kilograms >= 62 / 2.2 && kilograms < 65 / 2.2)
            {

       

            }

            else if (kilograms >= 65 / 2.2 && kilograms < 71 / 2.2)
            {


            }

            else if (kilograms >= 71 / 2.2 && kilograms < 78 / 2.2)
            {

         
            }

            else if (kilograms >= 78 / 2.2 && kilograms < 79 / 2.2)
            {

          

            }


            else if (kilograms >= 79 / 2.2 && kilograms < 86 / 2.2)
            {

          

            }


            else if (kilograms >= 86 / 2.2)
            {


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualCalculation.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      
    }
}