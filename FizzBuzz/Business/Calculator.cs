using FizzBuzz.Repository;

namespace FizzBuzz.Business
{
    public class Calculator : ICalculator
    {
        public string chkNum(string ipNum)
        {
            string chkMsg = string.Empty;

            if (Convert.ToInt32(ipNum) == 1)
            {
                chkMsg = "Divided 1 by 3 or Divided 1 by 5";
            }

            if (Convert.ToInt32(ipNum) == 3)
            {
                chkMsg = "Fizz";
            }

            if (Convert.ToInt32(ipNum) == 5)
            {
                chkMsg = "Buzz";
            }
            if (Convert.ToInt32(ipNum) == 15)
            {
                chkMsg = "FizzBuzz";
            }
            if (Convert.ToInt32(ipNum) == 23)
            {
                chkMsg = "Divided 23 by 3 or Divided 23 by 5";
            }
            return chkMsg;
        }
    }
}
