/// Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/functional/pattern-matching

namespace DemoFeatures
{
    public class PatternMatching
    {
        #region Sem pattern matching
        public static string ClassificarCidadaoSemPatternMatching(CidadaoDTO cidadao)
        {
            if (cidadao.Idade < 18)
            {
                return "Criança";
            }
            else if (cidadao.Idade >= 18 && cidadao.Idade < 60)
            {
                return "Adulto";
            }
            else
            {
                return "Idoso";
            }
        }
        #endregion

        #region Exemplo 1
        public static string ClassificarCidadaoExemploUm(CidadaoDTO cidadao)
        {
            return cidadao.Idade switch
            {
                < 18 => "Criança",
                >= 18 and < 60 => "Adulto",
                _ => "Idoso"
            };
        }
        #endregion

        #region Exemplo 2
        public static string ClassificarCidadaoExemploDois(CidadaoDTO cidadao)
        {
            return cidadao switch
            {
                { Idade: < 18 } => "Criança",
                { Idade: >= 18 and < 60 } => "Adulto",
                _ => "Idoso"
            };
        }
        #endregion

        #region Exemplo 3
        public static string ClassificarCidadaoExemploTres(CidadaoDTO cidadao)
        {
            if (cidadao is not null)
            {
                if (cidadao is { Idade: < 18 })
                    return "Criança";
                else if (cidadao is { Idade: >= 18 and < 60 })
                    return "Adulto";
                else
                    return "Idoso";
            }

            return "Cidadão inválido";
        }
        #endregion
    }
}
