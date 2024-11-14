using System.Collections.Generic;

namespace Libreria_RERS.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //propiedades de navegacion

        public List<Books> Books { get; set; }
    }
}
