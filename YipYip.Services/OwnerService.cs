﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip.Data;
using YipYip.Models;

namespace YipYip.Services
{
    public class OwnerService
    {
        private readonly Guid _Id;

        public OwnerService(Guid id)
        {
            _Id = id;
        }
        public bool CreateOwner(OwnerCreate model)
        {
            var entity =
                new Owner()
                {
                    Id = _Id,
                    ProfileId = model.ProfileId,
                    ProfileName = model.ProfileName,
                    Phone = model.Phone,
                    Email = model.Email,
                    Created = DateTime.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Owners.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public OwnerDetail GetOwnerById(int ownerid)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Owners
                        .Single(e => e.OwnerId == ownerid);
                return
                    new OwnerDetail
                    {
                        OwnerId = entity.OwnerId,
                        Id = entity.Id,
                        ProfileName = entity.ProfileName,
                        Phone = entity.Phone,
                        Email = entity.Email,
                        Rating = entity.Rating,
                        Created = entity.Created,
                        OwnerProperties = entity.OwnerProperties
                    };
            }
        }

        public bool UpdateOwner(OwnerEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Owners
                        .Single(e => e.OwnerId == model.OwnerId && e.Id == _Id);
                entity.ProfileName = model.ProfileName;
                entity.Phone = model.Phone;
                entity.Email = model.Email;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool OwnerDelete(int ownerid)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Owners
                        .Single(e => e.OwnerId == ownerid && e.Id == _Id);

                ctx.Owners.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }

}