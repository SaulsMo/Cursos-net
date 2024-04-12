using FluentResults;

namespace Domain.Abstractions;

/// <summary>
/// Clase para manejo de errores.
/// </summary>
/// <param name="Code">Código de error.</param>
/// <param name="Description">Descripción del error.</param>
public record Error(string Code, string Description)
{
    /// <summary>
    /// Un error vacío.
    /// </summary>
    public static readonly Error None = new(string.Empty, string.Empty);

    /// <summary>
    /// Error de valores nulos.
    /// </summary>
    public static readonly Error NullValue = new("Error.NullValue", "Null value was provided");

    /// <summary>
    /// Método para convertir un error a Result.
    /// </summary>
    /// <returns>Objeto Result con los datos del error.</returns>
    public Result ToResult() => Result.Fail($"{Code} - {Description}");
}