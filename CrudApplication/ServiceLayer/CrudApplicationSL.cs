using CrudApplication.CommonLayer.Model;
using CrudApplication.RepositoryLayer;

namespace CrudApplication.ServiceLayer
{
    public class CrudApplicationSL : ICrudApplicationSL
    {
        public readonly ICrudApplicationRL _crudApplicationRL;

        public CrudApplicationSL(ICrudApplicationRL crudApplicationRL)
        {
            _crudApplicationRL = crudApplicationRL;
        }

        public Task<AddInformationResponse> AddInformation(AddInformationRequest request)
        {
           // return
        }
    }
}
