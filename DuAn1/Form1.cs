using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DuAn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myPanel.Paint += new PaintEventHandler(MyPanel_Paint);
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            lbDoi.BackColor = Color.Transparent;
            lbDoi.ForeColor = Color.White;
            open(new DangKy());
            btnDangKY.Visible = false;
        }

        private void MyPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Vẽ gradient màu từ hồng sang tím
                using (LinearGradientBrush brush = new LinearGradientBrush(panel.ClientRectangle, Color.FromArgb(216, 90, 144), Color.FromArgb(68, 55, 146), 90F))
                {
                    e.Graphics.FillRectangle(brush, panel.ClientRectangle);
                }
            }
        }

        private Form currentFormChild;
        private void open(Form childFrom)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            loadform.Controls.Add(childFrom);
            loadform.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            open(new DangNhap());
            btnDangNhap.Visible = false;
            btnDangKY.Visible = true;
            lbDoi.Text = "Vui lòng đăng ký";

        }

       

        private void btnDangKY_Click(object sender, EventArgs e)
        {
            open(new DangKy());
            btnDangKY.Visible = false;
            btnDangNhap.Visible=true;
            lbDoi.Text = "Vui lòng đăng nhập";
        }
    }
}
