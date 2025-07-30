

using DiarioFit.Api.Controllers.Base;
using DiarioFit.Intf.Models;

namespace DiatioFit.Controllers;

public class ExercisesController : DiarioFitBaseController<Exercise, IExerciseService>
{

    public ExercisesController(IExerciseService service) : base(service)
    {

    }
}