using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [Route("[controller]")]
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch> where T : class where TSearch : class
    {
        protected new readonly ICRUDService<T, TSearch,TInsert, TUpdate> _service;
        protected readonly ILogger<BaseCRUDController<T, TSearch, TInsert, TUpdate>> _logger;

        public BaseCRUDController(ILogger<BaseCRUDController<T, TSearch, TInsert, TUpdate>> logger, ICRUDService<T, TSearch, TInsert, TUpdate> service)
            :base(logger,service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        [Authorize(Roles ="Administrator")]
        public virtual async Task<T> Insert ([FromBody]TInsert insert)
        {
            return await _service.Insert(insert);
        }

        [HttpPut("{id}")]
        public virtual async Task<T> Update (int id, [FromBody] TUpdate update)
        {
            return await _service.Update(id, update);
        }
    }
}