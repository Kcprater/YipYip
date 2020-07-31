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
        private readonly Guid _userId;

        public OwnerService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateOwner(OwnerCreate model)
        {
            var entity =
                new Owner()
                {
                    OwnerName = model.OwnerName,
                    Phone = model.Phone,
                    Email = model.Email,
                    Rating = model.Rating,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Owners.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<GetOwner> GetOwners()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Owners
                        .Where(e => e.OwnerId >= 0)
                        .Select(
                            e =>
                                new GetOwner
                                {
                                    OwnerId = e.OwnerId,
                                    OwnerName = e.OwnerName,
                                    Phone = e.Phone,
                                    Email = e.Email,
                                    Rating = e.Rating,
                                }
                        );

                return query.ToArray();
            }
        }
        public GetOwnerById GetOwnerById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Owners
                        .Single(e => e.OwnerId == id );
                return
                    new GetOwnerById
                    {
                        OwnerId = entity.OwnerId,
                        OwnerName = entity.OwnerName,
                        Phone = entity.Phone,
                        Email = entity.Email,
                        Rating = entity.Rating
                    };
            }
        }
        public bool UpdateOwner(OwnerUpdate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Owners
                        .Single(e => e.OwnerId == model.OwnerId);
                entity.OwnerName = model.OwnerName;
                entity.Phone = model.Phone;
                entity.Email = model.Email;
                entity.Rating = model.Rating;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool OwnerDelete(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Owners
                        .Single(e => e.OwnerId == id);

                ctx.Owners.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

        
   

