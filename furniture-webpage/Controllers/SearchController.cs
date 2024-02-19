using Microsoft.AspNetCore.Mvc;

namespace furniture_webpage.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class SearchController : ControllerBase
    {
        [HttpGet]
        public IActionResult Search(string query)
        {
            // Perform the search logic here using the 'query' parameter
            // Retrieve search results from the data source (e.g., database)
            // Format the search results into a suitable data structure (e.g., List or DTO class)

            // Example search logic:
            var searchResults = new List<string>
        {
            "Result 1",
            "Result 2",
            "Result 3"
        };

            return Ok(searchResults);
        }
    }
}