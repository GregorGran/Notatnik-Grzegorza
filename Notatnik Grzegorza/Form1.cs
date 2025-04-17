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

        private void Edytuj_Click(object sender, EventArgs e)
        {
            isEditing = true;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            try
            {
                Notatnik.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch (Exception errormessege)
            {
                MessageBox.Show("Nie mo�na usun�� tej notatki. " + errormessege.Message);
            }
        }

        private void zapisz_Click(object sender, EventArgs e)
        {

        }
    }
}
