using BasicWeb.Data.Regions;
using Piranha.AttributeBuilder;
using Piranha.Models;

namespace BasicWeb.Data.Pages
{
    [PostType(Title = "Blog post")]
    public class BlogPost  : Post<BlogPost>
    {
        /// <summary>
        /// Gets/sets the post heading.
        /// </summary>
        [Region]
        public HeadingRegion Heading { get; set; }
    }
}