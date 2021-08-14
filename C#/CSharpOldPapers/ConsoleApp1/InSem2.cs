using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InSem2
    {
        internal static void InSem2Solution()
        {
            Q1();
        }

        public static void Q1()
        {
            List<Jpeg> photo = new List<Jpeg>();
            photo.Add(new Jpeg());
            photo.Add(new Jpeg());
            photo.Add(new Jpeg());


            PhotoStudio ps = new PhotoStudio();
            ps.PlaceOrder<Jpeg>(photo, PhotoType.Jpeg);
            ps.GetGrayScaleAlbum<Jpeg>();

            List<Png> photo1 = new List<Png>();
            photo1.Add(new Png());
            photo1.Add(new Png());
            photo1.Add(new Png());
            ps.PlaceOrder<Png>(photo1, PhotoType.Png);
            ps.GetGrayScaleAlbum<Png>();
        }
    }

    public enum PhotoType { Jpeg, Png };

 
    public interface IPhotoType  {    }
    public class Filter
    {
  
        public virtual T GrayScale<T>(T photo)
        {
            throw new NotImplementedException();
        }
    }

    public class Jpeg : IPhotoType{ }
    
   class JpegFilter : Filter
    {

        public override T GrayScale<T>(T jpeg) { /*convert to grayscale*/ return jpeg; }

    }

    public class Png : IPhotoType { } /* represents a PNG file */
    class PngFilter : Filter
    {
        public override T GrayScale<T>(T png) { /*convert to grayscale*/ return png; }

    }

    class PhotoStudio
    {
        private Filter filter;
        private List<IPhotoType> photos;

        public void PlaceOrder<T>(List<T> photos, PhotoType image)
        {
            this.photos = new List<IPhotoType>();
            switch (image)
            {
                case PhotoType.Jpeg:
                    filter = new JpegFilter();
                    foreach (T photo in photos)
                    {
                        Jpeg temp = (Jpeg)(object)photo;
                        this.photos.Add(temp);
                    }
                    break;
                case PhotoType.Png:
                    filter = new PngFilter();
                    foreach (T photo in photos)
                    {
                        Png temp = (Png)(object)photo;
                        this.photos.Add(temp);
                    }
                    break;

            }
            

           

        }

        public List<T> GetGrayScaleAlbum<T>()
        {
            List<T> album = new List<T>();
            foreach (var photo in photos)
                album.Add(filter.GrayScale<T>((T)photo));

            return album;
        }

    }

}