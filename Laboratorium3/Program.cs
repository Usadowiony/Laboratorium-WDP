namespace Laboratorium_3 {
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie3();
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
        public static void Zadanie3()
        {
            double cx = 2.56;
            double cy = 4.6;
            double cradius = 5;
            double x = 6.4;
            double y = 2.234;
            bool isOutside;
            double distance = Math.Sqrt(Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2));
            isOutside = distance > cradius;
            Console.WriteLine($"Is Outside = {isOutside}");
        }
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