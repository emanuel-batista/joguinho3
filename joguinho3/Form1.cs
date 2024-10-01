namespace joguinho3
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formPlayer1 = new Form2();
            Form3 formPlayer2 = new Form3();

            formPlayer1.StartPosition = FormStartPosition.Manual;
            formPlayer2.Location = new Point(100, 100); 

            formPlayer2.StartPosition = FormStartPosition.Manual;
            formPlayer2.Location = new Point(formPlayer1.Location.X + formPlayer1.Width + 20, formPlayer1.Location.Y); // Posição ao lado do Jogador 1

            formPlayer2.Show();
            formPlayer1.Show();

            Form4 formQuizP1 = new Form4();
            formQuizP1.StartPosition = FormStartPosition.Manual;
            formQuizP1.Location = new Point(formPlayer1.Location.X + formPlayer1.Width + 20, formPlayer1.Location.Y); // Posição ao lado do Jogador 1
            Form4.instance = formQuizP1;

            this.Hide();

        }
    }
}
