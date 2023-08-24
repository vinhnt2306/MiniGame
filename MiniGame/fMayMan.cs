using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class fMayMan : Form
    {
        string pathImg;
        Random rand = new Random();
        public fMayMan()
        {
            InitializeComponent();
        }

        private void fTaixiu_Load(object sender, EventArgs e)
        {
            pathImg = Application.StartupPath + @"\HinhXucSac\";
            pic1.Image = pic2.Image = pic3.Image = Image.FromFile(pathImg + "6.bm.jpg");
        }

        private void btn_Quay_Click(object sender, EventArgs e)
        {
            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);
            pic1.Image = Image.FromFile(pathImg + so1.ToString() + ".bm.jpg");
            pic2.Image = Image.FromFile(pathImg + so2.ToString() + ".bm.jpg");
            pic3.Image = Image.FromFile(pathImg + so3.ToString() + ".bm.jpg");
            lblResult.Text = String.Format("{0}", so1 + so2 + so3);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            } 
                
        }
    }
}
