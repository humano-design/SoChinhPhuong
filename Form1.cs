namespace SoChinhPhuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(box.Text);
            if (soChinhPhuong(so))
            {
                ketqua.Text = so + " là số chính phương";
            }
            else
            {
                ketqua.Text = so + " không phải số chính phương";
            }
            for (int i = 0; i <= 100; i++) {
                int number=Convert.ToInt32(box.Text);
                number = i * i;
                list.Items.Add(number);
            }
        }
        bool soChinhPhuong(int so)
        {
            if (so < 0) return false;
            int sqrt = (int)Math.Sqrt(so);
            return sqrt * sqrt == so;

        }

        private void box_TextChanged(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
