using CrudApplication.CommonLayer.Model;

namespace CrudApplication.RepositoryLayer
{
    public interface ICrudApplicationRL
    {
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request);

    }
}
