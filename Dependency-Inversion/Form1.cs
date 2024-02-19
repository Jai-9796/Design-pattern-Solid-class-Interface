using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dependency_Inversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        interface iloger { 
           
            string message { get; set; }
            void logcontext();
        
        }
        class HoldFileLog :iloger{ 
           
            public string message {  get; set; }
            public void logcontext() { 
                        
            }
        }

        class HoldBlogs:iloger { 
        
             public  string message { get; set; } 

            public void logcontext() { }    
        }

        class messagelogs {

            private iloger _iloger;   

            public messagelogs(iloger iloger)
            {

                _iloger = iloger; 
            }

            public void logcontext(iloger iloger) { 
            
              _iloger.logcontext();
            }

        
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
