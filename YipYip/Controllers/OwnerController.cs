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
    public class OwnerController : ApiController
    {
        public IHttpActionResult Get()
        {
            ProfileService ownerService = CreateOwnerService();
            var people = ownerService.GetOwners();
            return Ok(people);
        }
        public IHttpActionResult Post(ProfileCreate owner)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOwnerService();

            if (!service.CreateOwner(owner))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            ProfileService ownerService = CreateOwnerService();
            var note = ownerService.GetOwnerById(id);
            return Ok(note);
        }
        public IHttpActionResult Put(ProfileUpdate owner)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOwnerService();

            if (!service.UpdateOwner(owner))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateOwnerService();

            if (!service.OwnerDelete(id))
                return InternalServerError();

            return Ok();
        }
        private ProfileService CreateOwnerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var ownerService = new ProfileService(userId);
            return ownerService;
        }
    }
}
