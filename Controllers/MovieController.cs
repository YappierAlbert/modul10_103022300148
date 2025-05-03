using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul10_103022300148.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private static readonly List<Movie> movies = new()
        {
            new Movie("The Shawshank Redemption","Frank Darabont", new List<string>{"MetaScore : 82","IMDb Rating : 9.3" },"A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather","Francis Ford Copolla", new List<string>{"MetaScore : 100","IMDb Rating : 9.2" },"The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight","Christoper Nolan", new List<string>{"MetaScore : 84","IMDb Rating : 9.0" },"When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }
        [HttpGet("{id}")]
        public Movie GetId(int id)
        {
            return movies[id];
        }
        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            movies.RemoveAt(id);
            return "Data berhasil dihapus";
        }
        [HttpPost]
        public String Post([FromBody] Movie mv)
        {
            movies.Add(mv);
            return "Data berhasil ditambah";
        }
    }
}
