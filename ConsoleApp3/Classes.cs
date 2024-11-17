namespace ConsoleApp3;
class Classes
    {
        

    // کلاس پایه برای محاسبات
    public abstract class Calculator
    {
        public abstract bool IsTrue(uint number);
    }

    // کلاس برای بررسی اعداد اول ساده
    public class SimplePrime : Calculator
    {
        public override bool IsTrue(uint number)
        {
            if (number < 2) return false;
            for (uint i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }

    // کلاس برای بررسی اعداد اول با الگوریتم پیشرفته
    public class ProPrime : Calculator
    {
        public override bool IsTrue(uint number)
        {
            // الگوریتم پیشرفته برای بررسی عدد اول
            if (number < 2) return false;
            if (number % 2 == 0) return number == 2;
            for (uint i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }

    // کلاس برای بررسی اعداد پالیندروم
    public class Palindrome : Calculator
    {
        public override bool IsTrue(uint number)
        {
            string str = number.ToString();
            return str == new string(str.Reverse().ToArray());
        }
    }

    // کلاس کارخانه برای ایجاد نمونه‌های مختلف
    public static class CalcFactory
    {
        public static Calculator Factory(uint number, string cal)
        {

            Calculator calc;
            switch (cal)
            {
                case "Prime":
                    if (number <= 1000)
                        calc = new SimplePrime();
                    break;
                if(number >= 1000)
                        calc = new ProPrime();
                    else calc = new ProPrime();
                case "Palindrome":
                    calc = new Palindrome();
                    break;
                case "ProPrime":
                    if (number >= 1000)
                        calc = new ProPrime();
                    break;
                default:
                    throw new ArgumentException("Invalid calculation type");
                    
                    
            }
            return calc;
        }
    }
}

