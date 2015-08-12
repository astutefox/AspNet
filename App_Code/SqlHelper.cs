using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public interface ISql
{
    void OpenConnection();
    void CloseConnection();
}

public class SqlBase : ISql
{
    string _ConnectionString;
    SqlConnection _Connection;

    public SqlBase()
	{
        //取得連線字串
        string _ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        _Connection.ConnectionString = _ConnectionString;
	}

    public int ExecuteNonQuery(string cmdText)
    {
        SqlCommand t_Command;
        SqlTransaction t_Tran = default(SqlTransaction);

        int t_Result;
        try
        {
            OpenConnection();

            t_Tran = _Connection.BeginTransaction();

            t_Command = new SqlCommand(cmdText, _Connection);
            t_Result = t_Command.ExecuteNonQuery();

            t_Tran.Commit();
        }
        catch (SqlException e)
        {
            t_Result = e.ErrorCode;
            if (t_Tran != default(SqlTransaction))
            {
                t_Tran.Rollback();
            }
        }
        catch (Exception e)
        {
            t_Result = -1;
            if (t_Tran != default(SqlTransaction))
            {
                t_Tran.Rollback();
            }
        }
        finally
        {
            CloseConnection();
        }
        return t_Result;
    }

    public void OpenConnection()
    {
        _Connection.Open();
    }
    public void CloseConnection()
    {
        _Connection.Close();
    }
}

/// <summary>
/// 預留未來區分MsSql, Oracle連線用
/// </summary>
public class MsSqlHelper : SqlBase
{
	public MsSqlHelper(){}
}
/// <summary>
/// 預留未來擴充Oracle連線用
/// </summary>
public class OracleHelper : SqlBase
{
    public OracleHelper() { }
}