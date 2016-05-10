using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuffmanCompression
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*
                to DO : 
                    - Fix Decompressor
                    - add dirctory choose to (ZIPPEd/UNZIPPED) File 
                    - add new Features(Types)

            
            */
        }
    }
}
