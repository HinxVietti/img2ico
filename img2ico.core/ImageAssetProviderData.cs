using System;
using System.Collections.Generic;

public class ImageAssetProviderData : ImageAssetProvider
{
    public override byte[] ImageData { get;/* constructor set ; */ }


    public ImageAssetProviderData(byte[] data, byte width, byte height)
    {
        ImageData = data;
        WIDTH = width;
        HEIGHT = height;
    }

    public static ImageAssetProvider Create(byte[] data, byte width, byte height)
    {
        if (data != null)
        {
            return new ImageAssetProviderData(data, width, height);
        }
        return null;
    }

}
