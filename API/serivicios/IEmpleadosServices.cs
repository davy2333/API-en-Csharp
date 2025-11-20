using API.Models;

namespace API.serivicios
{
    public interface IEmpleadosServices
    {
        Task<List<Empleado>> GetEmpleados();
        Task<int> AddEmpleados(Empleado modelo);
        Task<int> UpdateEmpleados(Empleado modelo);
        Task<int> DeleteEmpleados(int id);

    }
}
