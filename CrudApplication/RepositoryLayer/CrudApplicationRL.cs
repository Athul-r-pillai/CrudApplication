using CrudApplication.CommonLayer.Model;

namespace CrudApplication.RepositoryLayer
{
    public class CrudApplicationRL : ICrudApplicationRL
    {
        public readonly IConfiguration _configuration;
        public readonly MySqlConnection _mySqlConnection;
        public CrudApplicationRL(IConfiguration configuration) 
        {
            _configuration = configuration;
            _mySqlConnection = new MySqlConnection(_configuration["ConnectionStrings:MySqlDBString"]);
        }
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request)
        {
            AddInformationResponse response = new AddInformationResponse();
            try 
            {
            }
            catch(Exception ) 
            {
            }
            return response;
        }
    }

    public class MySqlConnection
    {
    }
}
