using System;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface ImageReader
    {
        DecodedImage GetDecodedImage();
    }

    class DecodedImage
    {
        private string _image;

        public DecodedImage(string image)
        {
            _image = image;
        }

        public override string ToString()
        {
            return _image + ": is decoded";
        }
    }

    class GifReader : ImageReader
    {
        private DecodedImage _decodedImage;

        public GifReader(string image)
        {
            _decodedImage = new DecodedImage(image);
        }

        public DecodedImage GetDecodedImage()
        {
            return _decodedImage;
        }
    }
}
