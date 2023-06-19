using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketForm.DAL;
using TicketForm.Models;

namespace TicketForm.BLL
{
    public class MyFun
    {
        MySql ms = new MySql();

        public bool Register(MyStr str)
        {
            return ms.Register(str);
        }

        public bool Login(MyStr str)
        {
            return ms.Login(str);
        }

        public bool Addticket(MyStr str)
        {
            return ms.Addticket(str);
        }

        public bool Buyticket(MyStr str)
        {
            return ms.Buyticket(str);
        }

        public bool UpdateMoney(MyStr str)
        {
            return ms.UpdateMoney(str);
        }

        public bool UpdatePrice(MyStr str)
        {
            return ms.UpdatePrice(str);
        }

        public bool UpdatePrice1(MyStr str)
        {
            return ms.UpdatePrice1(str);
        }

        public bool Delete(MyStr str)
        {
            return ms.Delete(str);
        }
        public DataTable GetAll(string a)
        {
            return ms.GetAll(a);
        }

        public DataTable GetOne(string a)
        {
            return ms.GetOne(a);
        }
        public DataTable GetOne1(string a)
        {
            return ms.GetOne1(a);
        }
        public DataTable GetOneSure(string a,string b, string c)
        {
            return ms.GetOneSure(a,b,c);
        }
        public DataTable GetOnePrice(string a, string b, string c)
        {
            return ms.GetOnePrice(a, b, c);
        }
        public DataTable GetOneSure1(string a, string b, int c)
        {
            return ms.GetOneSure1(a, b, c);
        }
    }
}
