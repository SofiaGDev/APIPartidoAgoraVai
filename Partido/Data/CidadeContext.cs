using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Partido.Data
{
    public class CidadesContext
    {
        public delegate Task<IDbConnection> GetConnection();
    }
}