namespace lab11.Services
{
    public class GetDataService : IGetData
    {
        public int firstNumber { get; private set; }
        public int secondNumber { get; private set; }

        public GetDataService()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            (firstNumber, secondNumber) = (random.Next() % 10, random.Next() % 10);
        }

        public int Sum()
        {
            return firstNumber + secondNumber;
        }

        public int Mult()
        {
            return firstNumber * secondNumber;
        }

        public int Sub()
        {
            return firstNumber - secondNumber;
        }

        public int Div()
        {
            try
            {
                var divResult = firstNumber / secondNumber;
                return divResult;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }
    }
}
