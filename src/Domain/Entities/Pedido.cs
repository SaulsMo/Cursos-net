namespace Domain.Entities;

public sealed class Pedido : Entity<Guid>
{
    /*Constructor EFCore*/

    private class Pedido
    {
    }

    /// <summary>
    /// Fecha en la que se realiza dicho pedido
    /// </summary>
    /// <value>String con el Nombre que aplica al Cliente.</value>
    public string FechaPedido{get; private set;} = string.Empty;
    
    public int Total{get; set private sbyte;} = 0;

}