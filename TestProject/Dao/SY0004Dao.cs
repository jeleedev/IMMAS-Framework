using Immas.Common;
using Immas.DataAccess;
using Immas.Database;
using System;
using System.Data;

namespace TestProject.Dao
{
    public class SY0004Dao : BaseDao
    {
        public DataTable Select01()
        {
            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            DataTable resultTable = helper.FillTable
            (
                cmdText: @"SELECT A.USER_ID
                                 ,A.VIEW_ID
                                 ,B.MENU_DESC
                                 ,A.AUTH_KIND
                                 ,A.AUTH_YN
                                 ,A.INSERT_USER
                                 ,A.INSERT_TIME
                                 ,A.UPDATE_USER
                                 ,A.UPDATE_TIME
                                 ,A.ROW_ID
                            FROM TB_VIEW_AUTH       A
                            LEFT JOIN TB_MENU_INFO  B ON A.VIEW_ID = B.VIEW_ID",
                cmdType: CommandType.Text,
                parameters: null
            );
            return resultTable;
        }
        public void Insert01(DataTable dt)
        {
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("USER_ID", row["USER_ID"]);
                parameters.AddParameter("VIEW_ID", row["VIEW_ID"]);
                parameters.AddParameter("AUTH_KIND", row["AUTH_KIND"]);
                parameters.AddParameter("AUTH_YN", row["AUTH_YN"]);
                parameters.AddParameter("LOGIN_ID", SharedCache.UserId);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"INSERT 
                        INTO TB_VIEW_AUTH 
                             ( USER_ID
                              ,VIEW_ID    
                              ,AUTH_KIND    
                              ,AUTH_YN    
                              ,INSERT_USER
                              ,INSERT_TIME  
                             )
                      VALUES ( @USER_ID
                              ,@VIEW_ID    
                              ,@AUTH_KIND    
                              ,@AUTH_YN    
                              ,@LOGIN_ID
                              ,GETDATE()  
                             )"
                    , CommandType.Text
                    , parameters);
            }
        }

        public void Update01(DataTable dt)
        {
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("USER_ID", row["USER_ID"]);
                parameters.AddParameter("VIEW_ID", row["VIEW_ID"]);
                parameters.AddParameter("AUTH_KIND", row["AUTH_KIND"]);
                parameters.AddParameter("AUTH_YN", row["AUTH_YN"]);
                parameters.AddParameter("LOGIN_ID", SharedCache.UserId);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"UPDATE TB_VIEW_AUTH 
                         SET AUTH_KIND    = @AUTH_KIND      
                           , AUTH_YN      = @AUTH_YN 
                           , UPDATE_USER  = @LOGIN_ID
                           , UPDATE_TIME  = GETDATE()
                       WHERE USER_ID   = @USER_ID
                         AND VIEW_ID   = @VIEW_ID
                         AND AUTH_KIND = @AUTH_KIND"
                    , CommandType.Text
                    , parameters);
            }
        }

        public void Delete01(DataTable dt)
        {
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("USER_ID", row["USER_ID", DataRowVersion.Original]);
                parameters.AddParameter("VIEW_ID", row["VIEW_ID", DataRowVersion.Original]);
                parameters.AddParameter("AUTH_KIND", row["AUTH_KIND", DataRowVersion.Original]);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"DELETE FROM TB_VIEW_AUTH
                       WHERE USER_ID   = @USER_ID
                         AND VIEW_ID   = @VIEW_ID
                         AND AUTH_KIND = @AUTH_KIND"
                    , CommandType.Text
                    , parameters);
            }
        }

        #region [ Singleton Impl         ]
        private SY0004Dao() { }
        private static SY0004Dao instance;
        public static SY0004Dao GetInstance()
        {
            if (instance == null) instance = new SY0004Dao();
            return instance;
        }
        #endregion
    }
}
