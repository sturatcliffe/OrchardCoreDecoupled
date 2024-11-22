using Microsoft.AspNetCore.Mvc.RazorPages;
using OrchardCore;
using OrchardCore.ContentManagement;

namespace OrchardCoreDetachedDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IOrchardHelper _orchard;

        public ContentItem? PageContent { get; set; }

        public IndexModel(IOrchardHelper orchard)
        {
            _orchard = orchard;
        }

        public async Task OnGet()
        {
            PageContent = await _orchard.GetContentItemByAliasAsync($"alias:{Request.Path}");
        }
    }
}
