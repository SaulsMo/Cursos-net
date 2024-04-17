namespace Domain.Validators

public sealed class ArticuloValidator : AbstractValidator<Articulo>
{
    public ArticuloValidator()
    {
        RuleFor(a => a.Existencia).NotNull()
            .NotEmpty()
        ;
        
        RuleFor(a => a.Descuento). GreaterThanEqualTo(0)
        ;

        RuleFor(a => a.PrecioUnitario). GreaterThanEqualTo(0)
        ;
    }
}