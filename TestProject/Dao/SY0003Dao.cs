using Immas.Common;
using Immas.DataAccess;
using Immas.Database;
using System.Data;

namespace TestProject.Dao
{
    public class SY0003Dao : BaseDao
    {
        public DataTable Select01()
        {
            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            DataTable resultTable = helper.FillTable
            (
                cmdText: @"SELECT MENU_ID
                                 ,MENU_DESC
                                 ,PARENT_ID
                                 ,VIEW_ID
                                 ,ORDER_SEQ
                                 ,USE_YN
                                 ,ASSEMBLY_NAME
                                 ,USER_GROUP
                                 ,INSERT_USER
                                 ,INSERT_TIME
                                 ,UPDATE_USER
                                 ,UPDATE_TIME
                                 ,ROW_ID
                            FROM TB_MENU_INFO
                           ORDER BY PARENT_ID, ORDER_SEQ",
                cmdType:    CommandType.Text,
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
                parameters.AddParameter("MENU_ID"       , row["MENU_ID"]);
                parameters.AddParameter("MENU_DESC"     , row["MENU_DESC"]);
                parameters.AddParameter("PARENT_ID"     , row["PARENT_ID"]);
                parameters.AddParameter("VIEW_ID"       , row["VIEW_ID"]);
                parameters.AddParameter("ORDER_SEQ"     , row["ORDER_SEQ"]);
                parameters.AddParameter("USE_YN"        , row["USE_YN"]);
                parameters.AddParameter("ASSEMBLY_NAME" , row["ASSEMBLY_NAME"]);
                parameters.AddParameter("LOGIN_ID", SharedCache.UserId);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"INSERT 
                        INTO TB_MENU_INFO 
                             ( MENU_ID
                              ,MENU_DESC    
                              ,PARENT_ID    
                              ,VIEW_ID      
                              ,ORDER_SEQ    
                              ,USE_YN       
                              ,ASSEMBLY_NAME
                              ,INSERT_USER
                              ,INSERT_TIME  
                             )
                      VALUES ( @MENU_ID
                              ,@MENU_DESC    
                              ,@PARENT_ID    
                              ,@VIEW_ID      
                              ,@ORDER_SEQ    
                              ,@USE_YN       
                              ,@ASSEMBLY_NAME
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
                parameters.AddParameter("MENU_ID"       , row["MENU_ID"]);
                parameters.AddParameter("MENU_DESC"     , row["MENU_DESC"]);
                parameters.AddParameter("PARENT_ID"     , row["PARENT_ID"]);
                parameters.AddParameter("VIEW_ID"       , row["VIEW_ID"]);
                parameters.AddParameter("ORDER_SEQ"     , row["ORDER_SEQ"]);
                parameters.AddParameter("USE_YN"        , row["USE_YN"]);
                parameters.AddParameter("ASSEMBLY_NAME" , row["ASSEMBLY_NAME"]);
                parameters.AddParameter("LOGIN_ID", SharedCache.UserId);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"UPDATE TB_MENU_INFO 
                         SET MENU_DESC      = @MENU_DESC
                           , PARENT_ID      = @PARENT_ID
                           , VIEW_ID        = @VIEW_ID
                           , ORDER_SEQ      = @ORDER_SEQ
                           , USE_YN         = @USE_YN
                           , ASSEMBLY_NAME  = @ASSEMBLY_NAME
                           , UPDATE_USER    = @LOGIN_ID
                           , UPDATE_TIME    = GETDATE()
                       WHERE MENU_ID = @MENU_ID"
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
                parameters.AddParameter("MENU_ID", row["MENU_ID", DataRowVersion.Original]);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"DELETE FROM TB_MENU_INFO
                   WHERE MENU_ID = @MENU_ID"
                    , CommandType.Text
                    , parameters);
            }
        }

        #region [ Singleton Impl         ]
        private SY0003Dao() { }
        private static SY0003Dao instance;
        public static SY0003Dao GetInstance()
        {
            if (instance == null) instance = new SY0003Dao();
            return instance;
        } 
        #endregion
    }
}
