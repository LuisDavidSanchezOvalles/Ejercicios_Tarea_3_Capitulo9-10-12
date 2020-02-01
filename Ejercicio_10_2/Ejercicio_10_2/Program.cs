using System;
using System.Text;

namespace Ejercicio_10_2
{
    public class EstudianteEscuela
    {
        private string Matricula;
        private string Nombres;
        private string Apellidos;
        private int Edad;
        private string Direccion;
        private string Grado;
        private string Seccion;
        private double promedioSemestral;
        private string NombresPadre;
        private string NombresMadre;
        private string CedulaPadre;
        private string CedulaMadre;

        public EstudianteEscuela()
        {

        }

        public EstudianteEscuela(string matricula, string nombres, string apellidos, int edad, string direccion, string grado,
            string seccion, double promedioSemestral,
            string nombresPadre, string nombresMadre, string cedulaPadre, string cedulaMadre)
        {
            Matricula = matricula;
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            Direccion = direccion;
            Grado = grado;
            Seccion = seccion;
            this.promedioSemestral = promedioSemestral;
            NombresPadre = nombresPadre;
            NombresMadre = nombresMadre;
            CedulaPadre = cedulaPadre;
            CedulaMadre = cedulaMadre;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Matrícula:" + Matricula + "\nNombres:" + Nombres + "\nApellidos:" + Apellidos
                + "\nEdad:" + Edad + "\nDirección:" + Direccion + "\nGrado:" + Grado + "\nSección:" + Seccion
                + "\nPromedio Semestral:" + promedioSemestral + "\nNombres del Padre:" + NombresPadre
                + "\nNombres de la Madre:" + NombresMadre + "\nCédula del Padre:" + CedulaPadre
                + "\nCédula de la Madre:" + CedulaMadre);
            return sb.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
