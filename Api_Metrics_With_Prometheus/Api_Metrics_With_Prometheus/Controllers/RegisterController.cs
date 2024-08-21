using Api_Metrics_With_Prometheus.Dominio.Register;
using Api_Metrics_With_Prometheus.Interface;
using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Metrics_With_Prometheus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterRepository _registerRepository;

        public RegisterController(IRegisterRepository registerRepository)
        {
            _registerRepository = registerRepository;
        }

        [HttpPost("[action]")]
        
        public async Task<IActionResult> Create([FromBody] RegisterModel model)
        {
            try
            {
                await _registerRepository.CreateAsync(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                Random random = new Random();
                if (random.Next(0, 100) % 2 == 0)
                {

                    IEnumerable<RegisterModel> registers = await _registerRepository.GetAllAsync();
                    return Ok(registers);
                }
                else { 
                    return BadRequest("Error");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            try
            {
                RegisterModel register = await _registerRepository.GetByIdAsync(id);
                return Ok(register);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update([FromBody] RegisterModel model)
        {
            try
            {
                await _registerRepository.UpdateAsync(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                await _registerRepository.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
