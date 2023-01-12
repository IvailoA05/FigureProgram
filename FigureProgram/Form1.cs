using System.Threading;

namespace FigureProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        Thread th;
        Thread th1;
        Thread th2;
        private void btnRec_Click(object sender, EventArgs e)
        {
            th = new Thread(threadr);
            th.Start();
        }
        
        public void threadr()
        {
            for (int i = 0; i < 1000; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(new Random().Next(0, this.Width),new Random().Next(0, this.Height), 20, 20));
                Thread.Sleep(3000);
            }
            MessageBox.Show("Rectangles are ready!");
        }

        private void btnTrg_Click(object sender, EventArgs e)
        {
            th1 = new Thread(threadt);
            th1.Start();
        }

        public void threadt()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(2000);
            }
            MessageBox.Show("Triangles are ready!");
        }

        private void btnCrc_Click(object sender, EventArgs e)
        {
            th2 = new Thread(threadc);
            th2.Start();
        }

        public void threadc()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(4000);
            }
            MessageBox.Show("Circles are ready!");
        }
    }
}