using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToSQL
{
    public class Esercizio
    {

        const string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=cinemaDB;Integrated Security=True";

        //select di tutti i film
        public static void SelectMovies()
        {
            CinemaDBDataContext db = new CinemaDBDataContext(conString);

            foreach (var movie in db.movies)
            {
                Console.WriteLine($"Titolo: {movie.titolo} - Genere: {movie.genere} - Durata: {movie.durata} min");
            }
        }


        //filtrare i film
        public static void FilterMoviesByGenere()
        {
            CinemaDBDataContext db = new CinemaDBDataContext(conString);

            foreach (var movie in db.movies)
            {
                Console.WriteLine($"Titolo: {movie.titolo} - Genere: {movie.genere} - Durata: {movie.durata} min");
            }

            //query
            Console.WriteLine("Scegli il genere");
            string Genere = Console.ReadLine();

            IQueryable<movy> moviesFiltered = //oppure var moviesFiltered
                from m in db.movies
                where m.genere == Genere
                select m;

            foreach (var movie in moviesFiltered)
            {
                Console.WriteLine($"Titolo: {movie.titolo} - Genere: {movie.genere} - Durata: {movie.durata} min");
            }
        }

        public static void InsertMovie()
        {
            CinemaDBDataContext db = new CinemaDBDataContext(conString);


            var insertedMovie = new movy();
            insertedMovie.titolo = "Lala Land";
            insertedMovie.durata = 123;
            insertedMovie.genere = "Romantico";

            db.movies.InsertOnSubmit(insertedMovie);

            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            SelectMovies();

        }
    }
}
