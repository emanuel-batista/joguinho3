using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinho3
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public System.Windows.Forms.Timer tmrErrarP1; // Declare o Timer como uma propriedade pública
        public System.Windows.Forms.Timer tmrP1Andar1;
        public Form2()
        {
            InitializeComponent();
            tmrErrarP1 = new System.Windows.Forms.Timer(); // Inicializa o Timer
            tmrErrarP1.Interval = 100; // Define o intervalo do Timer
            tmrErrarP1.Tick += new EventHandler(tmrErrarP1_Tick);

            tmrP1Andar1 = new System.Windows.Forms.Timer();
            tmrP1Andar1.Interval = 250;
            tmrP1Andar1.Tick += new EventHandler(tmrP1Andar1_Tick);


            Form4 formQuizP1 = Form4.GetInstance();
            instance = this;
            tmrp1 = new System.Timers.Timer();


        }

        private int counter = 0;

        public void AndarP1()
        {
            //if (counter == 0)
            //{
            //    MessageBox.Show("P1 acertou a resposta! Melhor correr...", "Mensagem à P2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            p1Point1.Visible = false;
            pctrBxWalk2.Visible = false;
            pctrBxWalk3.Visible = false;
            pctrBxWalk4.Visible = false;
            pctrBxWalk5.Visible = false;
            pctrBxWalk6.Visible = false;
            pctrBxWalk7.Visible = false;
            pctrBxWalk8.Visible = false;
            pctrBxPlayer1.Visible = false;

            // Show the current image based on the counter value
            switch (counter % 8)
            {
                case 0:
                    pctrBxWalk2.Visible = true;
                    break;
                case 1:
                    pctrBxWalk3.Visible = true;
                    break;
                case 2:
                    pctrBxWalk4.Visible = true;
                    break;
                case 3:
                    pctrBxWalk5.Visible = true;
                    break;
                case 4:
                    pctrBxWalk6.Visible = true;
                    break;
                case 5:
                    pctrBxWalk7.Visible = true;
                    break;
                case 6:
                    pctrBxWalk8.Visible = true;
                    break;
                case 7:
                    pctrBxPlayer1.Visible = true;
                    break;
            }

            counter++;

            // Stop the timer when all images have been shown
            if (counter >= 8)
            {
                //this.Hide();
                tmrP1Andar1.Stop();
                counter = 0; // Reset the counter if you want to repeat the process
                
                //button1.Enabled = true; // Habilita o botão novamente
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmrP1Andar1_Tick(object sender, EventArgs e)
        {
            AndarP1();
        }

        public System.Timers.Timer tmrp1;

        private int mostrar = 0;

        private void ErrarP1()
        {
           //MessageBox.Show("Errar p1");
            if (mostrar == 0)
            {
                mostrar = 1;
            }

            pctrBxErrou.Visible = !pctrBxErrou.Visible;
            if (pctrBxErrou.Visible)
            {
                pctrBxErrou.BringToFront(); // Traz o pctrBxErrou para frente
            }

            mostrar++;
            if (mostrar > 10) // 10 iterações para alternar a visibilidade 5 vezes
            {
                tmrErrarP1.Stop();
                mostrar = 0;
                pctrBxErrou.Visible = false;
            }

        }

        private void tmrErrarP1_Tick(object sender, EventArgs e)
        {
        
            
                
                ErrarP1();
            
        }
    }
}
