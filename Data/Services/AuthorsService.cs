using Libreria_RERS.Data.Models;
using Libreria_RERS.Data.ViewModels;



using System;

namespace Libreria_RERS.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;

        public AuthorsService (AppDbContext context)
        {
            _context = context; 

        }

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName= author.FullName,

            };

            _context.Authors.Add(_author);
            _context.SaveChanges();


        }

    }
}
