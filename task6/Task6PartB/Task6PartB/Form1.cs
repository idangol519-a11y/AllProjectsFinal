using System.Data;

namespace Task6PartB
{
    public partial class Form1 : Form
    {
        Store store;
        DataTable itemsTable;
        public Form1()
        {
 
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            store = new Store();

            itemsTable = store.ItemsTable();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = itemsTable;
            MessageBox.Show("Rows: " + itemsTable.Rows.Count);
        }
    }
}
