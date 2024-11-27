namespace DemoFeatures
{
    public class GlobalUsing
    {
        public static Task FiltrarListaNumeros(List<int> numeros)
        {
            var resultado = numeros.Where(numero => numero > 10).Take(5);
            return Task.FromResult(resultado);
        }
    }
}
