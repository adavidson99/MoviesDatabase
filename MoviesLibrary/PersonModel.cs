using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// List of movies this person has stared in.
        /// </summary>
        public List<MovieModel> Star { get; set; } = new List<MovieModel>();
        
        /// <summary>
        /// List of movies this person has directed 
        /// </summary>
        public List<MovieModel> Director { get; set; } = new List<MovieModel>();
    }
}
