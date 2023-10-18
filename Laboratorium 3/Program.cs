namespace Laboratorium_3 {
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie6();
        }
        public static void BoolTytpe()
        {
            bool isWarm = false;
            bool isGreater = true;
        }
        public static void LogicOperators()
        {
            bool isWarm = false;
            //negacja
            bool isCold = !isWarm;
            //iloczyn AND
            bool isShinning = true;
            bool canWalk = !isCold && !isShinning;
            // alternatywa OR
            bool haveMoney = false;
            bool isCreditCardActive = true;
            bool canPay = haveMoney || isCreditCardActive;
        }

        public static void IfStatement()
        {
            bool haveMoney = true;
            if (haveMoney)
            {
                Console.WriteLine("Płace");
            }
            Console.WriteLine("Instrukcja za if");
        }

        public static void IfElseStatement()
        {
            bool haveMoney = true;
            if (haveMoney)
            {
                Console.WriteLine("Płace");
            }
            else
            {
                Console.WriteLine("Nie mogę zapłacić");
            }
        }

        public static void CompareOperators()
        {
            double temperature = 13;
            double luminance = 120;
            bool isWarm = temperature >= 15;
            bool isSinning = luminance > 400;
            bool isDark = luminance <= 100;
            if (isWarm && isSinning)
            {
                Console.WriteLine("Ide na spacer");
            }
            else
            {
                Console.WriteLine("Zostaje w domu");
            }
        }

        public static void EqualityOperator(){
            double a = 1;
            bool isZero = a == 0;

            bool isWarm = false;
            bool isWarmTrue = isWarm == true;
        }

        public static void SwitchStatement()
        {
            int number = 4;
            switch (number){
                default:
                    Console.WriteLine($"Nie znam takiej liczby {number}");
                    break;
                case 1:
                    Console.WriteLine("I");
                    break;
                case 2:
                    Console.WriteLine("II");
                    break;
                case 3: Console.WriteLine("III");
                    break;
                case 4:
                    Console.WriteLine("IV");
                    break;
                case 5:
                    Console.WriteLine("V");
                    break;
                case 6:
                    Console.WriteLine("VI");
                    break;
                case 7:
                    Console.WriteLine("VI");
                    break;
                case 8:
                    Console.WriteLine("VIII");
                    break;
                case 9:
                    Console.WriteLine("IX");
                    break;
                case 10:
                    Console.WriteLine("X");
                    break;
            }
        }

        public static void Zadanie1()
        {
            decimal balans = 56;
            bool isCreditCardValid = false;
            decimal price = 45;
            bool canPay;
            
            if( balans >= price && isCreditCardValid == true)
            {
                canPay = true;
            }else{
                canPay= false;
            }
            Console.WriteLine(canPay);
        }

        public static void Zadanie2(){
              double a = 5;
              double b = 1;
              double c = 3;
              bool isTriangle;
              if (a > (b+c)){
                isTriangle = true;
              }else{
                isTriangle = false;
              }
              Console.WriteLine(isTriangle);
          }
        /*public static void Zadanie3()
        {
            double cx = 2.56;
            double cy = 4.6;
            double cradius = 5;
            double x = 6.4;
            double y = 2.234;
            bool isOutside;
            if (){
                isOutside = true;
            }
            else{
                isOutside = false;
            }
            Console.WriteLine($"Is Outside = {isOutside}");
        }*/
        public static void Zadanie4(){
            double a = 2;
            double b = 4;
            double c = 2;

            double x1;
            double x2;
            double delta = (b * b) - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine($"x1 = x2 = {x1}");
            }
            else if (delta < 0)
            {
                Console.WriteLine("Brak pierwiastków rzeczywistych");
            }
        }
        public static void Zadanie5(){
            int coin = 0;
            switch (coin){
                default:
                    Console.WriteLine($"Brak takiego nominału {coin}");
                    break;
                case 1: Console.WriteLine("1zł");
                    break;
                case 2: Console.WriteLine("2zł");
                    break;
                case 5: Console.WriteLine("5zł");
                    break;
            }
        }
        public static void Zadanie6(){
            char letter = 'A';
            switch (letter){
                default: Console.WriteLine("spółgłoska");
                        break;

                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'u':
                case 'U':
                case 'y':
                case 'Y':
                    Console.WriteLine("samogłoska");
                    break;
            }
        }
    }
}