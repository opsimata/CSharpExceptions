namespace csharp_exception
{
    public class SaldoInsufucienteException : OperacaoFinanceiraException
    {
        public SaldoInsufucienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
