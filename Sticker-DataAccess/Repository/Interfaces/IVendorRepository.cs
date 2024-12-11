﻿using Sticker_Models.Models;

namespace Sticker_DataAccess.Repository.Interfaces
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        Task UpdateAsync(Vendor obj);
    }
}
