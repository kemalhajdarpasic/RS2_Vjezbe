using eProdaja.Model;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    public class VrsteProivodumController : BaseController<Model.VrsteProizvodum, BaseSearchObject>
    {
        public VrsteProivodumController(ILogger<BaseController<VrsteProizvodum, BaseSearchObject>> logger, IService<VrsteProizvodum, BaseSearchObject> service) : base(logger, service)
        {
        }
    }
}