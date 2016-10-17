//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should reference the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be:
//"Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

namespace HelpDeskDataServiceCS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;

    //Listing 9-2. Domain Service Code for Retrieving Records
    [Description("Enter the connection string to the HelpDesk DB")]
    public class EngineerDataService : DomainService
    {
        private readonly List<EngineerRecord> _EngineerRecordList;

        public EngineerDataService()
        {
            _EngineerRecordList = new List<EngineerRecord>();
        }

        string _connectionString;
        public override void Initialize
           (System.ServiceModel.DomainServices.Server.DomainServiceContext
              context)
        {
            _connectionString = ConfigurationManager.ConnectionStrings
              [this.GetType().FullName].ConnectionString;
            base.Initialize(context);
        }

        [Query(IsDefault = true)]
        public IQueryable<EngineerRecord> GetEngineerData()
        {
            _EngineerRecordList.Clear();

            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText =
                       @"SELECT Id , Surname , Firstname , DateOfBirth , SecurityVetted , IssueCount 
                        FROM dbo.Engineers eng JOIN  ( SELECT Engineer_Issue,  COUNT(Engineer_Issue) IssueCount   
                        FROM  dbo.Issues GROUP BY Engineer_Issue) AS iss ON eng.Id = iss.Engineer_Issue";

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            EngineerRecord Engineer = new EngineerRecord();
                            Engineer.Id = (int)dr["Id"];
                            Engineer.Surname = dr["Surname"].ToString();
                            Engineer.Firstname = dr["Firstname"].ToString();
                            Engineer.DateOfBirth = (DateTime)dr["DateOfBirth"];
                            Engineer.SecurityVetted = (bool)dr["SecurityVetted"];
                            Engineer.IssueCount = (int)dr["IssueCount"];
                            _EngineerRecordList.Add(Engineer);
                        }
                    }
                    cnn.Close();
                }
            }

            return _EngineerRecordList.AsQueryable();
        }

        // Listing 9-3. Updating and Inserting Data
        public void UpdateEngineerData(EngineerRecord Engineer)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText =
                        @"UPDATE Engineers    
                            SET [Surname] = @Surname, 
                            [Firstname] = @Firstname, 
                            [DateOfBirth] = @DateOfBirth, 
                            [SecurityVetted] = @SecurityVetted  
                        WHERE Id=@Id";

                    cmd.Parameters.AddWithValue("Surname", Engineer.Surname);
                    cmd.Parameters.AddWithValue("Firstname", Engineer.Firstname);
                    cmd.Parameters.AddWithValue("DateOfBirth", Engineer.DateOfBirth);
                    cmd.Parameters.AddWithValue("SecurityVetted", Engineer.SecurityVetted);
                    cmd.Parameters.AddWithValue("Id", Engineer.Id);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        public void InsertEngineerData(EngineerRecord Engineer)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText =
                            @"INSERT INTO Engineers (Surname, Firstname, DateOfBirth, SecurityVetted)      
                                VALUES  (@Surname, @Firstname, @DateOfBirth, @SecurityVetted);
                                SELECT @@Identity ";

                    cmd.Parameters.AddWithValue("Surname", Engineer.Surname);
                    cmd.Parameters.AddWithValue("Firstname", Engineer.Firstname);
                    cmd.Parameters.AddWithValue("DateOfBirth", Engineer.DateOfBirth);
                    cmd.Parameters.AddWithValue("SecurityVetted", Engineer.SecurityVetted);
                    cnn.Open();
                    Engineer.Id = (int)cmd.ExecuteScalar();
                    cnn.Close();
                }
            }
        }

        //Listing 9-5. Deleting Records
        public void DeleteEngineerData(EngineerRecord Engineer)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText =
                            "DeleteEngineer";
                    cmd.Parameters.AddWithValue("@ID", Engineer.Id);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }
    }
}