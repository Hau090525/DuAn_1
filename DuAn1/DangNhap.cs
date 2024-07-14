using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
           
        }
        
        private void DangNhap_Load(object sender, EventArgs e)
        {
           
                   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLoad formLoad = new FormLoad();
            formLoad.Show();
            
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    form.Hide();
                    break;
                }
            }


        }
    }
}
