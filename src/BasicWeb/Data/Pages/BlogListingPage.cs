using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;
using BasicWeb.Data.Regions;

namespace BasicWeb.Data.Pages
{
    [PageType(Title = "Blog archive", UseBlocks = false)]
    [PageTypeRoute(Title = "Default", Route = "/blog/listing")]
    public class BlogListingPage  : ArchivePage<BlogListingPage>
    {
        /// <summary>
        /// Gets/sets the archive heading.
        /// </summary>
        [Region]
        public HeadingRegion Heading { get; set; }
    }
}