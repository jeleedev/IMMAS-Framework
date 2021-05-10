using Immas.Common;
using Immas.DataAccess;
using Immas.Database;
using System.Data;

namespace TestProject.Dao
{
    public class SY0002Dao : BaseDao
    {
        public DataTable Select01(string MCODE = "")
        {
            ParameterPackageCollection parameters = new ParameterPackageCollection();
            parameters.AddParameter("MCODE", MCODE);

            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            DataTable resultTable = helper.FillTable
            (
                cmdText: @"SELECT MCODE
                                , NAME
                                , USE_YN
                                , REMARK
                                , INSERT_USER
                                , INSERT_TIME
                                , UPDATE_USER
                                , UPDATE_TIME
                                FROM TB_CODE_M
                               WHERE (ISNULL(@MCODE, '') = '' OR MCODE = @MCODE)
                               ORDER BY MCODE",
                cmdType:    CommandType.Text,
                parameters: parameters
            );
            return resultTable;
        }
        public DataTable Select02(string MCODE)
        {
            ParameterPackageCollection parameters = new ParameterPackageCollection();
            parameters.AddParameter("MCODE", MCODE);

            IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
            DataTable resultTable = helper.FillTable
            (
                cmdText: @"SELECT MCODE
                                , CODE
                                , NAME
                                , ORDER_SEQ
                                , USE_YN
                                , INSERT_USER
                                , INSERT_TIME
                                , UPDATE_USER
                                , UPDATE_TIME
                                FROM TB_CODE_D
                               WHERE MCODE = @MCODE
                               ORDER BY ORDER_SEQ",
                cmdType:    CommandType.Text,
                parameters: parameters
            );
            return resultTable;
        }
        
        public void Insert01(DataTable dt)
        {
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("MCODE"     , row["MCODE"]);
                parameters.AddParameter("NAME"      , row["NAME"]);
                parameters.AddParameter("REMARK"    , row["REMARK"]);
                parameters.AddParameter("USE_YN"    , row["USE_YN"]);
                parameters.AddParameter("LOGIN_ID", SharedCache.UserId);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"INSERT 
                        INTO TB_CODE_M 
                             ( MCODE
                              ,NAME    
                              ,USE_YN    
                              ,REMARK
                              ,INSERT_USER
                              ,INSERT_TIME  
                             )
                      VALUES ( @MCODE
                              ,@NAME      
                              ,@USE_YN      
                              ,@REMARK
                              ,@LOGIN_ID  
                              ,GETDATE()  
                             )"
                    , CommandType.Text
                    , parameters);
            }
        }
        public void Insert02(DataTable dt)
        {
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("MCODE"     , row["MCODE"]);
                parameters.AddParameter("CODE"      , row["CODE"]);
                parameters.AddParameter("NAME"      , row["NAME"]);
                parameters.AddParameter("ORDER_SEQ" , row["ORDER_SEQ"]);
                parameters.AddParameter("USE_YN"    , row["USE_YN"]);
                parameters.AddParameter("LOGIN_ID", SharedCache.UserId);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"INSERT 
                        INTO TB_CODE_D 
                             ( MCODE
                              ,CODE    
                              ,NAME    
                              ,ORDER_SEQ
                              ,USE_YN    
                              ,INSERT_USER
                              ,INSERT_TIME  
                             )
                      VALUES ( @MCODE
                              ,@CODE      
                              ,@NAME      
                              ,@ORDER_SEQ
                              ,@USE_YN    
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
                parameters.AddParameter("MCODE"     , row["MCODE"]);
                parameters.AddParameter("NAME"      , row["NAME"]);
                parameters.AddParameter("USE_YN"    , row["USE_YN"]);
                parameters.AddParameter("REMARK"    , row["REMARK"]);
                parameters.AddParameter("LOGIN_ID", SharedCache.UserId);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"UPDATE TB_CODE_M 
                         SET NAME          = @NAME 
                           , REMARK        = @REMARK    
                           , USE_YN        = @USE_YN    
                           , UPDATE_USER   = @LOGIN_ID
                           , UPDATE_TIME   = GETDATE()
                       WHERE MCODE = @MCODE"
                    , CommandType.Text
                    , parameters);
            }
        }
        public void Update02(DataTable dt)
        {
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("MCODE"     , row["MCODE"]);
                parameters.AddParameter("CODE"      , row["CODE"]);
                parameters.AddParameter("NAME"      , row["NAME"]);
                parameters.AddParameter("ORDER_SEQ" , row["ORDER_SEQ"]);
                parameters.AddParameter("USE_YN"    , row["USE_YN"]);
                parameters.AddParameter("LOGIN_ID", SharedCache.UserId);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"UPDATE TB_CODE_D 
                         SET CODE          = @CODE    
                           , NAME          = @NAME 
                           , ORDER_SEQ     = @ORDER_SEQ    
                           , USE_YN        = @USE_YN    
                           , UPDATE_USER   = @LOGIN_ID
                           , UPDATE_TIME   = GETDATE()
                       WHERE MCODE = @MCODE
                         AND CODE  = @CODE"
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
                parameters.AddParameter("MCODE", row["MCODE", DataRowVersion.Original]);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"DELETE FROM TB_CODE_M
                       WHERE MCODE = @MCODE"
                    , CommandType.Text
                    , parameters);
            }
        }
        public void Delete02(DataTable dt)
        {
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                ParameterPackageCollection parameters = new ParameterPackageCollection();
                parameters.AddParameter("MCODE", row["MCODE", DataRowVersion.Original]);
                parameters.AddParameter("CODE" , row["CODE", DataRowVersion.Original]);

                IDBHelper helper = DbHelperFactory.CreateDbHelper("MES_DB");
                helper.ExecuteNonQuery(
                    @"DELETE FROM TB_CODE_D
                       WHERE MCODE = @MCODE
                         AND CODE  = @CODE"
                    , CommandType.Text
                    , parameters);
            }
        }

        #region [ Singleton Impl         ]
        private SY0002Dao() { }
        private static SY0002Dao instance;
        public static SY0002Dao GetInstance()
        {
            if (instance == null) instance = new SY0002Dao();
            return instance;
        } 
        #endregion
    }
}
