using System;
using System.Collections.Generic;

namespace HomeWork14
{
    class Program
    {
         
        delegate T Operation<T>(T x, T y);
        static void Main(string[] args)
        {
            

                bool  sss = true;
                while(sss)
                {
                       Console.ForegroundColor = ConsoleColor.Yellow;
                       System.Console.WriteLine("Choose your operations(*,/,+,-):");
                       System.Console.WriteLine("1.Multiply(*):");
                      
                }   
            

            
        }
        
        
        static T Multiply<T>(T x, T y){

            return (dynamic)x * (dynamic)y;
        }
        static T Divide<T>(T x, T y){

            return (dynamic)x / (dynamic)y;
        }
        static T Sum<T>(T x, T y)
        {
            return (dynamic)x + (dynamic)y;
        }

        static T Minus<T>(T x, T y)
        {
            return (dynamic)x - (dynamic)y;
        }
     }

    

     
 }

    

   
