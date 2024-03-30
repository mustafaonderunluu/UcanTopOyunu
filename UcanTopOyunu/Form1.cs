namespace UcanTopOyunu
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 5, yerY = 5,can = 3;
        private void CarpmaOlayý() {
            //Label 2 çarpma

            if (Ball.Top <= label2.Bottom)
                yerY = yerY * -1;
            //Kontrol e Çarpma
            if (Ball.Bottom >= Kontrol.Top && Ball.Left >= Kontrol.Left && Ball.Right <= Kontrol.Right)
                yerY = yerY * -1;

            // sað kenara çarpma 

            else if (Ball.Right >= label5.Left)
                yerX = yerX * -1;
            //sol kenara çarpma
            else if (Ball.Left <= label1.Right)
                yerX = yerX * -1;
        }
        private void YanmaOlayý(object sender, EventArgs e) {

            if (Ball.Top >= label3.Bottom)
            {
                if (can > 0) { 
                
                 timer1.Stop();
                    can--;
                    MessageBox.Show("Yandýnýz Kalan Can >= " + can.ToString());
                    Form1_Load(sender, e);
                }
                if (can == 0) {

                    timer1.Stop();
                    MessageBox.Show("Oyunu Kaybettiniz"," " MessageBoxButtons.OK);
                }
            }
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Kontrol.Left = e.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            YanmaOlayý(sender, e);
           CarpmaOlayý();
            Ball.Location = new Point(Ball.Location.X + yerX, Ball.Location.Y + yerY);
        }
    }
}
