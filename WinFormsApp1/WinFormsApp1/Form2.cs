using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        ProductDbContext context = new ProductDbContext();


        void ShowDataGridView()
        {
            //取得目前清單中的value值
            int categoryId = int.Parse(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = context.產品資料s.Where(m => m.類別編號 == categoryId).ToList();
            textBox2.Text = textBox3.Text = textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = context.產品類別s.ToList();
            comboBox1.DisplayMember = "類別名稱";
            comboBox1.ValueMember = "類別編號";

            ShowDataGridView();
        }
    }
}
