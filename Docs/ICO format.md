# [ICO (file format)]( https://en.wikipedia.org/wiki/ICO_(file_format))

From Wikipedia, the free encyclopedia

[Jump to navigation](https://en.wikipedia.org/wiki/ICO_(file_format)#mw-head)[Jump to search](https://en.wikipedia.org/wiki/ICO_(file_format)#searchInput)

| [Filename extension](https://en.wikipedia.org/wiki/Filename_extension) | .ico                                                         |
| :----------------------------------------------------------- | ------------------------------------------------------------ |
| [Internet media type](https://en.wikipedia.org/wiki/Media_type) | `image/x-icon`[[1\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-mimesniff-1) (but [see below](https://en.wikipedia.org/wiki/ICO_(file_format)#MIME_type)) |
| [Uniform Type Identifier (UTI)](https://en.wikipedia.org/wiki/Uniform_Type_Identifier) | com.microsoft.ico                                            |
| Developed by                                                 | [Microsoft](https://en.wikipedia.org/wiki/Microsoft)         |
| Type of format                                               | [Graphics file format](https://en.wikipedia.org/wiki/Graphics_file_format) for [computer icons](https://en.wikipedia.org/wiki/Computer_icon) |
| [Container for](https://en.wikipedia.org/wiki/Digital_container_format) | [BMP](https://en.wikipedia.org/wiki/BMP_file_format) and [PNG](https://en.wikipedia.org/wiki/Portable_Network_Graphics) |
| Extended to                                                  | CUR                                                          |

| [Filename extension](https://en.wikipedia.org/wiki/Filename_extension) | .cur                                                         |
| :----------------------------------------------------------- | ------------------------------------------------------------ |
| [Internet media type](https://en.wikipedia.org/wiki/Media_type) | image/vnd.microsoft.icon                                     |
| [Uniform Type Identifier (UTI)](https://en.wikipedia.org/wiki/Uniform_Type_Identifier) | com.microsoft.cur                                            |
| Developed by                                                 | Microsoft                                                    |
| Type of format                                               | Graphics file format for [mouse cursors](https://en.wikipedia.org/wiki/Cursor_(computers)#Mouse_cursor) |
| [Container for](https://en.wikipedia.org/wiki/Digital_container_format) | BMP                                                          |
| Extended from                                                | ICO                                                          |

The **ICO file format** is an [image file format](https://en.wikipedia.org/wiki/Image_file_format) for [computer icons](https://en.wikipedia.org/wiki/Computer_icon) in [Microsoft Windows](https://en.wikipedia.org/wiki/Microsoft_Windows). ICO files contain one or more small images at multiple sizes and [color depths](https://en.wikipedia.org/wiki/Color_depth), such that they may be [scaled](https://en.wikipedia.org/wiki/Image_scaling) appropriately. In Windows, all [executables](https://en.wikipedia.org/wiki/Executable) that display an icon to the user, on the desktop, in the Start Menu, or in Windows Explorer, must carry the icon in ICO format.

The **CUR file format** is an almost identical image file format for non-animated [cursors](https://en.wikipedia.org/wiki/Cursor_(computing)) in Microsoft Windows. The only differences between these two file formats are the bytes used to identify them and the addition of a hotspot in the CUR format header; the hotspot is defined as the pixel offset (in x,y coordinates) from the top-left corner of the cursor image where the user is actually pointing the mouse.

## Contents



- [1History](https://en.wikipedia.org/wiki/ICO_(file_format)#History)
- [2MIME type](https://en.wikipedia.org/wiki/ICO_(file_format)#MIME_type)
- 3Icon resource structure
  - [3.1Outline](https://en.wikipedia.org/wiki/ICO_(file_format)#Outline)
  - [3.2PNG format](https://en.wikipedia.org/wiki/ICO_(file_format)#PNG_format)
- [4Icon library](https://en.wikipedia.org/wiki/ICO_(file_format)#Icon_library)
- [5See also](https://en.wikipedia.org/wiki/ICO_(file_format)#See_also)
- [6Notes](https://en.wikipedia.org/wiki/ICO_(file_format)#Notes)
- [7References](https://en.wikipedia.org/wiki/ICO_(file_format)#References)
- [8External links](https://en.wikipedia.org/wiki/ICO_(file_format)#External_links)

## History[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=1)]

Icons introduced in [Windows 1.0](https://en.wikipedia.org/wiki/Windows_1.0) were 32×32 pixels in size and were monochrome.[[2\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-2) Support for 16 colors was introduced in [Windows 3.0](https://en.wikipedia.org/wiki/Windows_3.0).[*[citation needed](https://en.wikipedia.org/wiki/Wikipedia:Citation_needed)*]

[Win32](https://en.wikipedia.org/wiki/Win32) introduced support for storing icon images of up to [16.7 million colors (TrueColor)](https://en.wikipedia.org/wiki/32-bit_color) and up to 256x256 pixels in dimensions.[[3\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-win95-3) Windows 95 also introduced a new Device Independent Bitmap (DIB) engine.[[4\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-4) However, 256 color was the default icon color depth in Windows 95. It was possible to enable [65535 color (Highcolor)](https://en.wikipedia.org/wiki/RGB_color_model#16-bit_RGB_(Highcolor)) icons by either modifying the *Shell Icon BPP* value in the registry[[3\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-win95-3)[[5\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-5) or by purchasing [Microsoft Plus!](https://en.wikipedia.org/wiki/Microsoft_Plus!) for Windows 95. The *Shell Icon Size* value allows using larger icons in place of 32×32 icons and the *Shell Small Icon Size* value allows using custom sizes in place of 16×16 icons.[[3\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-win95-3) Thus, a single icon file could store images of any size from 1×1 pixel up to 256×256 pixels (including non-square sizes) with 2 (rarely used),16, 256, 65535, or 16.7 million colors; but the shell could not display very large sized icons. The notification area of the Windows [taskbar](https://en.wikipedia.org/wiki/Taskbar) was limited to 16 color icons by default until [Windows Me](https://en.wikipedia.org/wiki/Windows_Me) when it was updated to support high color icons.

[Windows XP](https://en.wikipedia.org/wiki/Windows_XP) added support for [32-bit color](https://en.wikipedia.org/wiki/RGB_color_model#32-bit_RGBA_(RGB_plus_alpha_channel)) (16.7 million colors plus alpha channel transparency) icon images, thus allowing semitransparent areas like [shadows](https://en.wikipedia.org/wiki/Drop_shadow), [anti-aliasing](https://en.wikipedia.org/wiki/Spatial_anti-aliasing), and glass-like effects to be drawn in an icon. Windows XP, by default, employs 48×48 pixel icons in [Windows Explorer](https://en.wikipedia.org/wiki/Windows_Explorer). Windows XP can be forced to use icons as large as 256×256 by modifying the *Shell icon size* value but this would cause all 32×32 icons throughout the shell to be upscaled.[[3\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-win95-3) Microsoft only recommended icon sizes up to 48×48 pixels for Windows XP.[[6\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-winxp-6) Windows XP can downscale 256×256 and larger icons if no closer image size is available.[[3\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-win95-3)

[Windows Vista](https://en.wikipedia.org/wiki/Windows_Vista) added a 256×256-pixel icon view to Windows Explorer, as well as support for the [compressed](https://en.wikipedia.org/wiki/Data_compression) [PNG](https://en.wikipedia.org/wiki/Portable_Network_Graphics) format. Although compression is not required, Microsoft recommends that all 256×256 icons in ICO files should be stored in PNG format to reduce the overall size of the file.[[7\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-vista-7) The Windows Vista Explorer supports smoothly scaling icons to non-standard sizes which are rendered on the fly even if an image is not present for that size in the icon file. The Windows Vista shell adds a slider for "zooming" the icon sizes in and out. With users using higher resolutions and high DPI modes, larger icon formats (such as 256×256) are recommended.[[7\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-vista-7)

## MIME type[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=2)]

While the [IANA](https://en.wikipedia.org/wiki/Internet_Assigned_Numbers_Authority)-registered [MIME type](https://en.wikipedia.org/wiki/MIME_type) for ICO files is `image/vnd.microsoft.icon`,[[8\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-Butcher-8) it was submitted to IANA in 2003 by a third party and is not recognised by Microsoft software, which uses `image/x-icon` instead.[[9\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-ericlaw-9) Erroneous types `image/ico`, `image/icon`, `text/ico` and `application/ico` have also been seen in use.[[8\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-Butcher-8)

## Icon resource structure[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=3)]

An ICO or CUR file is made up of an ICONDIR ("Icon directory") structure, containing an ICONDIRENTRY structure for each image in the file, followed by a contiguous block of all image bitmap data (which may be in either [Windows BMP](https://en.wikipedia.org/wiki/BMP_file_format) format, excluding the BITMAPFILEHEADER structure, or in [PNG](https://en.wikipedia.org/wiki/Portable_Network_Graphics) format, stored in its entirety).[[3\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-win95-3)

Images with less than 32 bits of color depth follow a particular format: the image is encoded as a single image consisting of a color mask (the "XOR mask") together with an opacity mask (the "AND mask").[[6\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-winxp-6)[*[failed verification](https://en.wikipedia.org/wiki/Wikipedia:Verifiability)*] The XOR mask must precede the AND mask inside the bitmap data; if the image is stored in bottom-up order (which it most likely is), the XOR mask would be drawn below the AND mask. The AND mask is 1 bit per pixel, regardless of the color depth specified by the BMP header, and specifies which pixels are fully transparent and which are fully opaque. The XOR mask conforms to the bit depth specified in the BMP header and specifies the numerical color or palette value for each pixel. Together, the AND mask and XOR mask make for a non-transparent image representing an image with 1-bit transparency; they also allow for inversion of the background. The height for the image in the ICONDIRENTRY structure of the ICO/CUR file takes on that of the intended image dimensions (after the masks are composited), whereas the height in the BMP header takes on that of the two mask images combined (before they are composited). Therefore, the masks must each be of the same dimensions, and the height specified in the BMP header must be exactly twice the height specified in the ICONDIRENTRY structure.[*[citation needed](https://en.wikipedia.org/wiki/Wikipedia:Citation_needed)*]

32-bit images (including 32-bit BITMAPINFOHEADER-format BMP images[[Notes 1\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-10)) are specifically a 24-bit image with the addition of an 8-bit channel for [alpha compositing](https://en.wikipedia.org/wiki/Alpha_compositing). Thus, in 32-bit images, the AND mask is not required, but recommended for consideration. Windows XP and higher will use a 32-bit image in less than [True color](https://en.wikipedia.org/wiki/24-bit_color) mode by constructing an AND mask based on the alpha channel (if one does not reside with the image already) if no 24-bit version of the image is supplied in the ICO/CUR file. However, earlier versions of Windows interpret all pixels with 100% opacity unless an AND mask is supplied with the image. Supplying a custom AND mask will also allow for tweaking and hinting by the icon author. Even if the AND mask is not supplied, if the image is in Windows BMP format, the BMP header must still specify a doubled height.

### Outline[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=4)]

All values in ICO/CUR files are represented in [little-endian](https://en.wikipedia.org/wiki/Little-endian) byte order.

**Header**

| Offset# | Size |                           Purpose                            |
| :-----: | :--: | :----------------------------------------------------------: |
|    0    |  2B  |                 Reserved. Must always be 0.                  |
|    2    |  2B  | Specifies image type: 1 for icon (.ICO) image, 2 for cursor (.CUR) image. Other values are invalid. |
|    4    |  2B  |           Specifies number of images in the file.            |

**Structure of image directory**

| **Image #1** | Entry for the first image  |
| ------------ | -------------------------- |
| **Image #2** | Entry for the second image |
| **...**      |                            |
| **Image #n** | Entry for the last image   |



Image entry

| Offset# | Size |                           Purpose                            |
| :-----: | :--: | :----------------------------------------------------------: |
|    0    |  1B  | Specifies image width in pixels. Can be any number between 0 and 255. Value 0 means image width is 256 pixels. |
|    1    |  1B  | Specifies image height in pixels. Can be any number between 0 and 255. Value 0 means image height is 256 pixels. |
|    2    |  1B  | Specifies number of colors in the color palette. Should be 0 if the image does not use a color palette. |
|    3    |  1B  | Reserved. Should be 0.[[Notes 2\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-11) |
|    4    |  2B  | **In ICO format:** Specifies color planes. Should be 0 or 1.[[Notes 3\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-12)**In CUR format:** Specifies the horizontal coordinates of the hotspot in number of pixels from the left. |
|    6    |  2B  | **In ICO format:** Specifies bits per pixel. [[Notes 4\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-13)**In CUR format:** Specifies the vertical coordinates of the hotspot in number of pixels from the top. |
|    8    |  4B  |       Specifies the size of the image's data in bytes        |
|   12    |  4B  | Specifies the [offset](https://en.wikipedia.org/wiki/Offset_(computer_science)) of BMP or PNG data from the beginning of the ICO/CUR file |

**Referenced image data**

All image data referenced by entries in the image directory proceed directly after the image directory. It is customary practice to store them in the same order as defined in the image directory.

Recall that if an image is stored in BMP format, it must exclude the opening BITMAPFILEHEADER structure, whereas if it is stored in PNG format, it must be stored in its entirety.

Note that the height of the BMP image must be twice the height declared in the image directory. The second half of the bitmap should be an AND mask for the existing screen pixels, with the output pixels given by the formula Output = (Existing AND Mask) XOR Image. Set the mask to be zero everywhere for a clean overwrite.

### PNG format[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=5)]

The ability to read [PNG](https://en.wikipedia.org/wiki/Portable_Network_Graphics) images from ICO and CUR format images was introduced in [Windows Vista](https://en.wikipedia.org/wiki/Windows_Vista).[[7\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-vista-7) A PNG image can be stored in the image in the same way as done for a standard Windows BMP format image, with the exception that the PNG image must be stored in its entirety, with its file header.

## Icon library[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=6)]

An **icon library** is a way to package Windows icons. It is typically a 16-bit [New Executable](https://en.wikipedia.org/wiki/New_Executable) or a 32-bit [Portable Executable](https://en.wikipedia.org/wiki/Portable_Executable) binary file having .ICL extension with icon [resources](https://en.wikipedia.org/wiki/Resource_(Windows)) being the packaged icons. [Windows Vista](https://en.wikipedia.org/wiki/Windows_Vista) and later versions do not support viewing icons from 16-bit ([New Executable](https://en.wikipedia.org/wiki/New_Executable)) files.[[10\]](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_note-14)

## See also[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=7)]

- [Apple Icon Image format](https://en.wikipedia.org/wiki/Apple_Icon_Image_format)
- [BMP file format](https://en.wikipedia.org/wiki/BMP_file_format)
- [Computer icon](https://en.wikipedia.org/wiki/Computer_icon)
- [Favicon](https://en.wikipedia.org/wiki/Favicon)
- [List of icon software](https://en.wikipedia.org/wiki/List_of_icon_software)

## Notes[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=8)]

1. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-10)** The classic BITMAPINFOHEADER bitmap format supports storing images with 32 bits per pixel. When saved as a standalone .BMP file, "the high byte in each [pixel] is not used". However, when this same data is stored inside a ICO or CUR file, Windows XP (the first Windows version to support ICO/CUR files with more than 1 bit of transparency) and above interpret this byte as an alpha value.
2. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-11)** Although Microsoft's technical documentation states that this value must be zero, the icon encoder built into .NET (System.Drawing.Icon.Save) sets this value to 255. It appears that the operating system ignores this value altogether.
3. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-12)** Setting the color planes to 0 or 1 is treated equivalently by the operating system, but if the color planes are set higher than 1, this value should be multiplied by the bits per pixel to determine the final color depth of the image. It is unknown if the various Windows operating system versions are resilient to different color plane values.
4. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-13)** The bits per pixel might be set to zero, but can be inferred from the other data; specifically, if the bitmap is not PNG compressed, then the bits per pixel can be calculated based on the length of the bitmap data relative to the size of the image. If the bitmap is PNG compressed, the bits per pixel are stored within the PNG data. It is unknown if the various Windows operating system versions contain logic to infer the bit depth for all possibilities if this value is set to zero.

## References[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=9)]

1. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-mimesniff_1-0)** ["MIME Sniffing Standard"](https://mimesniff.spec.whatwg.org/#image-type-pattern-matching-algorithm). WHATWG. 2014-01-17. [Archived](https://web.archive.org/web/20140327061951/http://mimesniff.spec.whatwg.org/#image-type-pattern-matching-algorithm) from the original on 2014-03-27. Retrieved 2014-04-18.
2. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-2)** Fekete, Gyorgy (March 11, 2009). ["Operating System Interface Design Between 1981-2009"](http://www.webdesignerdepot.com/2009/03/operating-system-interface-design-between-1981-2009/). *Webdesigner Depot*. Retrieved June 6, 2011.
3. ^ [Jump up to:***a***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-win95_3-0) [***b***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-win95_3-1) [***c***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-win95_3-2) [***d***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-win95_3-3) [***e***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-win95_3-4) [***f***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-win95_3-5) Hornick, John (September 29, 1995). ["Icons"](http://msdn.microsoft.com/en-us/library/ms997538.aspx). *Windows User Interface Technical Articles ([MSDN](https://en.wikipedia.org/wiki/MSDN))*. Microsoft Corporation. Retrieved June 5, 2011.
4. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-4)** ["Windows 95 Architecture Components"](https://technet.microsoft.com/en-us/library/cc751120.aspx). *[Microsoft TechNet](https://en.wikipedia.org/wiki/Microsoft_TechNet)*. Microsoft Corporation. Retrieved June 6, 2011.
5. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-5)** ["Shell Icon BPP"](https://technet.microsoft.com/en-us/library/cc938238.aspx). *Windows 2000 Registry Reference (Microsoft TechNet)*. Microsoft Corporation. Retrieved June 6, 2011.
6. ^ [Jump up to:***a***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-winxp_6-0) [***b***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-winxp_6-1) ["Creating Windows XP Icons"](http://msdn.microsoft.com/en-us/library/ms997636.aspx). *Windows XP Technical Articles (MSDN)*. Microsoft Corporation. July 2001. Retrieved June 5, 2011.
7. ^ [Jump up to:***a***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-vista_7-0) [***b***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-vista_7-1) [***c***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-vista_7-2) ["Icons"](https://devblogs.microsoft.com/oldnewthing/20101022-00/?p=12473). *The evolution of the ICO file format, part 4: PNG images*. Raymond Chen - MSFT. Retrieved October 22, 2010.
8. ^ [Jump up to:***a***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-Butcher_8-0) [***b***](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-Butcher_8-1) Butcher, Simon (3 Sep 2003). ["image/vnd.microsoft.icon"](https://www.iana.org/assignments/media-types/image/vnd.microsoft.icon). Retrieved 3 Jan 2014.
9. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-ericlaw_9-0)** Lawrence, Eric (11 Feb 2011). ["IE9 RC Minor Changes List"](https://blogs.msdn.microsoft.com/ieinternals/2011/02/11/ie9-rc-minor-changes-list/#comment-1108). *IEInternals*. [MSDN Blogs](https://en.wikipedia.org/wiki/MSDN_Blogs). Retrieved 20 Aug 2016. See the second comment.
10. **[^](https://en.wikipedia.org/wiki/ICO_(file_format)#cite_ref-14)** Chen, Raymond (May 2008). ["Windows Confidential - 16-Bit Icons Are So Passé"](https://technet.microsoft.com/en-us/magazine/2008.05.windowsconfidential.aspx). *TechNet Magazine*. Retrieved July 1, 2011.

## External links[[edit](https://en.wikipedia.org/w/index.php?title=ICO_(file_format)&action=edit&section=10)]

- [Enable High Color Icons in Windows 95 and later](https://web.archive.org/web/20100919064620/http://ctforumgroup.com/forum/viewtopic.php?f=118&t=28677)
- [Enhance Java GUIs with Windows Icons](http://www.informit.com/articles/article.aspx?p=1186882)
- [Icon development guidelines for Windows Vista icons](https://docs.microsoft.com/en-us/windows/desktop/uxguide/vis-icons)
- [Icons (1995 Microsoft Technical Article)](https://web.archive.org/web/20160531004250/https://msdn.microsoft.com/en-us/library/ms997538.aspx)
- The evolution of the ICO file format ([Part 1](https://devblogs.microsoft.com/oldnewthing/20101018-00/?p=12513), [Part 2](https://devblogs.microsoft.com/oldnewthing/20101019-00/?p=12503), [Part 3](https://devblogs.microsoft.com/oldnewthing/20101021-00/?p=12483), [Part 4](https://devblogs.microsoft.com/oldnewthing/20101022-00/?p=12473))

| hide[v](https://en.wikipedia.org/wiki/Template:Graphics_file_formats)[t](https://en.wikipedia.org/wiki/Template_talk:Graphics_file_formats)[e](https://en.wikipedia.org/w/index.php?title=Template:Graphics_file_formats&action=edit)[Graphics file formats](https://en.wikipedia.org/wiki/Image_file_formats) |                                                              |
| -----------------------------------------------------------: | ------------------------------------------------------------ |
|      [Raster](https://en.wikipedia.org/wiki/Raster_graphics) | [ANI](https://en.wikipedia.org/wiki/ANI_(file_format))[ANIM](https://en.wikipedia.org/wiki/ANIM)[APNG](https://en.wikipedia.org/wiki/APNG)[ART](https://en.wikipedia.org/wiki/ART_image_file_format)[BMP](https://en.wikipedia.org/wiki/BMP_file_format)[BPG](https://en.wikipedia.org/wiki/Better_Portable_Graphics)[BSAVE](https://en.wikipedia.org/wiki/BSAVE_(bitmap_format))[CAL](https://en.wikipedia.org/wiki/CALS_Raster_file_format)[CIN](https://en.wikipedia.org/wiki/Cineon)[CPC](https://en.wikipedia.org/wiki/Cartesian_Perceptual_Compression)[CPT](https://en.wikipedia.org/wiki/CPT_(file_format))[DDS](https://en.wikipedia.org/wiki/DirectDraw_Surface)[DPX](https://en.wikipedia.org/wiki/Digital_Picture_Exchange)[ECW](https://en.wikipedia.org/wiki/ECW_(file_format))[EXR](https://en.wikipedia.org/wiki/OpenEXR)[FITS](https://en.wikipedia.org/wiki/FITS)[FLIC](https://en.wikipedia.org/wiki/FLIC_(file_format))[FLIF](https://en.wikipedia.org/wiki/Free_Lossless_Image_Format)[FPX](https://en.wikipedia.org/wiki/FlashPix)[GIF](https://en.wikipedia.org/wiki/GIF)[HDRi](https://en.wikipedia.org/wiki/HDRi_(data_format))[HEVC](https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding#Main_Still_Picture)[ICER](https://en.wikipedia.org/wiki/ICER)[ICNS](https://en.wikipedia.org/wiki/Apple_Icon_Image_format)ICO / CUR[ICS](https://en.wikipedia.org/wiki/Image_Cytometry_Standard)[ILBM](https://en.wikipedia.org/wiki/ILBM)[JBIG](https://en.wikipedia.org/wiki/JBIG)[JBIG2](https://en.wikipedia.org/wiki/JBIG2)[JNG](https://en.wikipedia.org/wiki/JPEG_Network_Graphics)[JPEG](https://en.wikipedia.org/wiki/JPEG)[JPEG-LS](https://en.wikipedia.org/wiki/Lossless_JPEG#JPEG-LS)[JPEG 2000](https://en.wikipedia.org/wiki/JPEG_2000)[JPEG XL](https://en.wikipedia.org/wiki/JPEG_XL)[JPEG XR](https://en.wikipedia.org/wiki/JPEG_XR)[JPEG XT](https://en.wikipedia.org/wiki/JPEG_XT) [JPEG-HDR](https://en.wikipedia.org/wiki/JPEG-HDR)[KRA](https://en.wikipedia.org/wiki/Krita)[MNG](https://en.wikipedia.org/wiki/Multiple-image_Network_Graphics)[MIFF](https://en.wikipedia.org/wiki/Magick_Image_File_Format)[NRRD](https://en.wikipedia.org/wiki/Nearly_raw_raster_data)[PAM](https://en.wikipedia.org/wiki/Netpbm#PAM_graphics_format)[PBM / PGM / PPM / PNM](https://en.wikipedia.org/wiki/Netpbm_format)[PCX](https://en.wikipedia.org/wiki/PCX)[PGF](https://en.wikipedia.org/wiki/Progressive_Graphics_File)[PICtor](https://en.wikipedia.org/wiki/PICtor_PIC_image_format)[PNG](https://en.wikipedia.org/wiki/Portable_Network_Graphics)[PSD / PSB](https://en.wikipedia.org/wiki/Adobe_Photoshop#PSD)[PSP](https://en.wikipedia.org/wiki/PaintShop_Pro)[QTVR](https://en.wikipedia.org/wiki/QuickTime_VR)[RAS](https://en.wikipedia.org/wiki/Sun_Raster)[RGBE](https://en.wikipedia.org/wiki/RGBE_image_format) [Logluv TIFF](https://en.wikipedia.org/wiki/Logluv_TIFF)[SGI](https://en.wikipedia.org/wiki/Silicon_Graphics_Image)[TGA](https://en.wikipedia.org/wiki/Truevision_TGA)[TIFF](https://en.wikipedia.org/wiki/Tagged_Image_File_Format) [TIFF/EP](https://en.wikipedia.org/wiki/TIFF/EP)[TIFF/IT](https://en.wikipedia.org/wiki/Tagged_Image_File_Format#TIFF/IT)[UFO / UFP](https://en.wikipedia.org/wiki/Ulead_PhotoImpact)[WBMP](https://en.wikipedia.org/wiki/Wireless_Application_Protocol_Bitmap_Format)[WebP](https://en.wikipedia.org/wiki/WebP)[XBM](https://en.wikipedia.org/wiki/X_BitMap)[XCF](https://en.wikipedia.org/wiki/XCF_(file_format))[XPM](https://en.wikipedia.org/wiki/X_PixMap)[XWD](https://en.wikipedia.org/wiki/Xwd) |
|        [Raw](https://en.wikipedia.org/wiki/Raw_image_format) | [CIFF](https://en.wikipedia.org/wiki/Camera_Image_File_Format)[DNG](https://en.wikipedia.org/wiki/Digital_Negative) |
|      [Vector](https://en.wikipedia.org/wiki/Vector_graphics) | [AI](https://en.wikipedia.org/wiki/Adobe_Illustrator_Artwork)[CDR](https://en.wikipedia.org/wiki/CorelDRAW#CDR_file_format)[CGM](https://en.wikipedia.org/wiki/Computer_Graphics_Metafile)[DXF](https://en.wikipedia.org/wiki/AutoCAD_DXF)[EVA](https://en.wikipedia.org/wiki/Extended_Vector_Animation)[EMF](https://en.wikipedia.org/wiki/Enhanced_Metafile)[EMF+](https://en.wikipedia.org/wiki/EMF%2B)[Gerber](https://en.wikipedia.org/wiki/Gerber_format)[HVIF](https://en.wikipedia.org/wiki/Haiku_Vector_Icon_Format)[IGES](https://en.wikipedia.org/wiki/IGES)[PGML](https://en.wikipedia.org/wiki/Precision_Graphics_Markup_Language)[SVG](https://en.wikipedia.org/wiki/Scalable_Vector_Graphics)[VML](https://en.wikipedia.org/wiki/Vector_Markup_Language)[WMF](https://en.wikipedia.org/wiki/Windows_Metafile)[Xar](https://en.wikipedia.org/wiki/Xar_(graphics)) |
|                                                     Compound | [CDF](https://en.wikipedia.org/wiki/Computable_Document_Format)[DjVu](https://en.wikipedia.org/wiki/DjVu)[EPS](https://en.wikipedia.org/wiki/Encapsulated_PostScript)[PDF](https://en.wikipedia.org/wiki/Portable_Document_Format)[PICT](https://en.wikipedia.org/wiki/PICT)[PS](https://en.wikipedia.org/wiki/PostScript)[SWF](https://en.wikipedia.org/wiki/SWF)[XAML](https://en.wikipedia.org/wiki/Extensible_Application_Markup_Language) |
|           [Metadata](https://en.wikipedia.org/wiki/Metadata) | [Exchangeable image file format (Exif)](https://en.wikipedia.org/wiki/Exif)[International Press Telecommunications Council § Photo metadata](https://en.wikipedia.org/wiki/International_Press_Telecommunications_Council#Photo_metadata)[Extensible Metadata Platform (XMP)](https://en.wikipedia.org/wiki/Extensible_Metadata_Platform)[GIF § Metadata](https://en.wikipedia.org/wiki/GIF#Metadata)[Steganography](https://en.wikipedia.org/wiki/Steganography) |
| **[![Category](https://upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/16px-Symbol_category_class.svg.png)](https://en.wikipedia.org/wiki/File:Symbol_category_class.svg) [Category](https://en.wikipedia.org/wiki/Category:Graphics_file_formats)****[![Non-article page](https://upload.wikimedia.org/wikipedia/en/thumb/6/6a/Symbol_na_class.svg/16px-Symbol_na_class.svg.png)](https://en.wikipedia.org/wiki/File:Symbol_na_class.svg) [Comparison](https://en.wikipedia.org/wiki/Comparison_of_graphics_file_formats)** |                                                              |

[Categories](https://en.wikipedia.org/wiki/Help:Category): 

- [Raster graphics file formats](https://en.wikipedia.org/wiki/Category:Raster_graphics_file_formats)
- [Microsoft Windows multimedia technology](https://en.wikipedia.org/wiki/Category:Microsoft_Windows_multimedia_technology)
- [Computer icons](https://en.wikipedia.org/wiki/Category:Computer_icons)