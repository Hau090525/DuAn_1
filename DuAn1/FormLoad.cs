using GUI;
using DuAn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DuAn1
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
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
        private void FormLoad_Load(object sender, EventArgs e)
        {
            myPanel.Paint += new PaintEventHandler(MyPanel_Paint);
            this.btnQLMA.Paint += new PaintEventHandler(this.button1_Paint);
            this.btnKHO.Paint += new PaintEventHandler(this.button1_Paint);

            this.btnTD.Paint += new PaintEventHandler(this.button1_Paint);
            this.btnDatBan.Paint += new PaintEventHandler(this.button1_Paint);
            this.btnNhanVien.Paint += new PaintEventHandler(this.button1_Paint);
            this.btnQLBA.Paint += new PaintEventHandler(this.button1_Paint);
            this.btnHoaDon.Paint += new PaintEventHandler(this.button1_Paint);




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
    private void button1_Paint(object sender, PaintEventArgs e)
    {
        Button button = sender as Button;
        if (button != null)
        {
            // Vẽ gradient màu từ hồng sang tím
            using (LinearGradientBrush brush = new LinearGradientBrush(button.ClientRectangle, Color.FromArgb(243, 129, 175), Color.FromArgb(123, 75, 187), 90F))
            {
                e.Graphics.FillRectangle(brush, button.ClientRectangle);
            }

            // Vẽ viền button (nếu cần)
            using (Pen pen = new Pen(Color.FromArgb(243, 129, 175)))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, button.Width - 1, button.Height - 1);
            }

            // Vẽ lại văn bản với màu trắng hoặc màu tương phản để đảm bảo dễ đọc
            TextRenderer.DrawText(e.Graphics, button.Text, button.Font, button.ClientRectangle, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }



    private void btnHoaDon_Click(object sender, EventArgs e)
        {
            open(new QLHD());
        }

        private void btnTD_Click(object sender, EventArgs e)
        {
            open(new QuanLiThucDon());
        }
    }


}
