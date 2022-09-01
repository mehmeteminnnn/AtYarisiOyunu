using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }
        public int birinciatsolauzak, ikinciatsolauzak, ucuncuatsolauzak;
        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;
            int bitisuzak = label4.Left;
            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);
            if(pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>pictureBox2.Left+5)
            {
                label5.Text = "M.Emin önde götürüyor yarışı";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label5.Text = "Mustafa şimdi öne geçti";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label5.Text = "Efe Kazanmaya Yakın";
            }
            if (birinciatgenislik + pictureBox1.Left >= bitisuzak)
            {
                timer1.Enabled = false;
                label5.Text = "M.Emin Şampiyon!!";
            }
            if (ucuncuatgenislik + pictureBox3.Left >= bitisuzak)
            {
                timer1.Enabled = false;
                label5.Text = "Efe Kazanıyoooor";

            }
            if (ikinciatgenislik + pictureBox2.Left >= bitisuzak)
            {
                timer1.Enabled = false;
                label5.Text = "Kupanın Sahibi = Mustafa  ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzak = pictureBox1.Left;
            ikinciatsolauzak = pictureBox2.Left;
            ucuncuatsolauzak = pictureBox3.Left;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
