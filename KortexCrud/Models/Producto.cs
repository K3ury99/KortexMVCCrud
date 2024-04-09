using System;
using System.Collections.Generic;

namespace KortexCrud.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Nombre { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }
}
