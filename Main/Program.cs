using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Program
    {
        abstract class burger { };

        abstract class desert { };

        abstract class recipeFactory {

            public abstract burger createburger(); 
            public abstract burger createdesert();
            
        }

        class steakburger  : burger { };

        class createbluer : burger { };

        class adultcuisneFactory : recipeFactory {

               public override burger createburger()
            {
                return createburger();
            }

               public override  burger createdesert() { 
               
                return createdesert();  
            }

        }

        class KidBurger :  desert {   
        
        
        } 

        class icecream : desert { };

        class KidcuiseneFactory : recipeFactory {

            public override burger createburger()
            {
                return createburger();     
           
            }

            public override burger createdesert() {  
              
                return createdesert();

            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("  where are you ");
            Console.WriteLine(" A adult ");
            Console.WriteLine(" K_Kid "); 
            char result  =   Console.ReadKey().KeyChar;

            recipeFactory factory = new adultcuisneFactory();

            switch (result)
            {

                case 'a':
                    factory = new adultcuisneFactory();
                    break;

                case 'k':
                    factory = new adultcuisneFactory(); 
                    break;  

                default:
                    break;
            }

            var burger =  factory .createburger();  
            var desert = factory .createdesert();

            Console.WriteLine("");
            Console.WriteLine("burger: " + burger.GetType().Name);
            Console.WriteLine(" dESERT:" +  desert.GetType().Name); 
        }
    }
}
