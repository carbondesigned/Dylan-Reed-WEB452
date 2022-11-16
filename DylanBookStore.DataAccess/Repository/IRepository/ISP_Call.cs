using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace DylanBookStore.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedureName, DynamicRelationalParameter param = null);
        void Execute(string procedureName, DynamicRelationalParameter param = null);
        T OneRecord<T>(string procedureName, DynamicRelationalParameter param = null);
        IEnumerable<T> List<T>(string procedureName, DynamicRelationalParameter param = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedureName, DynamicRelationalParameter param = null);
    }
}

