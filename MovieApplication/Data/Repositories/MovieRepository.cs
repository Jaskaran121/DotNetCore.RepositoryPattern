using MovieApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Data.Repositories
{
    public class MovieRepository : Repository<Movie,MovieDataContext>
    {
        public MovieRepository(MovieDataContext dataContext): base(dataContext)
        {

        }
    }
}
