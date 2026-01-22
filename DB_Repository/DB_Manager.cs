using Dapper;
using DB_Project.DTOs;
using DB_Project.Helpers;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DB_Project.DB_Repository
{
    public class DB_Manager
    {
        public int ExecuteSPWithReturn(
                    string spName,
                    object? parameters = null)
        {
            using var con = new SqlConnection(Helper.conStr) ;

            var p = new DynamicParameters(parameters);

            p.Add(
                "ReturnValue",
                dbType: DbType.Int32,
                direction: ParameterDirection.ReturnValue
            );

            con.Execute(
                spName,
                p,
                commandType: CommandType.StoredProcedure
            );

            return p.Get<int>("ReturnValue");
        }
        public int GetCount(string tableName)
        {
            using var con = new SqlConnection(Helper.conStr);

            var sql = $"SELECT COUNT(*) FROM {tableName}";
            return con.ExecuteScalar<int>(sql);
        }
        public Result<List<T>> SelectMany<T>(
                string spName,
                object? parameters = null) where T : DTO, new()
        {
            using var con = new SqlConnection(Helper.conStr);
            var p = new DynamicParameters(parameters);
            p.Add(
                "ReturnValue",
                dbType: DbType.Int32,
                direction: ParameterDirection.ReturnValue
            );

            var records = con.Query<T>(
                spName,
                p,
                commandType: CommandType.StoredProcedure
            ).ToList();

            int status = p.Get<int>("ReturnValue");

            return new Result<List<T>>(records,status);
        }
        public Result<T> SelectOne<T>(string spName,
                    object? parameters = null) where T : DTO, new()
        {
            using var con = new SqlConnection(Helper.conStr);
            var p = new DynamicParameters(parameters);
            p.Add(
                "ReturnValue",
                dbType: DbType.Int32,
                direction: ParameterDirection.ReturnValue
            );
            var record = con.QuerySingleOrDefault<T>(
                    spName,
                    p,
                    commandType: CommandType.StoredProcedure
                )!;
            
           int status = p.Get<int>("ReturnValue");
            return new Result<T>(record,status);
        }

    }
}
