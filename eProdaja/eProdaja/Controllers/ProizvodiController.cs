using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : BaseCRUDController<Proizvodi,ProizvodiSearchObject,ProizvodiInsertRequest,ProizvodiUpdateRequest>
    {
        public ProizvodiController(ILogger<BaseCRUDController<Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>> logger, IProizvodiService proizvodi)
            :base(logger, proizvodi)
        {
        }

        [HttpPut("{id}/activate")]
        public virtual async Task<Model.Proizvodi> Activate(int id)
        {
            return await (_service as IProizvodiService).Activate(id);
        }
    }
}