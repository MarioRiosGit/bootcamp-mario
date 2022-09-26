using Bootcamp.ViewModel;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Queries.DocumentType
{
    public class DocumenTypeQueries : IDocumenTypeQueries
    {
        private readonly string _connectionString;
        public DocumenTypeQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<IEnumerable<DocumenTypeViewModel>> GetAll()
        {
            IEnumerable<DocumenTypeViewModel> result = new List<DocumenTypeViewModel>();

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<DocumenTypeViewModel>("[dbo].[Usp_Sel_DocumentType]", commandType: System.Data.CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
