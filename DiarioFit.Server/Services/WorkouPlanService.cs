using DiarioFit.Intf.Models;
using DiarioFit.Server.Services.Base;

namespace DiarioFit.Server.Services
{
    public class WorkoutPlanService : DiarioFitBaseService<WorkoutPlan>
    {
        public WorkoutPlanService(AppDbContext context) : base(context)
        {
        }
    }
}
