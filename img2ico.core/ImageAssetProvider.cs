using System;
using System.Collections.Generic;

public abstract class ImageAssetProvider
{
    public byte WIDTH { get; set; }
    public byte HEIGHT { get; set; }
    /// <summary>
    /// Specifies number of colors in the color palette. Should be 0 if the image does not use a color palette.
    /// </summary>
    public byte Palette { get; set; } = 0;
    /// <summary>
    /// Although Microsoft's technical documentation states that this value must be zero, the icon encoder built into .NET (System.Drawing.Icon.Save) sets this value to 255. It appears that the operating system ignores this value altogether.
    /// </summary>
    public byte Reserved { get; set; } = 255;
    /// <summary>
    /// Setting the color planes to 0 or 1 is treated equivalently by the operating system, but if the color planes are set higher than 1, this value should be multiplied by the bits per pixel to determine the final color depth of the image. It is unknown if the various Windows operating system versions are resilient to different color plane values.
    /// </summary>
    public short ColorPlanes { get; set; } = 0;
    /// <summary>
    /// Specifies bits per pixel;
    /// The bits per pixel might be set to zero, but can be inferred from the other data; specifically, if the bitmap is not PNG compressed, then the bits per pixel can be calculated based on the length of the bitmap data relative to the size of the image. If the bitmap is PNG compressed, the bits per pixel are stored within the PNG data. It is unknown if the various Windows operating system versions contain logic to infer the bit depth for all possibilities if this value is set to zero.
    /// </summary>
    public short Pixels { get; set; } = 0;
    /// <summary>
    /// Image Size (bytes)
    /// </summary>
    public int Size => ImageData.Length;
    /// <summary>
    /// Raw data offset in ico file. update while writing ico stream . just ignore.
    /// </summary>
    public int Offset { get; set; }

    public abstract byte[] ImageData { get; }


}
