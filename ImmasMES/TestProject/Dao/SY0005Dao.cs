using Immas.DataAccess;
using Immas.Database;
using System.Data;

namespace TestProject.Dao
{
    public class SY0005Dao : BaseDao
    {
        public DataTable Select01()
        {
            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            var query = @"SELECT CODE
                               , NAME        
                               , INSERT_USER
                               , INSERT_TIME
                               , UPDATE_USER
                               , UPDATE_TIME
                               , ROW_ID     
                            FROM TB_CODE_D 
                           WHERE MCODE  = 'USER_GROUP' 
                             AND USE_YN = 'Y'
                           ORDER BY ORDER_SEQ";
            var resultTable = helper.FillTable(query, CommandType.Text, null);
            return resultTable;
        }
        public DataTable Select02(string code)
        {
            ParameterPackageCollection parameters = new ParameterPackageCollection();
            parameters.AddParameter("CODE", code);

            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            var query = @"SELECT USER_ID
                                ,USER_NAME
                                ,USER_GROUP
                                ,RANK_CODE
                                ,DEPARTMENT
                                ,CONVERT(CHAR(10),ENTER_TIME,120) AS ENTER_TIME
                                ,INSERT_USER
                                ,INSERT_TIME
                                ,UPDATE_USER
                                ,UPDATE_TIME
                                ,ROW_ID
                            FROM TB_USER_INFO
                           WHERE USER_GROUP = @CODE
                           ORDER BY USER_ID";
            var resultTable = helper.FillTable(query, CommandType.Text, parameters);
            return resultTable;
        }

        public void Update02(DataTable dt)
        {
            if (dt == null) return;

            foreach(DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("USER_ID", row["USER_ID"]);
                parameters.AddParameter("USER_GROUP", row["USER_GROUP"]);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                var query = @"UPDATE TB_USER_INFO 
                                 SET USER_GROUP = @USER_GROUP
                               WHERE USER_ID    = @USER_ID";

                helper.ExecuteNonQuery(query, CommandType.Text, parameters);
            }
        }

        #region [ Singleton Impl         ]
        private SY0005Dao() { }
        private static SY0005Dao instance;
        public static SY0005Dao GetInstance()
        {
            if (instance == null) instance = new SY0005Dao();
            return instance;
        }
        #endregion
    }
}