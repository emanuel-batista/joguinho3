using System.Media;
using NAudio.Wave;
using System.IO;
namespace joguinho3
{

    

    public partial class Form4 : Form
    {
        int posicao = 0;
        public static Form4 instance;
        private IWavePlayer? waveOut = null;
        private AudioFileReader? audioFileReader = null;

        private void PlaySound(string filePath, int durationInMilliseconds)
        {
            waveOut = new WaveOutEvent();
            audioFileReader = new AudioFileReader(filePath);
            waveOut.Init(audioFileReader);
            waveOut.PlaybackStopped += OnPlaybackStopped;
            waveOut.Play();

            // Configura um timer para parar a reprodução após a duração especificada
            var stopTimer = new System.Windows.Forms.Timer();
            stopTimer.Interval = durationInMilliseconds;
            stopTimer.Tick += (s, e) =>
            {
                waveOut.Stop();
                stopTimer.Stop();
                stopTimer.Dispose();
            };
            stopTimer.Start();
        }
        private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
        {
            waveOut.Dispose();
            audioFileReader.Dispose();
            waveOut = null;
            audioFileReader = null;
        }
        public Form4()
        {


            InitializeComponent();
            this.timer2.Enabled = false;
            this.timer3.Enabled = false;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);

            instance = this;
            //timer2.Interval = 10000;
            //timer2.Start();
            switch (posicao)
            {
                case 0:
                    grpBxPergunta.Text = "Qual artista abaixo possui mais Grammys?";
                    rdBtn1.Text = "Beyoncé";
                    rdBtn2.Text = "Taylor Swift";
                    rdBtn3.Text = "Adele";
                    rdBtn4.Text = "Kanye West";

                    break;
                case 1:
                    button1.Enabled = true;
                    grpBxPergunta.Text = "Qual matéria abaixo é lecionada por Marcelo Torres?";
                    rdBtn1.Text = "Introdução ao Desenvolvimento Desktop";
                    rdBtn2.Text = "Ciências Sociais aplicada às Periferias";
                    rdBtn3.Text = "Introdução à Programação orientada a Objeto";
                    rdBtn4.Text = "Psicologia";
                    break;
            }
        }
        public static Form4 GetInstance()
        {
            if (instance == null)
            {
                instance = new Form4();
            }
            return instance;
        }
        private int counter = 0;

        //class Pergunta
        //{
        //    public string[] pergunta = new string[13] {
        //        "Qual artista abaixo possui mais Grammys?",
        //        "Qual matéria abaixo é lecionada por Marcelo Torres?",
        //        "Qual artista brasileiro abaixo possui um Grammy Latino?",
        //        "Quantos anos Blue Ivy tem?",
        //        "Qual o nome do primeiro ex citado na canção \"thank u, next\" de Ariana Grande?",
        //        "Uma matéria boa?",
        //        "Qual o nome do projeto apresentado por Emanuel e Paulo na FEC de 2024?",
        //        "",
        //        "",
        //        "",
        //        "",
        //        "",
        //        ""};
        //}

        public bool andouP1;

        public void AndarPonto1()
        {
            andouP1 = true;
            
            if(counter == 0)
            {
                Form2.instance.tmrP1Andar1.Start();
            }

            //button 1 non clickable
            button1.Enabled = false;
            // Hide all images first
            Form3.instance.p1.Visible = false;
            Form3.instance.pctrBxWlk1F3.Visible = false;
            Form3.instance.pctrBxWlk2F3.Visible = false;
            Form3.instance.pctrBxWlk3F3.Visible = false;
            Form3.instance.pctrBxWlk4F3.Visible = false;
            Form3.instance.pctrBxWlk5F3.Visible = false;
            Form3.instance.pctrBxWlk6F3.Visible = false;
            Form3.instance.pctrBxWlk7F3.Visible = false;
            Form3.instance.pctrBxWlk8F3.Visible = false;
            Form3.instance.p1Pnt1F3.Visible = false;

            // Show the current image based on the counter value
            switch (counter % 9)
            {
                case 0:
                    Form3.instance.pctrBxWlk1F3.Visible = true;
                    break;
                case 1:
                    Form3.instance.pctrBxWlk2F3.Visible = true;
                    break;
                case 2:
                    Form3.instance.pctrBxWlk3F3.Visible = true;
                    break;
                case 3:
                    Form3.instance.pctrBxWlk4F3.Visible = true;
                    break;
                case 4:
                    Form3.instance.pctrBxWlk5F3.Visible = true;
                    break;
                case 5:
                    Form3.instance.pctrBxWlk6F3.Visible = true;
                    break;
                case 6:
                    Form3.instance.pctrBxWlk7F3.Visible = true;
                    break;
                case 7:
                    Form3.instance.pctrBxWlk7F3.Visible = true;
                    break;
                case 8:
                    Form3.instance.p1Pnt1F3.Visible = true;
                    break;
            }

            counter++;

            // Stop the timer when all images have been shown
            if (counter >= 9)
            {
                this.Hide();
                timer1.Stop();
                counter = 0; // Reset the counter if you want to repeat the process
               
                //button1.Enabled = true; // Habilita o botão novamente
            }

        }

