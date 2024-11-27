/// Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/proposals/csharp-9.0/init

namespace DemoFeatures
{
    public class Carro
    {
        public string Marca { get; init; } = string.Empty;
        public string Modelo { get; init; } = string.Empty;

        public override string ToString()
        {
            return $"Marca: {Marca} - Modelo: {Modelo}";
        }
    }
}
