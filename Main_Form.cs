using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace cubemap_app
{
    public struct Pixel
    {
        float r, g, b;
    }
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
                IntPtr p_pixels = CubemapLibrary.get_pixels();
                int width  = CubemapLibrary.get_width();
                int height = CubemapLibrary.get_height();
                
                float[] data = new float[width * height * 3];

                Marshal.Copy(p_pixels, data, 0, width * height * 3);

                Bitmap bm = new Bitmap(width, height);
                for(int i = 0; i < width; i++)
                {
                    for(int j = 0; j < height; j++)
                    {
                        float r = data[3*(i + j * width) + 0]; if (r > 1.0f) r = 1.0f; r *= 255;
                        float g = data[3*(i + j * width) + 1]; if (g > 1.0f) g = 1.0f; g *= 255;
                        float b = data[3*(i + j * width) + 2]; if (b > 1.0f) b = 1.0f; b *= 255;
                        bm.SetPixel(i, j, Color.FromArgb((int)r, (int)g, (int)b));
                    }
                }

                panorama_picture_box.BackgroundImage = bm;
            }
        }

        private void generate_cubemap_button_Click(object sender, EventArgs e)
        {
            int height = Int32.Parse(width_text_box.Text);
            int width = height*6;            

            CubemapLibrary.make_cube(height, rotate_z_track_bar.Value);

            Bitmap bm = new Bitmap(width, height);

            for(int k = 0; k < 6; k++)
            {
                IntPtr p_pixels = CubemapLibrary.get_edge(k);

                float[] data = new float[height*height*3];

                Marshal.Copy(p_pixels, data, 0, height * height * 3);
                                
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        float r = data[3 * (i + j * height) + 0]; if (r > 1.0f) r = 1.0f; r *= 255;
                        float g = data[3 * (i + j * height) + 1]; if (g > 1.0f) g = 1.0f; g *= 255;
                        float b = data[3 * (i + j * height) + 2]; if (b > 1.0f) b = 1.0f; b *= 255;
                        bm.SetPixel(i + k*height, j, Color.FromArgb((int)r, (int)g, (int)b));
                    }
                }
            }
            
            cubemap_picture_box.BackgroundImage = bm;

            tabs_image.SelectTab(tab_cubemap);
        }

        private void save_cubemap_button_Click(object sender, EventArgs e)
        {
            int cube_edge_i = Int32.Parse(width_text_box.Text);
            int height = cube_edge_i * 6;
            int width = cube_edge_i * 9;

            CubemapLibrary.make_cube(cube_edge_i, rotate_z_track_bar.Value);

            CubemapLibrary.blur(30);

            if (save_file_dialog.ShowDialog() == DialogResult.OK)
            {
                CubemapLibrary.save_cube_dds(save_file_dialog.FileName, Int32.Parse(width_text_box.Text));
                return;
            }

            Bitmap bm = new Bitmap(width, height);

            bm = AddSquare(cube_edge_i, bm, 1, 1, Surface.X_P);
            bm = AddSquare(cube_edge_i, bm, 0, 1, Surface.Y_P);
            bm = AddSquare(cube_edge_i, bm, 2, 1, Surface.Y_N);
            bm = AddSquare(cube_edge_i, bm, 1, 0, Surface.Z_P, 3);
            bm = AddSquare(cube_edge_i, bm, 1, 2, Surface.Z_N, 3);

            bm = AddSquare(cube_edge_i, bm, 3 + 1, 1, Surface.X_N);
            bm = AddSquare(cube_edge_i, bm, 3 + 0, 1, Surface.Y_N);
            bm = AddSquare(cube_edge_i, bm, 3 + 2, 1, Surface.Y_P);
            bm = AddSquare(cube_edge_i, bm, 3 + 1, 0, Surface.Z_P, 1);
            bm = AddSquare(cube_edge_i, bm, 3 + 1, 2, Surface.Z_N, 1);

            bm = AddSquare(cube_edge_i, bm, 6 + 1, 1, Surface.Y_P);
            bm = AddSquare(cube_edge_i, bm, 6 + 0, 1, Surface.X_N);
            bm = AddSquare(cube_edge_i, bm, 6 + 2, 1, Surface.X_P);
            bm = AddSquare(cube_edge_i, bm, 6 + 1, 0, Surface.Z_P, 2);
            bm = AddSquare(cube_edge_i, bm, 6 + 1, 2, Surface.Z_N);

            bm = AddSquare(cube_edge_i, bm, 1, 3 + 1, Surface.Y_N);
            bm = AddSquare(cube_edge_i, bm, 0, 3 + 1, Surface.X_P);
            bm = AddSquare(cube_edge_i, bm, 2, 3 + 1, Surface.X_N);
            bm = AddSquare(cube_edge_i, bm, 1, 3 + 0, Surface.Z_P);
            bm = AddSquare(cube_edge_i, bm, 1, 3 + 2, Surface.Z_N, 2);

            bm = AddSquare(cube_edge_i, bm, 3+1, 3 + 1, Surface.Z_P);
            bm = AddSquare(cube_edge_i, bm, 3+0, 3 + 1, Surface.X_P, 1);
            bm = AddSquare(cube_edge_i, bm, 3+2, 3 + 1, Surface.X_N, 3);
            bm = AddSquare(cube_edge_i, bm, 3+1, 3 + 0, Surface.Y_P, 2);
            bm = AddSquare(cube_edge_i, bm, 3+1, 3 + 2, Surface.Y_N);

            bm = AddSquare(cube_edge_i, bm, 6 + 1, 3 + 1, Surface.Z_N);
            bm = AddSquare(cube_edge_i, bm, 6 + 0, 3 + 1, Surface.X_N, 3);
            bm = AddSquare(cube_edge_i, bm, 6 + 2, 3 + 1, Surface.X_P, 1);
            bm = AddSquare(cube_edge_i, bm, 6 + 1, 3 + 0, Surface.Y_P);
            bm = AddSquare(cube_edge_i, bm, 6 + 1, 3 + 2, Surface.Y_N, 2);

            cubemap_picture_box.BackgroundImage = bm;
        }

        private Bitmap AddSquare(int cube_edge_i, Bitmap bm, int x, int y, Surface k, int turns = 0)
        {
            IntPtr p_pixels = CubemapLibrary.get_edge_t((int)k, turns);

            float[] data = new float[cube_edge_i*cube_edge_i * 3];
            Marshal.Copy(p_pixels, data, 0, cube_edge_i * cube_edge_i * 3);

            for (int i = 0; i < cube_edge_i; i++)
            {
                for (int j = 0; j < cube_edge_i; j++)
                {
                    float r = data[3 * (i + j * cube_edge_i) + 0]; if (r > 1.0f) r = 1.0f; r *= 255;
                    float g = data[3 * (i + j * cube_edge_i) + 1]; if (g > 1.0f) g = 1.0f; g *= 255;
                    float b = data[3 * (i + j * cube_edge_i) + 2]; if (b > 1.0f) b = 1.0f; b *= 255;
                    bm.SetPixel(i + x * cube_edge_i, j + y * cube_edge_i, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }
            return bm;
        }

    }
}
