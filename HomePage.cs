namespace PresentationHTML
{
    public partial class HomePage : Form
    {
        public int iCountPages = 1;
        public string sText = "Page";
        public HomePage()
        {
            InitializeComponent();
            MessageBox.Show(this, "Ceci est une application expérimentale développée par Yanis AZOUAOUI, 1STI2D2. S'il y a des problèmes merci de me le signaler", "Information - Developpement");

            loadform(new PresentationHTML.pages.Page1());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void loadform(object FormPanel)
        {
            if (this.DPanel_Main.Controls.Count > 0)
                this.DPanel_Main.Controls.RemoveAt(0);
            Form f = FormPanel as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.DPanel_Main.Controls.Add(f);
            this.DPanel_Main.Tag = f;
            f.Show();
        }

        private void SelectedFrame(int iCount)
        {
            if (iCount == 1)
            {
                loadform(new PresentationHTML.pages.Page1());
            }

            if (iCount == 2)
            {
                loadform(new PresentationHTML.pages.Page2());
            }

            if (iCount == 3)
            {
                loadform(new PresentationHTML.pages.Page3());
            }

            if (iCount == 4)
            {
                loadform(new PresentationHTML.pages.Page4());
            }

            if (iCount == 5)
            {
                loadform(new PresentationHTML.pages.Page5());
            }

            if (iCount == 6)
            {
                loadform(new PresentationHTML.pages.Page6());
            }

            if (iCount == 7)
            {
                loadform(new PresentationHTML.pages.Page7());
            }

            if (iCount == 8)
            {
                loadform(new PresentationHTML.pages.Page8());
            }

            if (iCount == 9)
            {
                loadform(new PresentationHTML.pages.Page9());
            }

            if (iCount == 10)
            {
                loadform(new PresentationHTML.pages.Page10());
            }

            if (iCount == 11)
            {
                loadform(new PresentationHTML.pages.Page11());
            }

            if (iCount == 12)
            {
                loadform(new PresentationHTML.pages.Page12());
            }

        }
        
        private void button_next_Click(object sender, EventArgs e)
        {
            // Add 1 for int iCountPages

            if (iCountPages < 12)
            {
                iCountPages = iCountPages + 1;
            }

            if (iCountPages > 1 && !button_back.Visible)
            {
                button_back.Visible = true;
            }

            if (iCountPages == 12 && button_next.Visible)
            {
                button_next.Visible = false;
            }
        

            SelectedFrame(iCountPages);

            this.sTitle.Text = "HTML TP - Etape " + iCountPages;

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

        private void button_back_Click(object sender, EventArgs e)
        {
            if (iCountPages > 0)
            {
                iCountPages = iCountPages - 1;
            }

            if (iCountPages == 1 && button_back.Visible)
            {
                button_back.Visible = false;
            }

            if (iCountPages < 12 && !button_next.Visible)
            {
                button_next.Visible = true;
            }

            SelectedFrame(iCountPages);

            this.sTitle.Text = "HTML TP - Etape " + iCountPages;
        }

        private void button_back_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.button_back.BackgroundImage = Properties.Resources.button_back_hover;
        }

        private void button_back_MouseExitHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.button_back.BackgroundImage = Properties.Resources.button_back;
        }


    }
            

}