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
using System.IO;

namespace cubemap_app
{
    public partial class Main_Form : Form
    {
        private int cube_edge_i = 256;

        public Main_Form()
        {
            InitializeComponent();
            CubemapLibrary.init();
        }

        private void open_file_button_Click(object sender, EventArgs e)
        {
            if (open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                LoadPanorama(open_file_dialog.FileName);                
            }
        }

        private void generate_cubemap_button_Click(object sender, EventArgs e)
        {
            UpdateCubemap();
        }

        private void save_cubemap_button_Click(object sender, EventArgs e)
        {   
            if (save_to_input_check_box.Checked)
            {                
                CubemapLibrary.save_cube_dds(MakeDDSName(open_file_dialog.FileName), cube_edge_i);
                MessageBox.Show("Successfully saved!");
            }
            else
            {
                if (save_file_dialog.ShowDialog() == DialogResult.OK)
                {
                    CubemapLibrary.save_cube_dds(save_file_dialog.FileName, cube_edge_i);
                    return;
                }
            }
        }

        private void DrawPreview()
        {
            IntPtr render = CubemapLibrary.render();
            
            int width = 1024;
            int height = 1024;

            float[] render_p = new float[width * height * 3];
            Marshal.Copy(render, render_p, 0, width * height * 3);

            Bitmap bm = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            System.Drawing.Imaging.BitmapData bm_data = bm.LockBits(new Rectangle(0, 0, width, height), System.Drawing.Imaging.ImageLockMode.ReadWrite, bm.PixelFormat);

            IntPtr Iptr = bm_data.Scan0;
            byte[] pixels = new byte[width * height * 4];

            Random rand = new Random();

            unsafe
            {
                byte* pixel_begin = (byte*)Iptr;
                for (int i = 0; i < height; i++)
                {
                    byte* pixel_cur_line = pixel_begin + i * bm_data.Stride;
                    for (int j = 0; j < width; j++)
                    {
                        //int index = 4 * (i + j * width);
                        float r = render_p[(j + (height - i - 1) * width) * 3    ]; if(r > 1) r = 1.0f;
                        float g = render_p[(j + (height - i - 1) * width) * 3 + 1]; if(g > 1) g = 1.0f;
                        float b = render_p[(j + (height - i - 1) * width) * 3 + 2]; if(b > 1) b = 1.0f;
                        //
                        pixel_cur_line[4*j    ] = (byte)(255*r);
                        pixel_cur_line[4*j + 1] = (byte)(255*g);
                        pixel_cur_line[4*j + 2] = (byte)(255*b);
                        pixel_cur_line[4 * j + 3] = 255;
                    }
                }
            }


            //Marshal.Copy(pixels, 0, Iptr, width * height * 4);
            bm.UnlockBits(bm_data);

            preview_picture_box.BackgroundImage = bm;
        }

        private void DrawCubemap()
        {
            int height = cube_edge_i;
            int width = height * 6;            

            Bitmap bm = new Bitmap(width, height);

            for (int k = 0; k < 6; k++)
            {
                IntPtr p_pixels = CubemapLibrary.get_blurred_edge(k);

                float[] data = new float[height * height * 3];

                Marshal.Copy(p_pixels, data, 0, height * height * 3);

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        float r = data[3 * (i + j * height) + 0]; if (r > 1.0f) r = 1.0f; r *= 255;
                        float g = data[3 * (i + j * height) + 1]; if (g > 1.0f) g = 1.0f; g *= 255;
                        float b = data[3 * (i + j * height) + 2]; if (b > 1.0f) b = 1.0f; b *= 255;
                        bm.SetPixel(i + k * height, j, Color.FromArgb((int)r, (int)g, (int)b));
                    }
                }
            }
                        
            cubemap_picture_box.BackgroundImage = bm;

