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

        [HttpPut("{id}/hide")]
        public virtual async Task<Model.Proizvodi> Hide(int id)
        {
            return await (_service as IProizvodiService).Hide(id);
        }

        [HttpGet("{id}/allowedActions")]
        public virtual async Task<List<string>> AllowedActions(int id)
        {
            return await (_service as IProizvodiService).AllowedActions(id);
        }

        [HttpGet("{id}/recommend")]
        public virtual List<Model.Proizvodi> Recommend(int id)
        {
            return (_service as IProizvodiService).Recommend(id);
        }
    }
}