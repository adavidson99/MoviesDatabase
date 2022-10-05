using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesLibrary
{
    public class MovieModel
    {
        /// <summary>
        /// The name of the movie.
        /// </summary>
        public string MovieName { get; set; }

        /// <summary>
        /// The director of the movie.
        /// </summary>
        public PersonModel MovieDirector { get; set; }

        /// <summary>
        /// List of stars in the movie.
        /// </summary>
        public List<PersonModel> MovieStars { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Year the movie was released. 
        /// </summary>
        public int MovieYear { get; set; }

        /// <summary>
        /// List of genres of the movie.
        /// </summary>
        public List<string> MovieGenre { get; set; } = new List<string>();

        /// <summary>
        /// Language the movie is in
        /// </summary>
        public string MovieLanguage { get; set; }

        /// <summary>
        /// My rating of the movie out of 10
        /// </summary>
        public int MovieRating { get; set; }

    }
}
