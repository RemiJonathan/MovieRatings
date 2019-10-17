using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MovieRatingsDB;

namespace MovieRatings.Models
{
    public class Business
    {
        public static IEnumerable<Rating> GetRatings()
        {
            return DB.GetRatings();
        }

        public static Rating GetRating(int id)
        {
            return DB.GetRating(id);
        }
    }
}