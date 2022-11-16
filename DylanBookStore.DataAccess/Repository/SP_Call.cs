using System;
using System.Collections.Generic;
using DylanBookStore.DataAccess.Repository.IRepository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace DylanBookStore.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        public SP_Call()
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Execute(string procedureName, DynamicRelationalParameter param = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List<T>(string procedureName, DynamicRelationalParameter param = null)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedureName, DynamicRelationalParameter param = null)
        {
            throw new NotImplementedException();
        }

        public T OneRecord<T>(string procedureName, DynamicRelationalParameter param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                var value = sqlCon.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
                return (T)Convert.ChangeType(value.FirstOrDefault(), typeof(T));
            }
        }

        public T Single<T>(string procedureName, DynamicRelationalParameter param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))

            sqlCon.Open();
            return (T)Convert.ChangeType(SqlConnection.ExectuteScalar<T>(procedureName, param, System.Data.CommandType.StoredProcedure), typeof(T));
        }
    }
}