        void AndarPonto2()
        {
            //MessageBox.Show("Hello World");
            if (posicao == 1 && rdBtn2.Checked == true)
            {
                MessageBox.Show("Resposta correta!", "Acertou em cheio!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                timer2.Start(); // Inicia o timer para AndarPonto2()
                posicao++; // Incrementa a posição para o próximo caso
            }
            else if (posicao == 1 && rdBtn2.Checked == false)
            {
                MessageBox.Show("Resposta errada!");
                this.Hide();

            }
            counter++;
            Form3.instance.pctrBxWlk9F3.Visible = false;
            Form3.instance.pctrBxWlk10F3.Visible = false;
            Form3.instance.pctrBxWlk11F3.Visible = false;
            Form3.instance.pctrBxRn1F3.Visible = false;
            Form3.instance.pctrBxRn2F3.Visible = false;
            Form3.instance.pctrBxRn3F3.Visible = false;
            Form3.instance.pctrBxRn4F3.Visible = false;
            Form3.instance.idl3.Visible = false;
            Form3.instance.p1Pnt1F3.Visible = false;

            switch (counter % 7)
            {
                case 0:
                    Form3.instance.pctrBxWlk9F3.Visible = true;
                    break;
                case 1:
                    Form3.instance.pctrBxWlk10F3.Visible = true;
                    break;
                case 2:
                    Form3.instance.pctrBxWlk11F3.Visible = true;
                    break;
                case 3:
                    Form3.instance.pctrBxRn1F3.Visible = true;
                    break;
                case 4:
                    Form3.instance.pctrBxRn2F3.Visible = true;
                    break;
                case 5:
                    Form3.instance.pctrBxRn3F3.Visible = true;
                    break;
                case 6:
                    Form3.instance.pctrBxRn4F3.Visible = true;
                    break;
                case 7:
                    Form3.instance.idl3.Visible = true;
                    break;

            }

            if (counter >= 7)
            {
                timer2.Stop();
                counter = 0; // Reset the counter if you want to repeat the process
                this.Close();

            }

        }

        private void AtualizarPergunta()
        {
            switch (posicao)
            {
                case 0:
                    grpBxPergunta.Text = "Qual artista abaixo possui mais Grammys?";
                    rdBtn1.Text = "Beyoncé";
                    rdBtn2.Text = "Taylor Swift";
                    rdBtn3.Text = "Adele";
                    rdBtn4.Text = "Kanye West";
                    break;

                case 1:
                    button1.Enabled = true;
                    grpBxPergunta.Text = "Qual matéria abaixo é lecionada por Marcelo Torres?";
                    rdBtn1.Text = "Ciências Sociais aplicada às Periferias";
                    rdBtn2.Text = "Introdução ao Desenvolvimento Desktop";
                    rdBtn3.Text = "Introdução à Programação orientada a Objeto";
                    rdBtn4.Text = "Psicologia";
                    break;
            }
        }

        public bool errouP1;

        private void button1_Click(object sender, EventArgs e)
        {
            // Set the timer interval and start the timer
            
            button1.Enabled = false;

            timer1.Interval = 250;
            timer2.Interval = 250;
            timer3.Interval = 100;
            string binPath = Application.StartupPath; // This is bin/Debug
            string projectRootPath = Directory.GetParent(binPath).Parent.Parent.Parent.FullName; // Moves two levels up to project root

            // Combine the path to access the Resources folder from the project root
            


            // Check if the file exists and play the sound
           
            if (posicao == 0 && rdBtn1.Checked == true)
            {
                MessageBox.Show("Resposta correta!");
                posicao++; // Avança a posição para o case 1
                AtualizarPergunta(); // Atualiza a pergunta para o case 1
                timer1.Start(); // Inicia a animação para AndarPonto1()
                                //MessageBox.Show(posicao.ToString()); // Verifica o valor da posição
                this.Hide();

            }
            else if (posicao == 0 && rdBtn1.Checked == false)
            {
                MessageBox.Show("Resposta errada!");
                errouP1 = true;
                timer3.Start();
                string filePath = Path.Combine(projectRootPath, "Resources", "erro.wav");
                if (File.Exists(filePath))
                {
                    PlaySound(filePath, 3000);

                }
                else
                {
                    MessageBox.Show("WAV file not found at: " + filePath);
                }
                this.Hide();
            }
            
        }

        private int mostrar = 0;
        public int errarP1()
        {
            
            //MessageBox.Show("timer3_Tick disparado!");
            if (mostrar == 0)
            {
                mostrar = 1;
                Form2.instance.tmrErrarP1.Start();
                return 0;
            }

            Form3.instance.erroP1.Visible = !Form3.instance.erroP1.Visible;

            //Form3.instance.erroP1.Visible = false;
            //switch (mostrar % 5)
            //{
            //    case 0:
            //        Form3.instance.erroP1.Visible = true;
            //        break;
            //    case 1:
            //        Form3.instance.erroP1.Visible = false;
            //        break;
            //    case 2:
            //        Form3.instance.erroP1.Visible = true;
            //        break;
            //    case 3:
            //        Form3.instance.erroP1.Visible = false;
            //        break;
            //    case 4:
            //        Form3.instance.erroP1.Visible = true;
            //        break;
            //}

            mostrar++;
            if(mostrar > 10)
            {
                timer3.Stop();
                mostrar = 0;
                Form3.instance.erroP1.Visible = false;
            }
            // Incrementa para a próxima iteração
            return 1;

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Call the function that handles the image visibility
            AndarPonto1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void timer2_Tick(object sender, EventArgs e)
        {


            //if the timer ends, the form will close
            //        button1.Enabled = false;
            //        MessageBox.Show("Você tinha 10 segundos, mas boa sorte na próxima", "O tempo acabou :(",
            //MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        this.Close();
  
                AndarPonto2();
            

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            errarP1();
            //MessageBox.Show("timer3_Tick disparado!");
        }
    }
}

