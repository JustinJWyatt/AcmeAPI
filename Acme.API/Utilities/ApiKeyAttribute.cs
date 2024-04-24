using Microsoft.AspNetCore.Mvc;

namespace Acme.API.Utilities
{
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        public ApiKeyAttribute()
            : base(typeof(ApiKeyAuthFilter))
        {
        }
    }
}
