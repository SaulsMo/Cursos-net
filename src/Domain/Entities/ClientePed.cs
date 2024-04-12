namespace Domain.Entities;

public record ClientePed(
    string Nombre,
    string Direccion,
    int Saldo,
    int Credito,
    int Descuento);