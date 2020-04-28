using Accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounts.Repositories
{
    public class Account:IAccount
    {
        private readonly EmartDBContext _context;
        public Account(EmartDBContext context)
        {
            _context = context;
        }


        public void SellerRegister(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }


        public Seller SellerLogin(string name, string pass)
        {
            //var s = _context.Seller.SingleOrDefault(e => e.Username == name && e.Password == pass);
            //if (s != null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            Seller x = _context.Seller.SingleOrDefault(e => e.Username == name && e.Password == pass);
            return x;
        }

    }
}
