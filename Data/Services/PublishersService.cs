using Libreria_RERS.Data.Models;
using Libreria_RERS.Data.ViewModels;



using System;

namespace Libreria_RERS.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;

        public PublishersService(AppDbContext context)
        {
            _context = context;

        }

        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name

            };

            _context.Publishers.Add(_publisher);
            _context.SaveChanges();


        }

    }
}
