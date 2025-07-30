using DiarioFit.Intf.Models;
using DiarioFit.Server.Services.Base;

namespace DiarioFit.Server.Services
{
    public class WorkoutService : DiarioFitBaseService<Workout>
    {
        public WorkoutService(AppDbContext context) : base(context)
        {
        }
    }
}
