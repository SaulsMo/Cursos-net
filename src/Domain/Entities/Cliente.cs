namespace Domain.Entities;

public sealed class Cliente : Entity<Guid>
{
    /**Constructor for EFCore*/

    private class Cliente
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
    /// DEscuento del Cliente
    /// </summary>
    public int Descuento{get; private set;} = 0;
}