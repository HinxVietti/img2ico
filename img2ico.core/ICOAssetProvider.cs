using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class ICOAssetProvider : Collection<ImageAssetProvider>
{
    /// <summary>
    /// Reserved. Must always be 0.
    /// </summary>
    public short Reserved { get; set; } = 0;
    /// <summary>
    /// Specifies image type: 1 for icon (.ICO) image, 2 for cursor (.CUR) image. Other values are invalid.
    /// </summary>
    public short Type { get; set; } = 1;
    /// <summary>
    /// Specifies number of images in the file.
    /// </summary>
    public short EntryCount => (short)Count;
}
