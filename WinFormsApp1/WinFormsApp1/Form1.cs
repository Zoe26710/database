
using WinFormsApp1.Models;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDbContext context = new ProductDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.���~���Os.ToList();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ���~���O category = new ���~���O();
            category.���O�W�� = textBox1.Text;
            context.���~���Os.Add(category);
            context.SaveChanges();
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int categoryid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var category = context.���~���Os.FirstOrDefault(m => m.���O�s�� == categoryid);
            category.���O�W�� = textBox1.Text;
            context.SaveChanges();
            Form1_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int categoryid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var category = context.���~���Os.FirstOrDefault(m => m.���O�s�� == categoryid);
            context.���~���Os.Remove(category);
            context.SaveChanges();
            Form1_Load(sender, e);
        }
    }
}