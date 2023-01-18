namespace ChoreScore.Controllers;
[ApiController]
[Route("api/chores")]

public class ChoreController : ControllerBase
{
    private readonly ChoreService _choreService;
    public ChoreController(ChoreService choreService)
    {
        this._choreService = choreService;
    }

    [HttpGet]
    public ActionResult<List<Chore>> Get()
    {
        try
        {
            List<Chore> chores = _choreService.Get();
            return Ok(chores);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Chore> Create([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = _choreService.Create(choreData);
            return Ok(chore);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Remove(int id)
    {
        try
        {
            string message = _choreService.Remove(id);
            return Ok(message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}