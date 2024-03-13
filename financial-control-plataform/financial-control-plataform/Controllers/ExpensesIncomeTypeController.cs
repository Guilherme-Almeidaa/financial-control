using financial_control_plataform.Entities;
using financial_control_plataform.Responses;
using financial_control_plataform.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace financial_control_plataform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesIncomeTypeController : ControllerBase
    {
        private readonly IDomainService<ExpensesIncomeType> _domainService;
        public ExpensesIncomeTypeController(IDomainService<ExpensesIncomeType> domainService)
        {
            _domainService = domainService;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ExpensesIncomeTypeResponse))]
        public async Task<IActionResult> Get()
        {
            var result = await _domainService.GetAsync(x => x.Name == "Test");
            return Ok(result);
        }
    }
}
