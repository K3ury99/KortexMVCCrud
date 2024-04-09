using System;
using System.Collections.Generic;

namespace KortexCrud.Models;

public partial class Vendedor
{
    public int IdVendedor { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Telefono { get; set; }
}
