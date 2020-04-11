using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Film
    {

        public int Id { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(60)]
        public string ShortDescription { get; set; }

        [StringLength(600)]
        public string Description { get; set; }

        [StringLength(60)]
        public string ImageUrl { get; set; }

        
        
        public int KategoriId { get; set; }

        public virtual Kategori Kategori { get; set; }


    }
}
