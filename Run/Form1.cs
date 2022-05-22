namespace Run
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_MouseEnter(object sender, EventArgs e)
        {
            int btnW = Run.Width+35; int btnH = Run.Height+35;
            int x = Random.Shared.Next(0, Width - btnH);
            int y = Random.Shared.Next(0, Height - btnW);
            Run.Location = new Point(x,y);
        }
    }
}