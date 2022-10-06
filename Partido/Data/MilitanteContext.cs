using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Partido.Data
{
    public class MilitanteContext
    {
        public delegate Task<IDbConnection> GetConnection();
    }
}