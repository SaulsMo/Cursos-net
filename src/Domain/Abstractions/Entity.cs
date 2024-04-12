namespace Domain.Abstractions;

/// <summary>
/// Abstracción que define métodos básicos a toda Entity.
/// </summary>
public abstract class Entity<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Entity"/> class.
    /// </summary>
    /// <param name="id">Identificador de la Entity.</param>
    protected Entity(T id)
    {
        Id = id;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Entity"/> class.
    /// </summary>
    protected Entity()
    {
    }

    /// <summary>
    /// Identificador de la Entity.
    /// </summary>
    public T Id { get; init; }
}