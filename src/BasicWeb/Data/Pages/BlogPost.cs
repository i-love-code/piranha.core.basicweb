using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;
using BasicWeb.Data.Regions;

namespace BasicWeb.Data.Pages
{
    [PostType(Title = "Blog post")]
    [PageTypeRoute(Title = "Default", Route = "/blog/post")]
    public class BlogPost  : Post<BlogPost>
    {
        /// <summary>
        /// Gets/sets the post heading.
        /// </summary>
        [Region]
        public HeadingRegion Heading { get; set; }
    }
}