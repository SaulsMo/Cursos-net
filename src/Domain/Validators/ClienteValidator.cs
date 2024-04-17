namespace Domain.Validators

public sealed class ClienteValidator : AbstractValidator<Cliente>
{
    public ClienteValidator()
    {
        RuleFor(x => x.Nombre).NotNull()
            .NotEmpty()
        ;

        RuleFor(x => x.Direccion).NotNull()
            .NotEmpty()
        ;

        RuleFor(x => x.Direccion).NotNull()
            .NotEmpty()
        ;

        RuleFor(x => x.Credito).GreaterThanEqualTo(0)
        ;

        RuleFor(x => x.Saldo).GreaterThanEqualTo(0)
        ;

        RuleFor(x => x.).GreaterThanEqualTo(0)
        ;

        RuleFor(x => x.Descuento).GreaterThanEqualTo(0)
        ;
    }
}