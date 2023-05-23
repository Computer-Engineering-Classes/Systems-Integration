using Microsoft.AspNetCore.Mvc;
using RestApi.Models;

namespace RestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return Ok("Hello World!");
    }

    [HttpPost("add")]
    public ActionResult<int> Add([FromBody] Numbers numbers)
    {
        return Ok(numbers.A + numbers.B);
    }

    [HttpPost("subtract")]
    public ActionResult<int> Subtract([FromBody] Numbers numbers)
    {
        return Ok(numbers.A - numbers.B);
    }

    [HttpPost("multiply")]
    public ActionResult<int> Multiply([FromBody] Numbers numbers)
    {
        return Ok(numbers.A * numbers.B);
    }

    [HttpPost("divide")]
    public ActionResult<double> Divide([FromBody] Numbers numbers)
    {
        if (numbers.B == 0) return BadRequest("Cannot divide by zero");

        return Ok((double)numbers.A / numbers.B);
    }

    [HttpPost("remainder")]
    public ActionResult<int> Remainder([FromBody] Numbers numbers)
    {
        if (numbers.B == 0) return BadRequest("Cannot divide by zero");
        return Ok(numbers.A % numbers.B);
    }

    [HttpPost("power")]
    public ActionResult<int> Power([FromBody] Numbers numbers)
    {
        if (numbers.B < 0) return BadRequest("Cannot raise to a negative power");
        return Ok((int)Math.Pow(numbers.A, numbers.B));
    }

    [HttpPost("mean")]
    public ActionResult<double> Mean([FromBody] int[] numbers)
    {
        if (numbers.Length == 0) return BadRequest("Cannot calculate mean of zero numbers");
        return Ok(numbers.Average());
    }

    [HttpPost("median")]
    public ActionResult<double> Median([FromBody] int[] numbers)
    {
        if (numbers.Length == 0) return BadRequest("Cannot calculate median of zero numbers");
        Array.Sort(numbers);
        return numbers.Length % 2 == 0
            ? Ok((numbers[numbers.Length / 2] + numbers[numbers.Length / 2 - 1]) / 2.0)
            : Ok(numbers[numbers.Length / 2]);
    }

    [HttpPost("max")]
    public ActionResult<int> Max([FromBody] int[] numbers)
    {
        if (numbers.Length == 0) return BadRequest("Cannot calculate max of zero numbers");
        return Ok(numbers.Max());
    }

    [HttpPost("min")]
    public ActionResult<int> Min([FromBody] int[] numbers)
    {
        if (numbers.Length == 0) return BadRequest("Cannot calculate min of zero numbers");
        return Ok(numbers.Min());
    }
}