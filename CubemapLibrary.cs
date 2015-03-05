using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace cubemap_app
{
    enum Surface
    {
    	X_P = 0,
    	X_N,
    	Y_P,
    	Y_N,
    	Z_P,
    	Z_N
    }

    class CubemapLibrary
    {        
        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void open_hdri(String filename);

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void make_cube(int cube_edge_i, float degrees);

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void save_cube_dds(String filename, int cube_edge_i);

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int get_width();

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int get_height();

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr get_pixels();

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int get_float_size();

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr get_edge(int i);

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr get_edge_t(int i, int turns);

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void blur(int power);
    }
}
