﻿namespace Laboratorium_3 {
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie8();
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
            int rx = 56;
            int ry = 34;
            int width = 23;
            int height = 12;
            int x = 23;
            int y = 11;
            bool isOnBorder;
            if ((x == rx || x == rx + width) && (y == ry || y == ry - height)){
                isOnBorder = true;
            }else{
                isOnBorder = false;
            }
    
            Console.WriteLine(isOnBorder);    
        }
        public static void Zadanie5(){
            double a = 2.5;
            double b = -0.5;
            double c = 1.5;

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
         public static void Zadanie6(){
            int code = 4;
            int quantity = 11;
            decimal price = 3.5m;
            decimal sellPrice;

            if (code < 10){
                sellPrice = price;
            }else if(code >= 10 && code <=15){
                sellPrice = price - (price * 0.05m);
            }else{
                if (quantity <= 10){
                    sellPrice = price + (price * 0.05m);
                }else if(quantity <= 20){
                    sellPrice = price;
                }else if(quantity < 100){
                    sellPrice = price - (price * ((quantity / 10) * 0.01m));
                }else{
                    sellPrice = price - (price * 0.05m);
                }
            }
            Console.WriteLine($"Price: {sellPrice}");
        }
        public static void Zadanie7(){
        int decimalNumber = 11;
        switch(decimalNumber){
            case 0:
                Console.WriteLine("Rzymianie nie znali zera!");
                break;
            case 1:
                Console.WriteLine("I");
                break;
            case 2:
                Console.WriteLine("II");
                break;
            case 3:
                Console.WriteLine("III");
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
                Console.WriteLine("VII");
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
            case 11:
                Console.WriteLine("XI");
                break;
            case 12:
                Console.WriteLine("XII");
                break;
            case 13:
                Console.WriteLine("XIII");
                break;
            case 14:
                Console.WriteLine("XIV");
                break;
            case 15:
                Console.WriteLine("XV");
                break;
            case 16:
                Console.WriteLine("XVI");
                break;
            case 17:
                Console.WriteLine("XVII");
                break;
            case 18:
                Console.WriteLine("XVIII");
                break;
            case 19:
                Console.WriteLine("XIX");
                break;
            case 20:
                Console.WriteLine("XX");
                break;
        } 
        if (decimalNumber < 0 || decimalNumber > 20){
            Console.WriteLine("Nie obsługuje liczb spoza zakresu od 1 do 20!");
        }
        }
        public static void Zadanie8(){
            char hex = '9';
            if(hex >= '0' && hex <= '9'){
                Console.WriteLine(hex);
            }else{
                switch(hex){
                    case 'A':
                    case 'a':
                        Console.WriteLine("10");
                        break;
                    case 'B':
                    case 'b':
                        Console.WriteLine("11");
                        break;
                    case 'C':
                    case 'c':
                        Console.WriteLine("12");
                        break;
                    case 'D':
                    case 'd':
                        Console.WriteLine("13");
                        break;
                    case 'E':
                    case 'e':
                        Console.WriteLine("14");
                        break;
                    case 'F':
                    case 'f':
                        Console.WriteLine("15");
                        break;
                    default:
                        Console.WriteLine("To nie jest cyfra szesnatkowa!");
                        break;
                }
            }
        }
    }
}