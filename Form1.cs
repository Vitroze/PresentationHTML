namespace PresentationHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(this, "Ceci est une application expérimentale. Si il y a des problèmes merci de me le signaler", "Information - Developpement");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_next_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button_next_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.BackgroundImage = Properties.Resources.button_next_hover;
        }

        private void button_next_MouseExitHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.BackgroundImage = Properties.Resources.button_next;
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void button_next_Click_1(object sender, EventArgs e)
        {

        }
    }
}