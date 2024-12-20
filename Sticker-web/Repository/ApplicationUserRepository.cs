﻿using Sticker_web.Data;
using Sticker_web.Models;
using Sticker_web.Repository.Interfaces;

namespace Sticker_web.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
