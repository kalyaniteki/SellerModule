using Accounts.Models;
using SellerModule.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounts.Repositories
{
    public interface IAccount
    {
        public Seller SellerLogin(string name, string pass);
        public void SellerRegister(Seller seller);
    }
}
