using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace joguinho3
{
    public partial class Form3 : Form
    {

        public static Form3 instance;
        public Panel pnl1;
        public PictureBox pctrBxWlk1F3;
        public PictureBox pctrBxWlk2F3;
        public PictureBox pctrBxWlk3F3;
        public PictureBox pctrBxWlk4F3;
        public PictureBox pctrBxWlk5F3;
        public PictureBox pctrBxWlk6F3;
        public PictureBox pctrBxWlk7F3;
        public PictureBox pctrBxWlk8F3;
        public PictureBox pctrBxWlk9F3;
        public PictureBox pctrBxWlk10F3;
        public PictureBox pctrBxWlk11F3;
        public PictureBox pctrBxRn1F3;
        public PictureBox pctrBxRn2F3;
        public PictureBox pctrBxRn3F3;
        public PictureBox pctrBxRn4F3;
        public PictureBox idl3;
        public PictureBox p1Pnt1F3;
        public PictureBox p1;
        public PictureBox erroP1;



        public Form3()
        {
            InitializeComponent();

            instance = this;
            pnl1 = panel1;
            p1 = pctrBxPlayer1;
            pctrBxWlk1F3 = pctrBxWlk1;
            pctrBxWlk2F3 = pctrBxWalk2;
            pctrBxWlk3F3 = pctrBxWalk3;
            pctrBxWlk4F3 = pctrBxWalk4;
            pctrBxWlk5F3 = pctrBxWalk5;
            pctrBxWlk6F3 = pctrBxWalk6;
            pctrBxWlk7F3 = pctrBxWalk7;
            pctrBxWlk8F3 = pctrBxWalk8;
            pctrBxWlk9F3 = pctrBxWalk9;
            pctrBxWlk10F3 = pctrBxWalk10;
            pctrBxWlk11F3 = pctrBxWalk11;
            pctrBxRn1F3 = pctrBxRun1;
            pctrBxRn2F3 = pctrBxRun2;
            pctrBxRn3F3 = pctrBxRun3;
            pctrBxRn4F3 = pctrBxRun4;
            idl3 = idle3;
            p1Pnt1F3 = p1Point1;
            erroP1 = pctrBxErrou;

            timer1.Interval = 5000;
            timer1.Start();

            timer2.Interval = 3500;
            timer2.Start();

            string binPath = Application.StartupPath; // This is bin/Debug
            string projectRootPath = Directory.GetParent(binPath).Parent.Parent.Parent.FullName; // Moves two levels up to project root

            // Combine the path to access the Resources folder from the project root
            string filePath = Path.Combine(projectRootPath, "Resources", "entrada.wav");


            // Check if the file exists and play the sound
            if (File.Exists(filePath))
            {
                SoundPlayer player = new SoundPlayer(filePath);
                player.Play();

            }
            else
            {
                MessageBox.Show("WAV file not found at: " + filePath);
            }
        }

        private void pnlPonto2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //print hello world every 5 seconds
            Form4 formQuiz = Form4.GetInstance(); // Obtém a instância única de Form4
            formQuiz.Show(); // Mostra o formulário apenas se necessário
            timer1.Stop(); // Para o timer após abrir o quiz

        }

        private void pctrBxWlk1_Click(object sender, EventArgs e)
        {

        }

        private void p1Point1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string binPath2 = Application.StartupPath; // This is bin/Debug
            string projectRootPath2 = Directory.GetParent(binPath2).Parent.Parent.Parent.FullName;
            string filePath2 = Path.Combine(projectRootPath2, "Resources", "trilhasonora.wav");
            SoundPlayer player2 = new SoundPlayer(filePath2);
            player2.PlayLooping();
            timer2.Stop();
        }
    }
}
