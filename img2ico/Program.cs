using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace img2ico
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
                Run(args);
        }


        static void Run(string[] args)
        {
            ///sample program.. files to 
            string savefile = "icon.ico";
            if (File.Exists(args[0]))
            {
                string fName = new FileInfo(args[0]).FullName;
                string dir = Path.GetDirectoryName(fName);
                string nameWidthoutExt = Path.GetFileNameWithoutExtension(fName);
                savefile = $"{dir}/{nameWidthoutExt}.ico";
            }

            if (File.Exists(savefile))
            {
                var tmpInfo = new FileInfo(savefile);
                var tmpFullName = tmpInfo.FullName;
                var tmpDir = Path.GetDirectoryName(tmpFullName);
                var tmpNameWithoutExt = Path.GetFileNameWithoutExtension(tmpFullName);

                int index = 0;
                string tmpName = $"{tmpDir}/{tmpNameWithoutExt}_{index++}.ico";
                while (File.Exists(tmpName) && index < 999)
                    tmpName = $"{tmpDir}/{tmpNameWithoutExt}_{index++}.ico";
                if (index >= 999)
                {
                    System.Windows.Forms.MessageBox.Show("致命错误, 没有可用的文件夹,无法保存ico文件", "致命错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    throw new Exception("Unable get save file name.. because index of exist file out of range 999");
                }
                savefile = tmpName;
            }
            else
                savefile = new FileInfo(savefile).FullName;

            using (var stream = new FileStream(savefile, FileMode.CreateNew))
            {
                var ico = new ICOAssetProvider();
                foreach (var fileName in args)
                {
                    if (File.Exists(fileName))
                    {
                        var img = Image.FromFile(fileName);
                        if (img != null)
                            ico.Add(new ImageAssetProviderImage(img));
                    }
                }
                ico.CopyTo2(stream);
                stream.Flush();
            }

            Console.WriteLine("Finished. ico save to " + savefile);
        }



    }



}
