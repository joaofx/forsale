using System.Collections.Generic;

namespace ForSale.Models
{
    public class Product
    {
        public Product()
        {
            Tags = new List<string>();
            LocalImages = new List<string>();
            RemoteImages = new List<string>();
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Tags { get; set; }
        public string AlbumId { get; set; }
        public string ImagemId { get; set; }
        public List<string> LocalImages { get; set; }
        public string LocalImagesDirectory { get; set; }
        public List<string> RemoteImages { get; set; }
        public string Thumbnail { get; set; }
    }
}