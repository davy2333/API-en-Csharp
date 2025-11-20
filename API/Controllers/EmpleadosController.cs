using API.Models;
using API.serivicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmpleadosServices _service;
        public EmpleadosController(IEmpleadosServices service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("Listar")]

        public async Task<IActionResult> ListarEmpleados()
        {
            var empleados = await _service.GetEmpleados();
            return Ok(empleados);
        }
        [HttpPost]
        [Route("Agregar")]
        public async Task<IActionResult> AddEmpleados([FromBody] Empleado modelo)
        {
            var filas = await _service.AddEmpleados(modelo);
            return Ok(filas);
        }

        [HttpPut]
        [Route("Modificar")]
        public async Task<IActionResult> UpdateEmpleados([FromBody] Empleado modelo)
        {
            var filas = await _service.UpdateEmpleados(modelo);
            return Ok(filas);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public async Task<IActionResult> DeleteEmpleados(int id)
        {
            var filas = await _service.DeleteEmpleados(id);
            if (filas == 0)
                return NotFound();
            return NoContent();
        }
    }
}
