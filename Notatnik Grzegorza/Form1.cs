using System.Data;

namespace Notatnik_Grzegorza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable Notatnik = new DataTable();
        bool isEditing = false;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Notatnik.Columns.Add("Notatka");
            dataGridView1.DataSource = Notatnik;
        }

        private void Nowytekst_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
