using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFcruzlara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pB1.Invalidate();

            OpenFileDialog pdfOnEdge = new OpenFileDialog();
            pdfOnEdge.FileName = "horario.pdf";
            PDF1.LoadFile(pdfOnEdge.FileName);

            web1.Navigate("C:/Users/lange/Develop/school/software-engeniering/practicas-ingenieriaDeSoftware/bin/Debug/horario.pdf");

            OpenFileDialog localCountdownVideo = new OpenFileDialog();
            localCountdownVideo.FileName = "countdown.mp4";
            Player1.URL = localCountdownVideo.FileName;

            youtubeVideo.Navigate("https://www.youtube.com/v/orLfLilKWQU");

            google.Navigate("https://www.google.com.mx");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pB1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image myImage = Image.FromFile("images.png");
            g.DrawImage(myImage, 0, 0);
        }
    }
}
