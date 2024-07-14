using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void đặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open(new DatBan());
        }

        private void quảnLíĐặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open(new Quanliban());
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open(new Quanlinhanvien());
        }

        private void quảnLíThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
