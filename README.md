# IFZConvertor

Created to allow easiest conversion between .ifz and the most used image formats: .bmp, .jpg / .jpeg, .png.
IFZ type can be described as an archive with up to 8 images inside (max number of cameras per one FH vision controller).
There could be more, but we will not dive into that.

## Requirements

OS: Windows only

Target framework: .NET Framework 4.8

## Modes
![2025-11-03_17-49-00](https://github.com/user-attachments/assets/4348ab47-2849-4adb-873a-eef633c9d187)

### Ifz2Img (IFZ ---> IMG)

TBD

### Img2Ifz (IMG ---> IFZ)
![2025-11-04_14-38-40](https://github.com/user-attachments/assets/16a8a526-072b-435e-93b6-1ba0b1594e4f)


Conversion is taken place inside specified (source) folder by default.
User can specify Destination folder by unchecking "Same as Source folder" checkbox.

- Select Source folder;
- Check how many images each type are there;
- Select extension type (.bmp, .jpg/.jpeg, .png, ALL) from dropdown;
- Specify if you want to add original extension to the end of the filename by checkbox;

**Attention:** If this setting is disabled, all images with the same name (but different extensions) Will Be Overwritten!

Example: 

![2025-11-04_12-55-29](https://github.com/user-attachments/assets/02628661-7270-457a-a4af-dcc5000b188a)

- Specify Destination folder if needed.
- Click Convert.

## About

Version: 1.3 (IMG ---> IFZ only).

Date: 2025.11.
