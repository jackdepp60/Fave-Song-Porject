using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public List<Video> Videos { get; set; }

        public class Video
        {
            public string Title { get; set; }
            public string EmbedUrl { get; set; }
        }

        public void OnGet()
        {
            Videos = new List<Video>
            {
                new Video { Title = "Song 1 – Love Will Keep Us Alive", EmbedUrl = "https://www.youtube.com/embed/4QKplwfuCns" },
                new Video { Title = "Song 2 – Run to You", EmbedUrl = "https://www.youtube.com/embed/AEthkJesdDw" },
                new Video { Title = "Song 3 – Nothing Else Matters", EmbedUrl = "https://www.youtube.com/embed/5gTuJqgSV9g" },
                new Video { Title = "Song 4 – Freak on a Leash", EmbedUrl = "https://www.youtube.com/embed/OrQTYbT6Elc" },
                new Video { Title = "Song 5 – Enter Sandman", EmbedUrl = "https://www.youtube.com/embed/XZuM4zFg-60" },
                new Video { Title = "Song 6 – Bohemian Rhapsody", EmbedUrl = "https://www.youtube.com/embed/5zLnaNY58j8" },
                new Video { Title = "Song 7 – Always", EmbedUrl = "https://www.youtube.com/embed/O-gA3gj75-8" },
                new Video { Title = "Song 8 – You Give Love a Bad Name", EmbedUrl = "https://www.youtube.com/embed/BbWKG7g18go" }
            };
        }
    }
}
