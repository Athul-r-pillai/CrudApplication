using CrudApplication.CommonLayer.Model;

namespace CrudApplication.ServiceLayer
{
    public interface ICrudApplicationSL
    {
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request);
    }
}
