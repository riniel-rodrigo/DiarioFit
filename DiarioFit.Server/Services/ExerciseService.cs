using DiarioFit.Intf.Models;
using DiarioFit.Server.Services.Base;

namespace DiarioFit.Server.Services
{
    public class ExerciseService : DiarioFitBaseService<Exercise>
    {
        public ExerciseService(AppDbContext context) : base(context)
        {
        }
    }
}
