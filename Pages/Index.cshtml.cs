using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UnrealServer.Data;

namespace UnrealServer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UnrealContext _ctx;
        public List<SpeechResult> Results { get; set; }

        public IndexModel(ILogger<IndexModel> logger, UnrealContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public void OnGet()
        {
            Results = _ctx.SpeechResults.OrderBy(p => p.TimeStamp).ToList();
        }
    }
}
