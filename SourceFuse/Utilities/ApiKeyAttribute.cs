using Microsoft.AspNetCore.Mvc;

namespace SourceFuse.Utilities
{
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        public ApiKeyAttribute()
            : base(typeof(ApiKeyAuthFilter))
        {
        }
    }
}
