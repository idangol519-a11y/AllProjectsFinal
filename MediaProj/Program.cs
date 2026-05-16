namespace MediaProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MediaItem[] mediaItems = new MediaItem[]
            {
                new Movie("Shrek", 3),
                new song(),
                new liveStream()
            };
            foreach (var item in mediaItems)
            {
                item.Play();
            }

            Movie[] movies = new Movie[]
            {
                new Movie("Shrek", 3),
                new Movie("Inception", 2),
                new Movie("The Matrix", 2)
            };
            Array.Sort(movies);
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title);
            }
          

        }
        abstract class MediaItem
        {
            public String Title;
            public int Duration;
            public MediaItem()
            {
                Title = "Unknown";
                Duration = 0;
            }
            public MediaItem(string title, int duration)
            {
                Title = title;
                Duration = duration;
            }
            public abstract void Play();
            
         }

        public interface Idownloadable
        {
            void Download();
        }

        class Movie : MediaItem, Idownloadable , IComparable<Movie>
        {
            public Movie(string title, int duration) : base(title, duration)
            {
            }
            public int CompareTo(Movie m)
            {
                return this.Duration.CompareTo(m.Duration);
            }
            public void Download()
            {
                Console.WriteLine("Downloading movie files...");
            }
          

            public override void Play()
            {
                Console.WriteLine("Playing movie...");
            }
        }

        class song : MediaItem, Idownloadable
        {
            public void Download()
            {
                Console.WriteLine("Downloading song files...");
            }
            public override void Play()
            {
                Console.WriteLine("Playing song...");
            }
        }

        class liveStream : MediaItem
        {
            public override void Play()
            {
                Console.WriteLine("Playing live stream...");
            }
        }



    }

}


