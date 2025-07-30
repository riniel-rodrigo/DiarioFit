using DiarioFit.Intf.Models;
using DiarioFit.Server.Services.Base;

namespace DiarioFit.Server.Services
{
    public class SetService : DiarioFitBaseService<Set>
    {
        public SetService(AppDbContext context) : base(context)
        {
        }
    }
}
