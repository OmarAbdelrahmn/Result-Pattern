namespace Result_Pattern.Abstraction;

public record Error(string Code, string Description, int? StatusCode)
{
    public static Error Non => new(string.Empty, string.Empty, null);
}
