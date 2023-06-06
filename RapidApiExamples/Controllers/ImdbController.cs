using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiExamples.Models;

namespace RapidApiExamples.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index(int page = 1, int pageSize = 10)
        {
            List<ApiMovieViewModel> moviesList = new List<ApiMovieViewModel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                {
                    { "X-RapidAPI-Key", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" },
                    { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                moviesList = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);

                int totalMovies = moviesList.Count;
                int totalPages = (int)Math.Ceiling((double)totalMovies / pageSize);
                int skip = (page - 1) * pageSize;
                List<ApiMovieViewModel> moviesPage = moviesList.Skip(skip).Take(pageSize).ToList();
                
                ViewData["TotalPages"] = totalPages;
                ViewData["CurrentPage"] = page;
                ViewData["PageSize"] = pageSize;
                ViewData["Movies"] = moviesPage;

                return View();
            }
        }

    }
}
