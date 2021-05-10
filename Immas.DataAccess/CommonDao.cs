using Immas.Common;
using Immas.Database;
using System.Data;

namespace Immas.DataAccess
{
    public class CommonDao : BaseDao
    {
        public DataTable MenuSelect()
        {
            var query = @"SELECT * FROM TB_MENU_INFO ORDER BY PARENT_ID,ORDER_SEQ";
            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            DataTable resultTable = helper.FillTable(query, CommandType.Text, null);

            return resultTable;
        }

        public DataTable AuthInfoSelect()
        {
            ParameterPackageCollection parameters = new ParameterPackageCollection();
            parameters.AddParameter("USER_ID", SharedCache.UserId);
            var query = @"SELECT * 
                            FROM TB_VIEW_AUTH 
                           WHERE USER_ID = @USER_ID";
            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            DataTable resultTable = helper.FillTable(query, CommandType.Text, parameters);

            return resultTable;
        }

        public string PasswordCheck(string id, string password)
        {
            ParameterPackageCollection parameters = new ParameterPackageCollection();
            parameters.AddParameter("USER_ID", id);
            parameters.AddParameter("PASSWD", password);

            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            var resultTable = helper.FillTable(
                 cmdText: @"SELECT USER_ID
                             FROM TB_USER_INFO       A
                            WHERE A.USER_ID = @USER_ID
                              AND A.PASSWD  = @PASSWD"
                , cmdType: CommandType.Text
                , parameters: parameters);

            if (resultTable.Rows.Count == 0) return null;
            return (resultTable.Rows[0] as DataRow)["USER_ID"].ToString();
        }

        public DataTable ComboBoxCodeSelect(string masterCode)
        {
            ParameterPackageCollection parameters = new ParameterPackageCollection();
            parameters.AddParameter("MCODE", masterCode);
            var query = @"SELECT * FROM TB_CODE_D WHERE MCODE = @MCODE ORDER BY ORDER_SEQ";

            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            DataTable resultTable = helper.FillTable(query, CommandType.Text, parameters);

            return resultTable;
        }

        #region [ Singleton Impl         ]
        private CommonDao() { }
        private static CommonDao instance;
        public static CommonDao GetInstance()
        {
            if (instance == null) instance = new CommonDao();
            return instance;
        }
        #endregion
    }
}
