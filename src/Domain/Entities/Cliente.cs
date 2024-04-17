namespace Domain.Entities;

public sealed class Cliente : Entity<Guid>
{
    /**Constructor for EFCore*/
    private Cliente(
        Cliente id,
        string nombre,
        string direccion,
        int credito,
        int saldo,
        int? descuento)
        : base(id)
    {
        Nombre = nombre;
        Direccion = direccion;
        Credito = credito;
        Saldo = saldo;
        Descuento = descuento;
    }


    private class Cliente()
    {
    }

    /*Proprieties*/

    /// <summary>
    /// Nombre del cliente
    /// </summary>
    /// <value>String con el Nombre que aplica al Cliente.</value>
    public string Nombre{get; private set;} = string.Empty;

    /// <summary>
    /// Direccion del Cliente
    /// </summary>
    public string Direccion{get; private set;} = string.Empty;
    
    /// <summary>
    /// Credito del Cliente
    /// </summary>
    /// <value>Int con el Credito que aplica al Cliente.</value>
    public int Credito{get; private set;} = 0;

    /// <summary>
    /// Saldo del Cliente
    /// </summary>
    public int Saldo{get; private set;} = 0;

    /// <summary>
    /// Descuento del Cliente
    /// </summary>
    public int? Descuento{get; private set;}

    /*
    * Exponer Constructor
    */

    public static Cliente Create(
        string Nombre,
        string Direccion,
        int Credito,
        int Saldo,
        int? Descuento)
    {
        var cliente = new Cliente(
            
        )
    }
}