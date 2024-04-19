namespace Domain.Entities;

public sealed class Articulo : Entity<Guid>
{
    /*Constructor Principal*/

    private Articulo(
        Guid id,
        string existencia,
        int descuento,
        int preciounitario)
        : base(id)
    {
        Existencia = existencia;
        Descuento = descuento;
        PrecioUnitario = preciounitario;
    }

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
    

    /*Exponer Constructor*/

    public static Articulo Create(
        string existencia,
        int descuento,
        int preciounitario)
    {
        var articulo = new Articulo(
            Guid.NewGuid(),
            existencia,
            descuento,
            preciounitario);

            return articulo;
    }
}