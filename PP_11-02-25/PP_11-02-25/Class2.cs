using System;

namespace PP_11_02_25
{
    public class Movie
    {
        public string title;
        public string director;
        public int year;
        public double rating;

        public Movie next, prev;

        public Movie(string title, string director, int year, double rating)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.rating = rating;
        }
    }

    public class Class2
    {
        private Movie head;
        private Movie tail;

        public Movie AddAtBegining(string title,string director,int year,double rating)
        {
            Movie newMovie = new Movie(title, director, year, rating);
            if (head == null)
                head = tail = newMovie;
            else
            {
                newMovie.next = head;
                head.prev = newMovie;
                head = newMovie;
            }

            return head;
        }

        public Movie AddInEnd(string title,string director, int year,double rating)
        {
            Movie newMovie = new Movie(title, director, year, rating);
            if (head == null)
                head = tail = newMovie;
            else
            {
                newMovie.prev = tail;
                tail.next = newMovie;
                tail = newMovie;
            }
            return head;
        }

        public Movie AddAtGivenPosition(string title,string director,int year,double rating,int position)
        {
            Movie newMovie = new Movie(title, director, year, rating);
            Movie temp=head;
            Movie tmp=head;

            int len = 0;
            while (temp != null)
            {
                len++;
                temp = temp.next;
            }

            if (position > len + 1 || position < 0)
                Console.WriteLine("Enter valid position");
            else
            {
                if(position==1)
                    AddAtBegining(title, director, year, rating);

                position--;
                while (position > 1)
                {
                    tmp = tmp.next;
                    position--;
                }
                newMovie.prev = tmp;
                newMovie.next = tmp.next;
                tmp.next.prev = newMovie;
                tmp.next = newMovie;
            }
            return head;
        }

        public Movie DeleteMovie(string title)
        {
            if (head == null)
            {
                Console.WriteLine("no movie found");
                return null;
            }

            Movie temp = head;
            int count = 0;
            while (temp.next != null)
            {
                count++;
                if (temp.next.title == title)
                {
                    temp.next.next.prev=temp;
                    temp.next = temp.next.next;

                    Console.WriteLine("movie deleted ");
                    return head;
                }
                temp = temp.next;
            }
            Console.WriteLine("Movie not found");

            return head;
        }

        public Movie SearchMovieByDirector(string director)
        {
            Movie temp = head;
            while (temp != null)
            {
                if (temp.director == director)
                {
                    Console.WriteLine($"{temp.title} found");
                    return head;
                }
                temp = temp.next;
            }
            Console.WriteLine("Movie not available");
            return head;
        }

        public Movie SearchMovieByRating(double rating)
        {
            Movie temp = head;
            while (temp != null)
            {
                if (temp.rating == rating)
                {
                    Console.WriteLine($"{temp.title} found");
                    return head;
                }
                temp = temp.next;
            }
            Console.WriteLine("Movie not available");
            return head;
        }

        public Movie UpdateMovieRating(string title, double newRating)
        {
            Movie temp = head;
            while (temp != null)
            {
                if (temp.title == title)
                {
                    temp.rating = newRating;
                    Console.WriteLine("Rating updated");
                    return head;
                }
                temp = temp.next;
            }
            return head;
        }

        public void DisplayForward()
        {
            Movie temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.title}->");
                temp = temp.next;
            }
            Console.WriteLine();
            Console.WriteLine("....................");
        }

        public void DisplayReverse()
        {
            Movie temp = tail;
            while (temp != null)
            {
                Console.Write($"{temp.title}<-");
                temp = temp.prev;
            }
            Console.WriteLine();
            Console.WriteLine(".......................");
        }

        public static void Main2()
        {
            Class2 obj=new Class2();

            obj.AddAtBegining("Movie2", "Director2", 2004, 3.2);
            obj.AddAtBegining("Movie1", "Director1", 2003, 3.4);

            obj.AddInEnd("Movie4", "Director4", 2007, 4.4);
            obj.AddAtGivenPosition("Movie3", "Director3", 2015, 2.4,3);

            Console.WriteLine("Movie List (Forward):");
            obj.DisplayForward();

            Console.WriteLine("Movie List (Reverse):");
            obj.DisplayReverse();

            obj.DeleteMovie("Movie2");
            obj.DisplayForward();

            obj.SearchMovieByDirector("Director2");

            obj.UpdateMovieRating("Movie1", 9.0);
            obj.DisplayReverse();
        }

    }
}
