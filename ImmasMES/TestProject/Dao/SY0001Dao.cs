using Immas.Common;
using Immas.DataAccess;
using Immas.Database;
using System.Data;

namespace TestProject.Dao
{
    public class SY0001Dao : BaseDao
    {
        public DataTable Select01(string userNo, string userName, string userRank)
        {
            ParameterPackageCollection parameters = new ParameterPackageCollection();
            parameters.AddParameter("USER_ID", userNo);
            parameters.AddParameter("USER_NAME", userName);
            parameters.AddParameter("RANK_CODE", userRank);

            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            DataTable resultTable = helper.FillTable(
                @"SELECT USER_ID
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
                   WHERE (@USER_ID = ''   OR USER_ID   = @USER_ID)
                     AND (@USER_NAME = '' OR USER_NAME = @USER_NAME)
                     AND (@RANK_CODE = '' OR RANK_CODE = @RANK_CODE)"
                , CommandType.Text
                , parameters
                );
            return resultTable;
        }

        public void Insert01(DataTable dt)
        {
            if (dt == null) return;

            foreach(DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("USER_ID",      row["USER_ID"]);
                parameters.AddParameter("USER_NAME",    row["USER_NAME"]);
                parameters.AddParameter("RANK_CODE",    row["RANK_CODE"]);
                parameters.AddParameter("DEPARTMENT",   row["DEPARTMENT"]);
                parameters.AddParameter("ENTER_TIME",   row["ENTER_TIME"]);
                parameters.AddParameter("LOGIN_ID", SharedCache.UserId);


                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"INSERT TB_USER_INFO (USER_ID, USER_NAME, RANK_CODE, ENTER_TIME, DEPARTMENT, INSERT_USER, INSERT_TIME)
                              VALUES (@USER_ID, @USER_NAME, @RANK_CODE, @ENTER_TIME, @DEPARTMENT, @LOGIN_ID, GETDATE())"
                    , CommandType.Text
                    , parameters);
            }
        }

        public void Update01(DataTable dt)
        {
            if (dt == null) return;

            foreach(DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("USER_ID"       , row["USER_ID"]);
                parameters.AddParameter("USER_NAME"     , row["USER_NAME"]);
                parameters.AddParameter("USER_GROUP"    , row["USER_GROUP"]);
                parameters.AddParameter("DEPARTMENT"    , row["DEPARTMENT"]);
                parameters.AddParameter("RANK_CODE"     , row["RANK_CODE"]);
                parameters.AddParameter("ENTER_TIME"    , row["ENTER_TIME"]);
                parameters.AddParameter("LOGIN_ID"      , SharedCache.UserId);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"UPDATE TB_USER_INFO
                         SET USER_NAME   = @USER_NAME
                           , USER_GROUP  = @USER_GROUP
                           , DEPARTMENT  = @DEPARTMENT
                           , RANK_CODE   = @RANK_CODE
                           , ENTER_TIME  = @ENTER_TIME
                           , UPDATE_USER = @LOGIN_ID
                           , UPDATE_TIME = GETDATE()
                       WHERE USER_ID     = @USER_ID"
                    , CommandType.Text
                    , parameters);
            }
        }

        public void Delete01(DataTable dt)
        {
            if (dt == null) return;

            foreach(DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("USER_ID", row["USER_ID"]);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"DELETE FROM TB_USER_INFO
                   WHERE USER_ID = @USER_ID"
                    , CommandType.Text
                    , parameters);
            }
        }

        #region [ Singleton Impl         ]
        private SY0001Dao() { }
        private static SY0001Dao instance;
        public static SY0001Dao GetInstance()
        {
            if (instance == null) instance = new SY0001Dao();
            return instance;
        }
        #endregion
    }
}