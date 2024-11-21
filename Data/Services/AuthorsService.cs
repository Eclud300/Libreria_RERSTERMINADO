﻿using Libreria_RERS.Data.Models;
using Libreria_RERS.Data.ViewModels;



using System;
using System.Linq;

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

        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(n => n.Id == authorId).Select(n => new AuthorWithBooksVM()
            {
                FullName = n.FullName,
                BookTitles = n.Book_Authors.Select(n => n.Books.Titulo).ToList()


            }).FirstOrDefault();
            return _author;

        }

    }
}
