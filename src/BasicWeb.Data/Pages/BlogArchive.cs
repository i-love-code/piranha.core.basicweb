using BasicWeb.Data.Regions;
using Piranha.AttributeBuilder;
using Piranha.Models;

namespace BasicWeb.Data.Pages
{
    [PageType(Title = "Blog archive", UseBlocks = false)]
    public class BlogArchive  : ArchivePage<BlogArchive>
    {
        /// <summary>
        /// Gets/sets the archive heading.
        /// </summary>
        [Region]
        public HeadingRegion Heading { get; set; }
    }
}