using System;
using System.Collections.Generic;

namespace GenericsIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      var allMovies = new List<DVD>
            {
                new DVD { ID = 1, Title = "Out in the Dark", Genre = "Drama|Romance"},
                new DVD { ID = 2, Title = "Zapped!", Genre = "Comedy|Sci-Fi"},
                new DVD { ID = 3, Title = "Neighbours", Genre = "Comedy"},
                new DVD { ID = 4, Title = "Thing, The", Genre = "Action|Horror|Sci-Fi|Thriller"},
                new DVD { ID = 5, Title = "Around the Block", Genre = "Drama"},
                new DVD { ID = 6, Title = "Corto Maltese: Under the Sign of Capricorn (Sous le signe du capricorne)", Genre = "Animation|Drama|Romance|War"},
                new DVD { ID = 7, Title = "Warlock: The Armageddon", Genre = "Horror"},
                new DVD { ID = 8, Title = "Nico and Dani", Genre = "Comedy|Drama|Romance"},
                new DVD { ID = 9, Title = "What Doesn't Kill You", Genre = "Crime|Drama"},
                new DVD { ID = 10, Title = "Reap the Wild Wind", Genre = "Action|Adventure|Drama"},
                new DVD { ID = 11, Title = "Last Days Here", Genre = "Documentary"},
                new DVD { ID = 12, Title = "Parental GuIDance", Genre = "Comedy"},
                new DVD { ID = 13, Title = "Saving Shiloh", Genre = "Children|Drama"},
                new DVD { ID = 14, Title = "Moonshot", Genre = "Drama"},
                new DVD { ID = 15, Title = "Kadosh", Genre = "Drama"},
                new DVD { ID = 16, Title = "Stanley Kubrick: A Life in Pictures", Genre = "Documentary"},
                new DVD { ID = 17, Title = "Clown and the KID, The", Genre = "Drama"},
                new DVD { ID = 18, Title = "Confetti", Genre = "Comedy"},
                new DVD { ID = 19, Title = "Setup (Set Up)", Genre = "Action|Crime|Drama"},
                new DVD { ID = 20, Title = "Captain VIDeo: Master of the Stratosphere", Genre = "Adventure|Sci-Fi"},
                new DVD { ID = 21, Title = "Underworld: Evolution", Genre = "Action|Fantasy|Horror"},
                new DVD { ID = 22, Title = "Nothing Left to Fear", Genre = "Horror"},
                new DVD { ID = 23, Title = "Shanghai Gesture, The", Genre = "Drama|Film-Noir"},
                new DVD { ID = 24, Title = "In My Father's Den", Genre = "Drama"},
                new DVD { ID = 25, Title = "Scapegoat, The", Genre = "Drama"},
                new DVD { ID = 26, Title = "None But the Lonely Heart", Genre = "Drama|Romance"},
                new DVD { ID = 27, Title = "Cameron's Closet", Genre = "Horror"},
                new DVD { ID = 28, Title = "Inferno", Genre = "Drama"},
                new DVD { ID = 29, Title = "Splatter University", Genre = "Horror"},
                new DVD { ID = 30, Title = "Flash Point", Genre = "Action"}
           };
      var allBooks = new List<Book>
            {
                new Book { ID = 1, Author = "Chinua Achebe", Title = "Things Fall Apart" },
                new Book { ID = 2, Author = "Hans Christian Andersen", Title = "Fairy tales" },
                new Book { ID = 3, Author = "Dante Alighieri", Title = "The Divine Comedy" },
                new Book { ID = 4, Author = "Unknown", Title = "The Epic Of Gilgamesh" },
                new Book { ID = 5, Author = "Unknown", Title = "The Book Of Job" },
                new Book { ID = 6, Author = "Unknown", Title = "One Thousand and One Nights" },
                new Book { ID = 7, Author = "Geoffrey Chaucer", Title = "The Canterbury Tales" },
                new Book { ID = 8, Author = "Jane Austen", Title = "Pride and Prejudice" },
                new Book { ID = 9, Author = "Miguel de Cervantes", Title = "Don Quijote De La Mancha" },
                new Book { ID = 10, Author = "Samuel Beckett", Title = "Molloy, Malone Dies, The Unnamable, the trilogy" },
                new Book { ID = 11, Author = "Giovanni Boccaccio", Title = "The Decameron" },
                new Book { ID = 12, Author = "Jorge Luis Borges", Title = "Ficciones" },
                new Book { ID = 13, Author = "Emily Bronte", Title = "Wuthering Heights" },
                new Book { ID = 14, Author = "Albert Camus", Title = "The Stranger" },
                new Book { ID = 15, Author = "Knut Hamsun", Title = "Hunger" },
                new Book { ID = 16, Author = "Ernest Hemingway", Title = "The Old Man and the Sea" },
                new Book { ID = 17, Author = "Homer", Title = "Iliad" },
                new Book { ID = 18, Author = "Homer", Title = "Odyssey" },
                new Book { ID = 19, Author = "Henrik Ibsen", Title = "A Doll's House" },
                new Book { ID = 20, Author = "James Joyce", Title = "Ulysses" },
                new Book { ID = 21, Author = "Franz Kafka", Title = "Stories" },
            };

      Console.WriteLine("Which listing would you like to see? ");
      Console.WriteLine("\t 1. Movies");
      Console.WriteLine("\t 2. Books");

      var userInput = Console.ReadLine();

      if (userInput == "1")
      {

        // print all the movies

        foreach (var movie in allMovies)
        {
          Console.WriteLine($"{movie.Title} -- {movie.Genre}");
        }
      }
      else if (userInput == "2")
      {

        // Passes a type-argument into the Generic Class of Pager
        var bookPager = new Pager<Book>()
        {
          ItemsPerPage = 3,
          PageNumber = 2,
          AllItems = allBooks
        };
        // print all the books
        foreach (var book in bookPager.GetPage())
        {
          Console.WriteLine($"{book.Title} by {book.Author}");
        }
      }
    }
  }
}
