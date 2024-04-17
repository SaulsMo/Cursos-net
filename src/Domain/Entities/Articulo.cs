namespace Domain.Entities;

public sealed class Articulo : Entity<Guid>
{
    /*Constructor EFCore*/

    private class Articulo()
    {
    }

    /// <summary>
    /// Existencia del articulo
    /// </summary>
    /// <value>String con el Nombre que aplica al Cliente.</value>
    public string Existencia{get; private set;} = string.Empty;

    public int Descuento{get; private set;} = 0;

    public int PrecioUnitario{get; private set;} = 0:
    
}