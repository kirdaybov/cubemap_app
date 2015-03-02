using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace cubemap_app
{
    class CubemapLibrary
    {        
        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void open_hdri(String filename);

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void make_cube(int cube_edge_i);

        [DllImport("hdri_cubemap.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void save_cube_dds(String filename, int cube_edge_i);
    }
}
