namespace Domain.Validators

public sealed class FabricaValidator : AbstractValidator<Fabrica>
{
    public FabricaValidator()
    {
        RuleFor(f => f.Telefono).GreaterThanEqualTo(0)
        ;
    }
}