using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SM_Comics.Models;
using SM_Comics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM_Comics.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ComicService ComicService;

        public IEnumerable<Comic> Comics { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            ComicService comicService)
        {
            _logger = logger;
            ComicService = comicService;
        }

        public void OnGet()
        {
            Comics = ComicService.GetComics();
        }
    }
}
