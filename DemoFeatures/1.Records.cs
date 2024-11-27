/// Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/record

namespace DemoFeatures
{
    #region Classe
    public class NoticiaDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public DateTime Data { get; set; }
    }
    #endregion

    #region Record
    public record LocalDTO(int Id, string Nome, string Endereco, bool Ativo);

    public record CidadaoDTO(int Id, string Nome, int Idade, string Cpf, bool Ativo);
    #endregion
}
