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
            int so=Convert.ToInt32(box.Text);
            if (soChinhPhuong(so))
            {
                ketqua.Text = so + " là số chính phương";
            }
            else
            {
                ketqua.Text = so + " không phải số chính phương";
            }
        }
        bool soChinhPhuong(int so) {
            if (so < 0) return false;
            int sqrt=(int)Math.Sqrt(so);
            return sqrt * sqrt == so;
        
        }


    }
}
