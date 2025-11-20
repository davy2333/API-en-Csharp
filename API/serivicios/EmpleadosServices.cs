using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.serivicios
{
    public class EmpleadosServices : IEmpleadosServices
    {

        private readonly EmpresaContext _context;
        private readonly DbSet<Empleado> _dbSet;

        public EmpleadosServices(EmpresaContext context)
        {
            _context = context;
            _dbSet = _context.Set<Empleado>();
        }

        public async Task<int> AddEmpleados(Empleado modelo)
        {
            await _context.Empleados.AddAsync(modelo);

            int filasAfectadas = await _context.SaveChangesAsync();

            return filasAfectadas;
        }

        public async Task<List<Empleado>> GetEmpleados()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<int> DeleteEmpleados(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null)
            {
                return 0;
            }
            _context.Empleados.Remove(empleado); 
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateEmpleados(Empleado modelo)
        {
            _context.Empleados.Update(modelo);
            return await _context.SaveChangesAsync();

        }
    }
}
