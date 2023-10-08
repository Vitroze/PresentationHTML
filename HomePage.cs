namespace PresentationHTML
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            MessageBox.Show(this, "Ceci est une application expérimentale. Si il y a des problèmes merci de me le signaler", "Information - Developpement");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Page1 page1 = new Page1();
            page1.ShowDialog();
        }

        private void button_next_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.button_next.BackgroundImage = Properties.Resources.button_next_hover;
        }

        private void button_next_MouseExitHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.button_next.BackgroundImage = Properties.Resources.button_next;
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void button_close_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.button_close.BackgroundImage = Properties.Resources.button_close_hover;
        }
        private void button_close_MouseExitHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.button_close.BackgroundImage = Properties.Resources.button_close;
        }
    }
            

}