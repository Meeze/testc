using Microsoft.AspNetCore.Mvc;
using WebApplication5.DTO;


[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private readonly ITestService _testService;
    
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateTest([FromBody] TestDTO request)
    {
        // Map DTO to domain-friendly input
        var result = await _testService.CreateAsync(request.Name);
        if (result >= 0)
            return Ok(result);
        return BadRequest("some error lol");
    }

    [HttpGet]
    [Route("delete/{id}")]
    public async Task<IActionResult> DeleteTest(int id)
    {
        // Map DTO to domain-friendly input
        var result = await _testService.DeleteAsync(id);
        if (result)
            return Ok(result);
        return BadRequest(result);
    }

    [HttpGet]
    [Route("get/{id}")]
    public async Task<IActionResult> GetTest(int id)
    {
        // Map DTO to domain-friendly input
        var result = await _testService.GetAsync(id);
        if (result.Id > 0)
            return Ok(result);
        return BadRequest(id);
    }
}