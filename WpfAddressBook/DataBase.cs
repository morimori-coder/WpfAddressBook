using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAddressBook
{
    class DataBase
    {
        private readonly string ID_COL = "id";
        private readonly string NAME_COL = "name";
        private readonly string BIRTH_YEAR_COL = "birth_year";
        private readonly string BIRTH_MONTH_COL = "birth_month";
        private readonly string BIRTH_DAY_COL = "birth_day";
        private readonly string POSTAL_CODE_COL = "postal_code";
        private readonly string ADDRESS_COL = "address";
        private readonly string PHONE_NUMBER_COL = "phone_number";
        private readonly string MAIL_ADDRESS_COL = "mail_address";
        private readonly string CELLPHONE_NUMBER_COL = "cellphone_number";

        /// <summary>
        /// コネクション
        /// </summary>
        public NpgsqlConnection connection { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// <paramref name="connectInfo"/>接続情報
        /// </summary>
        public DataBase(string connectInfo)
        {
            try
            {
                this.connection = new NpgsqlConnection(connectInfo);
                this.connection.Open();
            }
            catch (PostgresException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// DBにINSERT分を実行する
        /// </summary>
        /// <param name="sql">SQL文</param>
        public void ExecuteInsertToDB(string sql)
        {
            try
            {
                using (var command = new NpgsqlCommand(sql, this.connection))
                {
                    var rowsaffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
