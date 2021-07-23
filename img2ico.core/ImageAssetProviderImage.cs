using System;

using System.Collections.Generic;
using System.Drawing;
using System.IO;

public class ImageAssetProviderImage : ImageAssetProvider
{
    public static System.Drawing.Imaging.ImageFormat TargetFormat = System.Drawing.Imaging.ImageFormat.Png;

    public ImageAssetProviderImage(Image img)
    {
        WIDTH = (byte)img.Width;
        HEIGHT = (byte)img.Height;

        using (var ms = new MemoryStream())
        {
            img.Save(ms, TargetFormat);
            ms.Flush();
            ImageData = ms.ToArray();
        }
    }

    public override byte[] ImageData { get; }//construct set..
}
