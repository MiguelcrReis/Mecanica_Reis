﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Repositories
{
    public interface IConnectionManager
    {
        SqlConnection GetConnection();
    }
}
