using TheSimpleShopApi.Shared.Interfaces;

namespace TheSimpleShopApi.Shared.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor
                ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        // This is a mock implementation of the CurrentUserService - Once the user application logic is implemented, this will be updated
        public string UserId => Guid.NewGuid().ToString(); 

        public bool IsAdmin => throw new NotImplementedException();
    }
}
