using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abstractpatern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class burger { };

        abstract class dessert { };

        abstract class recipeFactory {

            public abstract burger createburger(); 
            public abstract dessert createdesert ();

        }

        class steaakburger : burger { }; 
        class createbluer : dessert { };

        class AdultCuisineFactory : recipeFactory { 
            
            public override burger createburger()
            {
                 return createburger(); 
            }

            public override dessert createdesert()
            {
                return createdesert();     
            }
        }

        class kidburger : dessert { 
                
        };

        class icecream: dessert { };

        class kidCuisineFactory : recipeFactory {

            public override burger createburger()
            {
                return createburger(); 

            }

            public override dessert createdesert()
            {
                return createdesert (); 
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("where are you ") ;
            Console.WriteLine(" A adult ");
            Console.WriteLine(" K- kid"); 
            char result  =   Console.ReadKey().KeyChar;
            recipeFactory factory = new AdultCuisineFactory();
            switch (result) {

                case 'A':
                    factory = new AdultCuisineFactory();
                    break;
                case 'K':
                    factory  = new AdultCuisineFactory();
                    break;
                default:
                    break;

            
            }

            var burger = factory.createburger(); 
            var desert =  factory.createdesert();

            Console.WriteLine(""); 
            Console.WriteLine("burger : "  + burger.GetType().Name);
            Console.WriteLine("Desert:" + desert.GetType().Name);

; 
        }
    }
}
