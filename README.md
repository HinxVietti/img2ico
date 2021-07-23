# img2ico
A resolution for image to ico file C#. 

## How to use

example

![howto](https://raw.githubusercontent.com/HinxVietti/img2ico/main/Docs/howto.png)

```
img2ico.exe [image array...]
```

or drag files to img2ico.exe

## Generation

ico file ; contains ico array.

## Description

[[desc]]("https://raw.githubusercontent.com/HinxVietti/img2ico/main/Docs/ICO%20format.md")  
[[ico file Wiki]](https://en.wikipedia.org/wiki/ICO_(file_format))

### ICO Header

| Offset# | Size |                           Purpose                            |
| :-----: | :--: | :----------------------------------------------------------: |
|    0    |  2B  |                 Reserved. Must always be 0.                  |
|    2    |  2B  | Specifies image type: 1 for icon (.ICO) image, 2 for cursor (.CUR) image. Other values are invalid. |
|    4    |  2B  |           Specifies number of images in the file.            |


### ICO Entry

| Offset# | Size |                           Purpose                            |
| :-----: | :--: | :----------------------------------------------------------: |
|    0    |  1B  | Specifies image width in pixels. Can be any number between 0 and 255. Value 0 means image width is 256 pixels. |
|    1    |  1B  | Specifies image height in pixels. Can be any number between 0 and 255. Value 0 means image height is 256 pixels. |
|    2    |  1B  | Specifies number of colors in the color palette. Should be 0 if the image does not use a color palette. |
|    3    |  1B  | Reserved. Should be 0. |
|    4    |  2B  | Specifies color planes. Should be 0 or 1. |
|    6    |  2B  | Specifies bits per pixel. |
|    8    |  4B  |       Specifies the size of the image's data in bytes        |
|   12    |  4B  | Specifies the offset of BMP or PNG data from the beginning of the ICO file |

## Ico file

​            ┌
​        ----|  header
​            └
​                ┌
​            ----| Entry
​                └    
​                ┌
​            ----| Entry
​                └    
​                ┌
​            ----| ...
​                └    
​                    ┌
​                ----| Data
​                    └    
​                    ┌
​                ----| Data
​                    └    
​                    ┌
​                ----| .....
​                    └    
​        

        256x256 will be saved as 32bpp 8bit alpha
        48x48   will be saved as 32bpp 8bit alpha
        48x48   will be saved as 8bpp 1bit alpha
        32x32   will be saved as 32bpp 8bit alpha
        32x32   will be saved as 8bpp 1bit alpha
        32x32   will be saved as 4bpp 1bit alpha
        16x16   will be saved as 32bpp 8bit alpha
        16x16   will be saved as 8bpp 1bit alpha
        16x16   will be saved as 4bpp 1bit alpha
