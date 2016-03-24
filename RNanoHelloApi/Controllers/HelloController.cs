using Microsoft.Practices.Unity;
using RNanoHello.Model;
using RNanoHelloApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace RNanoHelloApi.Controllers
{
    public class HelloController : ApiController
    {
        IRepository<MessageModel> _repository;

        public HelloController(IRepository<MessageModel> repository)
        {
            _repository = repository;
        }

        [ResponseType(typeof(IEnumerable<string>))]
        public IHttpActionResult GetNotify()
        {
            try
            {
                var entities = _repository.GetNofity();

                return Ok(entities);
            }
            catch (Exception)
            { 
                throw;
            }
        }

       
        [ResponseType(typeof(MessageModel))]
        public IHttpActionResult PostMessage(MessageModel entity)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _repository.Insert(entity);

                return CreatedAtRoute("DefaultApi", new { id = entity.Id }, entity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
