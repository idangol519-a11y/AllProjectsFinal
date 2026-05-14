namespace AnimalForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAnimal ad = new AddAnimal();
            ad.ShowDialog();
        }

        private void viewSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewForm vf = new ViewForm();
            vf.MdiParent = this;
            vf.Show();

        }
    }
}
