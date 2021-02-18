using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Cms.Models
{
    public class Context
    {
       
        public async Task<List<Target>> GetContacts(string conn, int contactId)
        {
            string sqlExpression = $"EXEC GetContacts @contactId={contactId}";
            using var connection = new SqlConnection(conn);
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            //command.Parameters.Add(new SqlParameter("@contactId", contactId));
            await connection.OpenAsync();

            using var dataReader = await command.ExecuteReaderAsync();
            var targets = new List<Target>();
            while (await dataReader.ReadAsync())
            {
                var target = new Target()
                {
                    ContactsName = dataReader[nameof(Target.ContactsName)].ToString(),
                    Number = dataReader[nameof(Target.Number)].ToString(),
                    IsActive = (Status)Enum.Parse(typeof(Status), dataReader[nameof(Target.IsActive)].ToString())
                };
                targets.Add(target);
            }
            return targets;
        }
        
    }
}
