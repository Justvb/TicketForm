using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketForm.Models;

namespace TicketForm.DAL
{
    public class MySql
    {
        public bool Register(MyStr ms)      //注册
        {
            string sqlStr = "insert into user_id(账号,昵称,密码) values(@账号,@昵称,@密码)";
            SqlParameter[] param = new SqlParameter[]
             {
                new SqlParameter("@账号",ms.account),
                new SqlParameter("@昵称",ms.name),
                new SqlParameter("@密码",ms.password),
             };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public bool Login(MyStr ms)      //登录
        {
            string sqlstr = "select 账号 from[user_id]where(账号=@账号)and(密码=@密码)";
            SqlParameter[] param = new SqlParameter[]
             {
                new SqlParameter("@账号",ms.account),
                new SqlParameter("@密码",ms.password),
             };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateMoney(MyStr ms)
        {
            string sqlStr = "update user_info set 财富=@财富 where 账号=@账号";

            SqlParameter[] param = new SqlParameter[]
            {
                 new SqlParameter("@账号",ms.MIno),
                new SqlParameter("@财富",ms.MImoney),
               
            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public bool UpdatePrice1(MyStr ms)
        {
            string sqlStr = "update user_info set 中奖号码=@中奖号码 where 账号=@账号";

            SqlParameter[] param = new SqlParameter[]
            {
                 new SqlParameter("@账号",ms.MIno),
                new SqlParameter("@中奖号码",ms.MIprice),

            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public bool UpdatePrice(MyStr ms)
        {
            string sqlStr = "update ticket set 中奖号码=@中奖号码 where 编号=@编号";

            SqlParameter[] param = new SqlParameter[]
            {
                 new SqlParameter("@编号",ms.MTno),
                new SqlParameter("@中奖号码",ms.MTprice),

            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public bool Delete(MyStr ms)
        {

            string str = "delete From ticket where 编号 = @编号";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@编号",ms.MTno)
            };

            return DBHelper.ExcuteCommand(str, param);
        }

        public bool Addticket(MyStr ms)      //发布彩票
        {
            string sqlStr = "insert into ticket (中奖号码,发布时间) values(@中奖号码,@发布时间)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@中奖号码",ms.MTprice),
                new SqlParameter("@发布时间",ms.MTtime),
            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public bool Buyticket(MyStr ms)  
        {
            string sqlStr = "insert into total (编号,账号,昵称,购买号码,购买时间) values(@编号,@账号,@昵称,@购买号码,@购买时间)";
            SqlParameter[] param = new SqlParameter[]
            {
                 new SqlParameter("@编号",ms.MTObh),
                new SqlParameter("@账号",ms.MTOno),
                new SqlParameter("@昵称",ms.MTOname),
                new SqlParameter("@购买号码",ms.MTOprice),
                new SqlParameter("@购买时间",ms.MTOtime),

            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public DataTable GetAll(string a)   //彩票全部查找
        {
            string strsql = string.Format("select * from {0}",a);
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }

        public DataTable GetOne(string a)   //发行查看
        {
            string strsql = string.Format("select * from ticket where 发布时间 like N'%{0}%'", a);
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }

        public DataTable GetOne1(string a)   //发行查看
        {
            string strsql = string.Format("select * from total where 购买时间 like N'%{0}%'", a);
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }

        public DataTable GetOnePuls(string a)   //发行查看
        {
            string strsql = string.Format("select * from {0} where 发布时间 like N'%{0}%'", a);
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }

        public DataTable GetOnePrice(string a,string b,string c)   //发行查看
        {
            string strsql = string.Format("select * from {0} where {1} like N'%{2}%'", a,b,c);
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }

        public DataTable GetOneSure(string a,string b, string c)   //发行查看
        {
            string strsql = string.Format("select * from {0} where {1} ='{2}'", a,b,c);
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }

        public DataTable GetOneSure1(string a, string b, int c)   //发行查看
        {
            string strsql = string.Format("select * from {0} where {1} ='{2}'", a, b, c);
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }
    }
}
