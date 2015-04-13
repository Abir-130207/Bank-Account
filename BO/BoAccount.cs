using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entity;



namespace BO
{
    public class BoAccount
    {
        DataAccess k = new DataAccess();
        public bool Information(Account m)
        {
            return k.setAccount(m);
        }

        public Account[] getinfo()
        {
            return k.getAccount();
        }

        public bool update(Account[] a)
        {
            return k.update(a);
        }

    }
}
