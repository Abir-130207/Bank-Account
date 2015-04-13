using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class DataAccess
    {
        StreamReader read;
        StreamWriter writer;
        public bool setAccount(Account m)
        {
            try
            {
                writer = new StreamWriter("C:\\Users\\Abir\\Documents\\Visual Studio 2010\\Projects\\Solution1\\a.txt", true);
                writer.WriteLine(m.AccountNo);
                writer.WriteLine(m.UserName);
                writer.WriteLine(m.Balance);
                writer.WriteLine(m.Address);
                writer.WriteLine(m.ContactNo);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public Account[] getAccount()
        {
            try
            {
                read = new StreamReader("C:\\Users\\Abir\\Documents\\Visual Studio 2010\\Projects\\Solution1\\a.txt");
                Account[] ac = new Account[1000];
                string s;
                for (int i = 0; (s = read.ReadLine()) != null; i++)
                {
                    ac[i] = new Account();
                    ac[i].AccountNo = s;
                    ac[i].UserName = read.ReadLine();
                    ac[i].Balance = Convert.ToDouble(read.ReadLine());
                    ac[i].Address = read.ReadLine();
                    ac[i].ContactNo = read.ReadLine();
                }
                read.Close();
                return ac;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool update(Account[] a)
        {
            try
            {
                writer = new StreamWriter("C:\\Users\\Abir\\Documents\\Visual Studio 2010\\Projects\\Solution1\\a.txt", true);
                for (int i = 0; ; i++)
                {
                    if (a[i] == null)
                        break;
                    writer.WriteLine(a[i].AccountNo);
                    writer.WriteLine(a[i].UserName);
                    writer.WriteLine(a[i].Balance);
                    writer.WriteLine(a[i].Address);
                    writer.WriteLine(a[i].ContactNo);
                }
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}
