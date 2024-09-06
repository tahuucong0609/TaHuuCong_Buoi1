namespace TaHuuCong_Buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void ntbgiai_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txta.Text, out double a) &&
               double.TryParse(txtb.Text, out double b) &&
               double.TryParse(txtc.Text, out double c))
            {
                // Tính delta
                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lblketqua.Text = $"Phương trình có hai nghiệm phân biệt:\nX1 = {x1}\nX2 = {x2}";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    lblketqua.Text = $"Phương trình có nghiệm kép:\nX = {x}";
                }
                else
                {
                    lblketqua.Text = "Phương trình vô nghiệm.";
                }
            }
            else
            {
                lblketqua.Text = "Vui lòng nhập đúng các hệ số.";
            }
        }

        private void lblxoa_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txta.Clear();
            txtc.Clear();
            lblketqua.Text = string.Empty;
        }

        private void lblthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
