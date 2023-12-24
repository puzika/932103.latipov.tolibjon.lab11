namespace lab11.Services
{
    public interface IGetData
    {
        int firstNumber { get; }
        int secondNumber { get; }
        int Sum();
        int Sub();
        int Mult();
        int Div();
    }
}
