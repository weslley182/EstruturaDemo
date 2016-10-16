using System.Data.Entity;
using System.Web;

namespace EstruturaDemo.Infra.Repository.EF
{
    public class ContextManager
    {
        private const string ContextKey = "ContextManager.Context";

        public DbContext Context
        {
            get
            {
                if (HttpContext.Current.Items[ContextKey] == null)
                {
                    HttpContext.Current.Items[ContextKey] = new EstruturaContext();
                }

                return (EstruturaContext)HttpContext.Current.Items[ContextKey];
            }
            
        }
    }
}
