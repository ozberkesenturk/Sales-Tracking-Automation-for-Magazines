using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DergimORM
{
    public class ORMBase<T> : IORM<T> where T : class
    {
        private string ClassName
        {
            get
            {
                return typeof(T).Name;
            }
        }

        public bool Delete(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Delete", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] propertys = typeof(T).GetProperties();
            foreach (PropertyInfo pi in propertys)
            {
                string name = pi.Name;
                if (name != "id")
                {
                    continue;
                }
                object value = pi.GetValue(entity);
                cmd.Parameters.AddWithValue("@" + name, value);
            }
            try
            {
                if (cmd.Connection.State==ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                if (cmd.Connection.State==ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public bool Insert(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] propertys = typeof(T).GetProperties();   
            foreach (PropertyInfo pi in propertys)
            {
                string name = pi.Name;
                if (name=="id")
                {
                    continue;
                }
                object value = pi.GetValue(entity);
                cmd.Parameters.AddWithValue("@" + name, value);
              
            }
            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();

                }
            }
        }

        public DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Update(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Update", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] propertys = typeof(T).GetProperties();
            foreach (PropertyInfo pi in propertys)
            {
                string name = pi.Name;
                if (name=="id")
                {
                    continue;
                }
                object value = pi.GetValue(entity);
                cmd.Parameters.AddWithValue("@" + name, value);
            }

            try
            {
                if (cmd.Connection.State==ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

        }
    }
}
