using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Edad { get; set; }

    public string? Direccion { get; set; }

    public string? Numero { get; set; }

    public string? Email { get; set; }
}
