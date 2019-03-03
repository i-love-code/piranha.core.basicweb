using BasicWeb.Data.Regions;
using Piranha.AttributeBuilder;
using Piranha.Models;
using System.Collections.Generic;

namespace BasicWeb.Data.Pages
{
    [PageType(Title = "Start page")]
    [PageTypeRoute(Title = "Default", Route = "/start")]
    public class StartPage : Page<StartPage>
    {
        /// <summary>
        /// Gets/sets the page heading.
        /// </summary>
        [Region]
        public HeadingRegion Heading { get; set; }

        /// <summary>
        /// Gets/sets the available teasers.
        /// </summary>
        [Region(ListTitle = "Title")]
        public IList<TeaserRegion> Teasers { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public StartPage()
        {
            Teasers = new List<TeaserRegion>();
        }
    }
}