            tabs_image.SelectTab(tab_cubemap);
        }

        private void DrawCrosses()
        {
            int height = cube_edge_i * 6;
            int width = cube_edge_i * 9;

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

            bm = AddSquare(cube_edge_i, bm, 3 + 1, 3 + 1, Surface.Z_P);
            bm = AddSquare(cube_edge_i, bm, 3 + 0, 3 + 1, Surface.X_P, 1);
            bm = AddSquare(cube_edge_i, bm, 3 + 2, 3 + 1, Surface.X_N, 3);
            bm = AddSquare(cube_edge_i, bm, 3 + 1, 3 + 0, Surface.Y_P, 2);
            bm = AddSquare(cube_edge_i, bm, 3 + 1, 3 + 2, Surface.Y_N);

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

        private void rotate_z_track_bar_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void rotate_z_track_bar_MouseCaptureChanged(object sender, EventArgs e)
        {
            UpdateCubemap();
        }

        private void blur_track_bar_MouseCaptureChanged(object sender, EventArgs e)
        {
            UpdateCubemap();
        }

        private String MakeDDSName(String FileName)
        {
            String filename = FileName;
            filename = filename.Remove(filename.Length - 4, 4);
            filename += ".dds";
            return filename;
        }

        private void LoadPanorama(String FileName)
        {
            if (!FileName.Substring(FileName.Length - 4, 4).Equals(".hdr"))
            {
                MessageBox.Show("Wrong filename. Make sure it's an .hdr file");
                return;
            }

            generate_cubemap_button.Enabled = true;            

            CubemapLibrary.open_hdri(FileName);
            IntPtr p_pixels = CubemapLibrary.get_pixels();
            int width = CubemapLibrary.get_width();
            int height = CubemapLibrary.get_height();

            float[] data = new float[width * height * 3];

            Marshal.Copy(p_pixels, data, 0, width * height * 3);

            Bitmap bm = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            System.Drawing.Imaging.BitmapData bm_data = bm.LockBits(new Rectangle(0, 0, width, height), System.Drawing.Imaging.ImageLockMode.ReadWrite, bm.PixelFormat);

            IntPtr Iptr = bm_data.Scan0;
            byte[] pixels = new byte[width*height*3];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int index = 3 * (i + j * width);
                    float r = data[index + 0]; if (r > 1.0f) r = 1.0f; r *= 255;
                    float g = data[index + 1]; if (g > 1.0f) g = 1.0f; g *= 255;
                    float b = data[index + 2]; if (b > 1.0f) b = 1.0f; b *= 255;

                    pixels[index] =     (byte)b;
                    pixels[index + 1] = (byte)g;
                    pixels[index + 2] = (byte)r;
                }
            }

            Marshal.Copy(pixels, 0, Iptr, width * height * 3);
            bm.UnlockBits(bm_data);

            panorama_picture_box.BackgroundImage = bm;
            input_file_text_box.Text = FileName;
        }

        private void UpdateCubemap()
        {
            cube_edge_i = Int32.Parse(edge_size_text_box.Text);

            CubemapLibrary.make_cube(cube_edge_i, rotate_z_track_bar.Value*10);
            CubemapLibrary.blur(blur_track_bar.Value);
            DrawCubemap();
            DrawPreview();

            EnableCubemapEditing(true);
        }

        private void EnableCubemapEditing(bool Enable)
        {
            save_cubemap_button.Enabled = true;
            blur_track_bar.Enabled = true;
            rotate_z_track_bar.Enabled = true;
        }

        private void input_folder_button_Click(object sender, EventArgs e)
        {
            if(input_folder_browser_dialog.ShowDialog() == DialogResult.OK)
            {
                input_folder_text_box.Text = input_folder_browser_dialog.SelectedPath + "\\";
            }
        }

        private void output_folder_button_Click(object sender, EventArgs e)
        {
            if (output_folder_browser_dialog.ShowDialog() == DialogResult.OK)
            {
                output_folder_text_box.Text = output_folder_browser_dialog.SelectedPath + "\\";
            }
        }

        private void process_batch_button_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(input_folder_text_box.Text))
            {
                MessageBox.Show("Input directory doesn't exist");
                return;
            }

            if (!Directory.Exists(output_folder_text_box.Text))
            {
                MessageBox.Show("Output directory doesn't exist");
                return;
            }

            DirectoryInfo InputInfo = new DirectoryInfo(input_folder_text_box.Text);
            IEnumerable<FileInfo> Files = InputInfo.EnumerateFiles("*.hdr");
            foreach(FileInfo Info in Files)
            {
                LoadPanorama(Info.FullName);
                UpdateCubemap();
                CubemapLibrary.save_cube_dds(output_folder_text_box.Text + MakeDDSName(Info.Name), cube_edge_i);
            }
        }

        private void edge_size_text_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void edge_size_text_box_Leave(object sender, EventArgs e)
        {
            if (!Int32.TryParse(edge_size_text_box.Text, out cube_edge_i) || cube_edge_i <= 0 || cube_edge_i > 2048)
            {
                MessageBox.Show("Edge size should be in range from 1 to 2048");
                cube_edge_i = 256;
                edge_size_text_box.Text = cube_edge_i.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //DrawPreview();
            return;
            //Graphics g = Graphics.FromImage(panorama_picture_box.Image);

            int width = 2048;
            int height = 2048;
            
            Bitmap bm = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            
            System.Drawing.Imaging.BitmapData bm_data = bm.LockBits(new Rectangle(0, 0, width, height), System.Drawing.Imaging.ImageLockMode.ReadWrite, bm.PixelFormat);

            IntPtr Iptr = bm_data.Scan0;
            byte[] pixels = new byte[width * height * 4];

            Random rand = new Random();

            unsafe 
            {
                byte* pixel_begin = (byte*)Iptr;
                for (int i = 0; i < width; i++)
                {
                    byte* pixel_cur_line = pixel_begin + i * bm_data.Stride;
                    for (int j = 0; j < height; j += 4)
                    {
                        //int index = 4 * (i + j * width);
                        //float r = rand.Next(255); //r *= 255;
                        //float g = rand.Next(255); //g *= 255;
                        //float b = rand.Next(255); //b *= 255;
                        //
                        pixel_cur_line[j] = 128;
                        pixel_cur_line[j + 1] = (byte)(i % 255);
                        pixel_cur_line[j + 2] = (byte)(j % 255);
                        pixel_cur_line[j + 3] = (byte)245;
                    }
                }
            }
            

            //Marshal.Copy(pixels, 0, Iptr, width * height * 4);
            bm.UnlockBits(bm_data);

            preview_picture_box.BackgroundImage = bm;
        }

    }
}
