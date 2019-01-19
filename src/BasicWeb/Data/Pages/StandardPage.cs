using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace BasicWeb.Data.Pages
{
    [PageType(Title = "Standard page")]
    [PageTypeRoute(Title = "Default", Route = "/standardpage")]
    public class StandardPage  : Page<StandardPage>
    {
    }
}