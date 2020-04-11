using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Kategori
    {

        public int Id { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

    }
}
