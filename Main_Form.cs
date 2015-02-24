using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cubemap_app
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void open_file_button_Click(object sender, EventArgs e)
        {
            if (open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                //Bitmap bm = new Bitmap(1024, 768, 0, System.Drawing.Imaging.PixelFormat.Format48bppRgb,);
                //bm.
                //panorama_picture_box.Image = 
            }
        }

    }
}
