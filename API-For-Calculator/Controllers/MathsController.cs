using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_For_Calculator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathsController : ControllerBase
    {
        [HttpGet]
        public double Addition(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        [HttpGet]
        public double Subtraction(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        [HttpGet]
        public double Multiplication(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        [HttpGet]
        public double Division(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
