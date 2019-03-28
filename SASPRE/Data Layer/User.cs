using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SASPRE.Data_Layer
{
    class User
    {

        private Connection connection;

        private String _nickName;
        private String _password;
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String NickName
        {
            get { return _nickName; }
            set { _nickName = value; }
        }
        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public System.Data.DataTable Login()
        {
            var table = new System.Data.DataTable();

            connection = new Connection();

            try
            {
                var command = new MySqlCommand()
                {
                    Connection = connection.OpenConnection(),
                    CommandText = "SPLogin",
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var nicknameParam = new MySqlParameter()
                {
                    ParameterName = "nickname",
                    MySqlDbType = MySqlDbType.VarChar,
                    Size = 100,
                    Value = this.NickName,
                };
                command.Parameters.Add(nicknameParam);

                var passwordParam = new MySqlParameter()
                {
                    ParameterName = "pass",
                    MySqlDbType = MySqlDbType.Int32,
                    Size = 8,
                    Value = this.Password
                };
                command.Parameters.Add(passwordParam);

                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

            }
            catch (Exception)
            {
                table = null;
                throw;
            }
            finally
            {
                connection.CloseConnection();
            }

            return table;
        }

    }
}
