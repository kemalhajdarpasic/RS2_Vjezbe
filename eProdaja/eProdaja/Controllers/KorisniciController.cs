using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : BaseCRUDController<Model.Korisnici,KorisniciSearchObject,KorisniciInsertRequest,KorisniciUpdateRequest>
    {
        public KorisniciController(ILogger<BaseCRUDController<Model.Korisnici, KorisniciSearchObject, KorisniciInsertRequest, KorisniciUpdateRequest>> logger, IKorisniciService service)
            :base(logger,service)
        {
        }

        [Authorize(Roles ="Administrator")]
        public override Task<Korisnici> Insert([FromBody] KorisniciInsertRequest insert)
        {
            return base.Insert(insert);

        }
    }
}