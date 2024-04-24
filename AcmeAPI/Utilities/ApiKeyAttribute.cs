using Microsoft.AspNetCore.Mvc;

namespace AcmeAPI.Utilities
{
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        public ApiKeyAttribute()
            : base(typeof(ApiKeyAuthFilter))
        {
        }
    }
}
