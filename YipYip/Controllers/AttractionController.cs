using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YipYip.Models;
using YipYip.Services;

namespace YipYip.Controllers
{
    public class AttractionController : ApiController
    {
        //CREATE
        public IHttpActionResult Post(AttractionCreate note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateAttractionService();

            if (!service.CreateAttraction(note))
                return InternalServerError();

            return Ok();
        }
        //Create
        private AttractionService CreateAttractionService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteService = new AttractionService(userId);
            return noteService;
        }
        //Update
        public IHttpActionResult Put(AttractionEdit note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateAttractionService();

            if (!service.UpdateAttraction(note))
                return InternalServerError();

            return Ok();
        }
    }
}
