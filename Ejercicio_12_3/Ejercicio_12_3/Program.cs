using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xceed.Wpf.Toolkit;

namespace Ejercicio_12_3
{
    class Program
    {

        class Excepciones
    {
        //Ejercicio 3 del Capitulo 12
        public void ExcepcionesArreglos()
        {
            
            MessageBox.Show("FormatException.");
            MessageBox.Show("IndexOutOfBoundsRange");
            MessageBox.Show("ArrayTypeMismatchException");
          
        }

        public void ExcepcionesStream()
        {

            MessageBox.Show("DirectoryNotFoundException");
            MessageBox.Show("FileNotFoundException");
            MessageBox.Show("IOException");
           
        }

        public void ExcepcionesWriteLine()
        {

            MessageBox.Show("ExceptionToString");
           
        }
    }
        static void Main(string[] args)
        {
            
        }
    }
}
