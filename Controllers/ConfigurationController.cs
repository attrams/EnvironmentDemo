using Microsoft.AspNetCore.Mvc;

namespace EnvironmentDemo.Controllers;

[Route("[controller]")]
[ApiController]
public class ConfigurationController(IConfiguration configuration) : ControllerBase
{
    [HttpGet("database-configuration")]
    public ActionResult GetDatabaseConfiguration()
    {
        var type = configuration["Database:Type"];
        var connectionString = configuration["Database:ConnectionString"];

        return Ok(new { Type = type, ConnectionString = connectionString });
    }
}