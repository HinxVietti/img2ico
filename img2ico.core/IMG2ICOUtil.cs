using System;
using System.Collections.Generic;
using System.IO;
using static System.BitConverter;

public static class IMG2ICOUtil
{
    /* ICO FILE Format Desc.
     
            ┌
        ----|  header
            └
                ┌
            ----| Entry
                └    
                ┌
            ----| Entry
                └    
                ┌
            ----| ...
                └    
                    ┌
                ----| Data
                    └    
                    ┌
                ----| Data
                    └    
                    ┌
                ----| .....
                    └    
        
        256x256 will be saved as 32bpp 8bit alpha
        48x48   will be saved as 32bpp 8bit alpha
        48x48   will be saved as 8bpp 1bit alpha
        32x32   will be saved as 32bpp 8bit alpha
        32x32   will be saved as 8bpp 1bit alpha
        32x32   will be saved as 4bpp 1bit alpha
        16x16   will be saved as 32bpp 8bit alpha
        16x16   will be saved as 8bpp 1bit alpha
        16x16   will be saved as 4bpp 1bit alpha
         */

    /* Entry

       Offset#	Size	Purpose
       0	1B	Specifies image width in pixels. Can be any number between 0 and 255. Value 0 means image width is 256 pixels.
       1	1B	Specifies image height in pixels. Can be any number between 0 and 255. Value 0 means image height is 256 pixels.
       2	1B	Specifies number of colors in the color palette. Should be 0 if the image does not use a color palette.
       3	1B	Reserved. Should be 0.[Notes 2]
       4	2B	In ICO format: Specifies color planes. Should be 0 or 1.[Notes 3]
               In CUR format: Specifies the horizontal coordinates of the hotspot in number of pixels from the left.
       6	2B	In ICO format: Specifies bits per pixel. [Notes 4]
               In CUR format: Specifies the vertical coordinates of the hotspot in number of pixels from the top.
       8	4B	Specifies the size of the image's data in bytes
       12	4B	Specifies the offset of BMP or PNG data from the beginning of the ICO/CUR file
    */

    /* Header
        Offset#	Size	Purpose
        0	2B	Reserved. Must always be 0.
        2	2B	Specifies image type: 1 for icon (.ICO) image, 2 for cursor (.CUR) image. Other values are invalid.
        4	2B	Specifies number of images in the file.
     */


    public static void CopyTo2(this ICOAssetProvider provider, Stream stream)
    {
        stream.Position = 0;

        var _D_S_Rev = GetBytes(provider.Reserved);         //OFFSET:0  L:2
        var _D_S_Type = GetBytes(provider.Type);            //OFFSET:2  L:2
        var _D_S_Ents = GetBytes(provider.EntryCount);      //OFFSET:4  L:2

        stream.Write(_D_S_Rev, 0, 2);
        stream.Write(_D_S_Type, 0, 2);
        stream.Write(_D_S_Ents, 0, 2);

        // one entry header 16B
        int rawDataOffset = 6 + 16 * provider.EntryCount;

        for (int i = 0; i < provider.Count; i++)
        {
            var entry = provider[i];
            entry.CopyEntryTo(rawDataOffset, stream);
            rawDataOffset = rawDataOffset + entry.Size;
        }
        for (int i = 0; i < provider.Count; i++)
        {
            var entry = provider[i];
            entry.CopyDataTo(stream);
        }
    }

    [Obsolete()]
    public static void CopyTo(this ICOAssetProvider provider, Stream stream)
    {
        stream.Position = 0;

        var _D_S_Rev = GetBytes(provider.Reserved);         //OFFSET:0  L:2
        var _D_S_Type = GetBytes(provider.Type);            //OFFSET:2  L:2
        var _D_S_Ents = GetBytes(provider.EntryCount);      //OFFSET:4  L:2

        stream.Write(_D_S_Rev, 0, 2);
        stream.Write(_D_S_Type, 0, 2);
        stream.Write(_D_S_Ents, 0, 2);

        for (int i = 0; i < provider.Count; i++)
        {
            var entry = provider[i];
            entry.CopyTo(stream);
        }
    }

    [Obsolete()]
    public static void CopyTo(this ImageAssetProvider entry, Stream stream)
    {
        var _D_Plans = GetBytes(entry.ColorPlanes);
        var _D_pixels = GetBytes(entry.Pixels);
        var _D_size = GetBytes(entry.Size);

        stream.WriteByte(entry.WIDTH);                     //OFFSET: 0   L: 1
        stream.WriteByte(entry.HEIGHT);                    //OFFSET: 1   L: 1 
        stream.WriteByte(entry.Palette);                   //OFFSET: 2   L: 1
        stream.WriteByte(entry.Reserved);                  //OFFSET: 3   L: 1

        stream.Write(_D_Plans, 0, 2);                      //OFFSET: 4   L: 2
        stream.Write(_D_pixels, 0, 2);                     //OFFSET: 6   L: 2
        stream.Write(_D_size, 0, 4);                       //OFFSET: 8   L: 4

        entry.Offset = (int)stream.Position + 4;
        var _D_offset = GetBytes(entry.Offset);            //OFFSET: 12  L: 4
        stream.Write(_D_offset, 0, 4);

        stream.Write(entry.ImageData, 0, entry.Size);
    }


    public static void CopyEntryTo(this ImageAssetProvider entry, int offset, Stream stream)
    {
        var _D_Plans = GetBytes(entry.ColorPlanes);
        var _D_pixels = GetBytes(entry.Pixels);
        var _D_size = GetBytes(entry.Size);

        stream.WriteByte(entry.WIDTH);                     //OFFSET: 0   L: 1
        stream.WriteByte(entry.HEIGHT);                    //OFFSET: 1   L: 1 
        stream.WriteByte(entry.Palette);                   //OFFSET: 2   L: 1
        stream.WriteByte(entry.Reserved);                  //OFFSET: 3   L: 1

        stream.Write(_D_Plans, 0, 2);                      //OFFSET: 4   L: 2
        stream.Write(_D_pixels, 0, 2);                     //OFFSET: 6   L: 2
        stream.Write(_D_size, 0, 4);                       //OFFSET: 8   L: 4

        entry.Offset = offset;
        var _D_offset = GetBytes(entry.Offset);            //OFFSET: 12  L: 4
        stream.Write(_D_offset, 0, 4);
    }

    public static void CopyDataTo(this ImageAssetProvider entry, Stream stream)
    {
        //check ?
        if (stream.Position == entry.Offset)
            stream.Write(entry.ImageData, 0, entry.Size);
        else
            throw new Exception($"Entry Offset CheckError true:{stream.Position},false:{entry.Offset}");
    }



}
