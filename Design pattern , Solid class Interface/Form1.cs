using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_pattern___Solid_class_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface Base { 
           
            string Name { get; set; }   
            string productmark { get; set; }    
            double salary { get; set; } 
                   
        }

        interface food {          
          double calorie { get; set; }                     
        }

        interface clothes { 
            int size { get; set; } 

        }

        class MEAL : Base, food { 
         
            public string Name { get; set;   }
            
            public string productmark { get; set; }
            public double salary { get; set; }

            public double calorie { get; set; } 
        }

        class trouser : Base, clothes {

            public   int size { get; set; }
            public string Name { get; set; }
            public string productmark { get; set; }
            public double salary { get; set; }

        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
