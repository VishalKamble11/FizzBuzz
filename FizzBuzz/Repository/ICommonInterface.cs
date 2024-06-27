namespace FizzBuzz.Repository
{
    public class ICommonInterface
    {
        interface IResultNum
        {
              public string getResultNum(int ipNum);
        }

        interface IResultChar
        {
             public string getResultChar (string ipChar);
        }
    }
}
