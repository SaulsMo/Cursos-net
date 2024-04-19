using Domain.Abstractions;

namespace Domain.Abstractions;

namespace Domain.Entities;

public sealed class Pedido : Entity<ClientePed>
{


    private Pedido(
        ClientePed id,
        string fechapedido,
        int total
    )
    : base(id)
    {
        FechaPedido = fechapedido;
        Total = total;
    }

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

    /*Exponer el Constructor*/

    public static Pedido Create(
        string FechaPedido,
        int Total)
    {
        var pedido = new Pedido(
            id: new ClientePed(Nombre, Direccion, Saldo, Credito, Descuento),
            
        )
    }

}