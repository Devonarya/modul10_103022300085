using Microsoft.AspNetCore.Mvc;

namespace modul10_103022300085.Controllers
{
 

    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        public static List<Movies> MovieList = new List<Movies>
    {
        new Movies("The Shawshank Redemption", "Frank Darabont", new List<String>{"Tim Robbins", "Morgan Freeman" ,"Bob Gunton"},"A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
        new Movies("The Godfather", "Francis Ford Coppola", new List<String>{"Marlon Brando, Al Pacino, James Caan"}, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
        new Movies("The Dark Knight", "Christopher Nolan", new List<String>{"Christian Bale, Heath Ledger, Aaron Eckhart" }, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
    };
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return MovieList;
        }

        [HttpGet("{id}")]
        public Movies Get(int id)
        {
            return MovieList[id];
        }

        [HttpPost]
        public void Post([FromBody] Movies value)
        {
            MovieList.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MovieList.RemoveAt(id);
        }
    }
}
