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
                CubemapLibrary.open_hdri(open_file_dialog.FileName);
            }
        }

        private void generate_cubemap_button_Click(object sender, EventArgs e)
        {
            CubemapLibrary.make_cube(Int32.Parse(width_text_box.Text));
        }

        private void save_cubemap_button_Click(object sender, EventArgs e)
        {
            if (save_file_dialog.ShowDialog() == DialogResult.OK)
            {
                CubemapLibrary.save_cube_dds(save_file_dialog.FileName, Int32.Parse(width_text_box.Text));
            }
        }

    }
}
