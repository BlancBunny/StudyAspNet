using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DBHandlingWebApp.Models
{
    public class MaximRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

        public Maxim AddMaxim(Maxim maxim)
        {
            string query = @"INSERT INTO Maxims (Name, Contents, RegDate) 
                                    VALUES(@Name, @Contents, getdate());
                                    SELECT CAST(SCOPE_IDENTITY() AS INT); "; 
            var id = db.Query<int>(query, maxim).Single();
            maxim.Id = id;
            return maxim;
        }
    }
}


