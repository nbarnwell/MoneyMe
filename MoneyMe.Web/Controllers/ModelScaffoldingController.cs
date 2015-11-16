using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MoneyMe.Web.Models.Scaffolding;

namespace MoneyMe.Web.Controllers
{
    public class ModelScaffoldingController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var types =
                typeof(IScaffoldDbContext).GetProperties()
                                          .Select(x => x.PropertyType)
                                          .Where(x => x.IsGenericType)
                                          .Where(x => typeof(IDbSet<>).IsAssignableFrom(x.GetGenericTypeDefinition()))
                                          .Select(x => x.GetGenericArguments().First())
                                          .Where(x => !x.Name.StartsWith("Vw"))
                                          .Select(x => x.Name);

            var content = string.Join("\r\n", types.Select(BuildScaffoldString).ToArray()) + "\r\n";
            return new FileContentResult(Encoding.UTF8.GetBytes(content), "text/plain");
        }

        private string BuildScaffoldString(string typeName)
        {
            return string.Format("Scaffold Controller -Area 'Setup' -ModelType '{0}' -ControllerName '{0}Controller' -DbContextType 'ScaffoldDbContext' -Force", typeName);
        }
    }
}