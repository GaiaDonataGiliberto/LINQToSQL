using System;
using System.Collections.Generic;
using System.Data.Linq;
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


        public static void DeleteMovie(int id)
        {
            CinemaDBDataContext db = new CinemaDBDataContext(conString);

            var movieToDelete = db.movies.SingleOrDefault(m => m.ID == id);

            if (movieToDelete != null)
            {
                db.movies.DeleteOnSubmit(movieToDelete);
                Console.WriteLine("Film cancellato");
            }

            db.SubmitChanges();

        }

        public static void UpdateMovieByTitolo()
        {
            CinemaDBDataContext db = new CinemaDBDataContext(conString);

            Console.WriteLine("Dimmi il titolo del film da aggiornare: ");
            string titolo = Console.ReadLine();

            IQueryable<movy> filmByTitolo =
                from film in db.movies
                where film.titolo == titolo
                select film;

            Console.WriteLine("I film trovati sono: {0}", filmByTitolo.Count());

            if (filmByTitolo.Count() == 0)
            {
                return;
            }

            if (filmByTitolo.Count() > 1)
            {
                return;
            }


            SelectMovies();

            Console.WriteLine("Scrivere is valori aggiornati ");
            Console.WriteLine("Titolo: ");
            string titolo1 = Console.ReadLine();

            Console.WriteLine("Genere: ");
            string genere = Console.ReadLine();

            Console.WriteLine("Durata: ");
            int durata = Convert.ToInt32(Console.ReadLine());


            foreach (var f in filmByTitolo)
            {
                f.titolo = titolo1;
                f.genere = genere;
                f.durata = durata;
            };

            try
            {
                Console.WriteLine("Premi un tasto per mandare modifiche al db");
                Console.ReadKey();
                db.SubmitChanges(ConflictMode.FailOnFirstConflict);

            }
            catch (ChangeConflictException e)
            {

                Console.WriteLine("Concurrency error");
                Console.WriteLine(e.Message);
                Console.ReadKey();

                //OverwriteCurrentValues->ignora le mie modifiche(aggiorna il mio obj model)
                //KeepCurrentValues->ignora le modifiche altrui(sovrascrive il db con il mio obj model)
                //KeepChanges->cerca di tenere entrambe le modifiche 
                db.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);

                db.SubmitChanges();
            }


        }
    }
}
