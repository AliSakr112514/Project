using e_net.Data.Base;
using e_net.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System;

namespace e_net.Data.Service
{
    public class ItemService : EntityBaseRepository<Item>, IItemService
    {
        public ItemService(AppDbConetext context) : base(context) { }
    }
}
