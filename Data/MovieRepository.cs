using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() {Id= 1,
                Name="Avatar",
                ShortDescription="Kısa açıklama",
                Description="<p>Film, Maine'in küçük bir kasabasında yaşayan 7 çocuğu ele alıyor. Bu yedi arkadaş okullarında dışlanan bir gruptur. Ancak en büyük sorunları bu değildir. Arkadaşlar bir yandan hayatın getirdiği sorunlarla, bir yandan da ergenlikle uğraşırken, başlarına beklemedikleri bir bela daha açılır. Kurbanlarının korkularına göre şekle girebilen Pennywise, ürkütücü bir palyaço kılığında bu 7 çocuğa dehşet saçmaya başlar. Artık okuldaki sorunları, verecekleri hayatta kalma mücadelesine oranla bir hayli önemsiz kalacaktır...</p>",
                ImageUrl="1.jfif",
                CategoryId=1},

                new Movie() {Id= 2,
                Name="Shutter Island",
                ShortDescription="Kısa açıklama",
                Description="<p>Film, Maine'in küçük bir kasabasında yaşayan 7 çocuğu ele alıyor. Bu yedi arkadaş okullarında dışlanan bir gruptur. Ancak en büyük sorunları bu değildir. Arkadaşlar bir yandan hayatın getirdiği sorunlarla, bir yandan da ergenlikle uğraşırken, başlarına beklemedikleri bir bela daha açılır. Kurbanlarının korkularına göre şekle girebilen Pennywise, ürkütücü bir palyaço kılığında bu 7 çocuğa dehşet saçmaya başlar. Artık okuldaki sorunları, verecekleri hayatta kalma mücadelesine oranla bir hayli önemsiz kalacaktır...</p>",
                ImageUrl="2.jfif",
                CategoryId=2},

                new Movie() {Id= 3,
                Name="Harry Potter",
                ShortDescription="Kısa açıklama",
                Description="<p>Film, Maine'in küçük bir kasabasında yaşayan 7 çocuğu ele alıyor. Bu yedi arkadaş okullarında dışlanan bir gruptur. Ancak en büyük sorunları bu değildir. Arkadaşlar bir yandan hayatın getirdiği sorunlarla, bir yandan da ergenlikle uğraşırken, başlarına beklemedikleri bir bela daha açılır. Kurbanlarının korkularına göre şekle girebilen Pennywise, ürkütücü bir palyaço kılığında bu 7 çocuğa dehşet saçmaya başlar. Artık okuldaki sorunları, verecekleri hayatta kalma mücadelesine oranla bir hayli önemsiz kalacaktır...</p>",
                ImageUrl="3.jfif",
                CategoryId=3},

                new Movie() {Id= 4,
                Name="Gora",
                ShortDescription="Kısa açıklama",
                Description="<p>Film, Maine'in küçük bir kasabasında yaşayan 7 çocuğu ele alıyor. Bu yedi arkadaş okullarında dışlanan bir gruptur. Ancak en büyük sorunları bu değildir. Arkadaşlar bir yandan hayatın getirdiği sorunlarla, bir yandan da ergenlikle uğraşırken, başlarına beklemedikleri bir bela daha açılır. Kurbanlarının korkularına göre şekle girebilen Pennywise, ürkütücü bir palyaço kılığında bu 7 çocuğa dehşet saçmaya başlar. Artık okuldaki sorunları, verecekleri hayatta kalma mücadelesine oranla bir hayli önemsiz kalacaktır...</p>",
                ImageUrl="4.jfif",
                CategoryId=3},

                new Movie() {Id= 5,
                Name="Lord of War",
                ShortDescription="Kısa açıklama",
                Description="<p>Film, Maine'in küçük bir kasabasında yaşayan 7 çocuğu ele alıyor. Bu yedi arkadaş okullarında dışlanan bir gruptur. Ancak en büyük sorunları bu değildir. Arkadaşlar bir yandan hayatın getirdiği sorunlarla, bir yandan da ergenlikle uğraşırken, başlarına beklemedikleri bir bela daha açılır. Kurbanlarının korkularına göre şekle girebilen Pennywise, ürkütücü bir palyaço kılığında bu 7 çocuğa dehşet saçmaya başlar. Artık okuldaki sorunları, verecekleri hayatta kalma mücadelesine oranla bir hayli önemsiz kalacaktır...</p>",
                ImageUrl="5.jfif",
                CategoryId=3},

                new Movie() {Id= 6,
                Name="Thor",
                ShortDescription="Kısa açıklama",
                Description="<p>Film, Maine'in küçük bir kasabasında yaşayan 7 çocuğu ele alıyor. Bu yedi arkadaş okullarında dışlanan bir gruptur. Ancak en büyük sorunları bu değildir. Arkadaşlar bir yandan hayatın getirdiği sorunlarla, bir yandan da ergenlikle uğraşırken, başlarına beklemedikleri bir bela daha açılır. Kurbanlarının korkularına göre şekle girebilen Pennywise, ürkütücü bir palyaço kılığında bu 7 çocuğa dehşet saçmaya başlar. Artık okuldaki sorunları, verecekleri hayatta kalma mücadelesine oranla bir hayli önemsiz kalacaktır...</p>",
                ImageUrl="6.jfif",
                CategoryId=4},
            };
        }

        public static List<Movie> Movies
        {
            get { return _movies; }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}