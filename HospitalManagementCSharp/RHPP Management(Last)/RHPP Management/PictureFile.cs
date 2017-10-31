using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace RHPP_Management
{
    [Serializable]
    class PictureFile
    {
        public string Path { set; get; }
        public byte[] img { set; get; }

        //static void Main()
        //{
        //    //byte[] b = saveImage(picpatient.Image);
                
        //}

        /////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////method to convert Image to Byte array
        //static byte[] saveImage(Image img)
        //{
        //    MemoryStream mem = new MemoryStream();  //creates a stream memory
        //    img.Save(mem, img.RawFormat);           //saves the image (img) to the specified memory (mem) in the specified format (RawFormat)
        //    return (mem.GetBuffer());               //returns the array of unsigned bytes from which this stream was created (mem)
        //}

        ////method to convert Byte array to Image
        //static Image getImage(byte[] B_img)
        //{
        //    MemoryStream mem = new MemoryStream(B_img);     //creates a stream memory
        //    return (Image.FromStream(mem));                 //creates an image from the specified data stream (mem)
        //}
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////
    }

    
}
