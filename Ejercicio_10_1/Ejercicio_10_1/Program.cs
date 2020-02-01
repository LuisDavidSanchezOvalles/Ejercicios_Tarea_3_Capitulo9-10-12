using System;
using System.Text;

namespace Ejercicio_10_1
{
    class Program
    {
        public class DiseñoDeClaseInventario
        {
            public class InventarioTienda
            {
                private int ID;
                private string nombreProducto;
                private string DepartamentoProducto;
                private double CostoProducto;
                private double PrecioVentaProducto;
                private int CantidadProducto;
                private string DescripcionProducto;
                private double ItbisProducto;

                public InventarioTienda()
                {
                }

                public InventarioTienda(int iD, string nombreProducto, string departamentoProducto,
                    double costoProducto, double precioVentaProducto, int cantidadProducto,
                    string descripcionProducto, double itbisProducto)
                {
                    ID = iD;
                    this.nombreProducto = nombreProducto;
                    DepartamentoProducto = departamentoProducto;
                    CostoProducto = costoProducto;
                    PrecioVentaProducto = precioVentaProducto;
                    CantidadProducto = cantidadProducto;
                    DescripcionProducto = descripcionProducto;
                    ItbisProducto = itbisProducto;
                }

                public int ID1 { get => ID; set => ID = value; }
                public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
                public string DepartamentoProducto1 { get => DepartamentoProducto; set => DepartamentoProducto = value; }
                public double CostoProducto1 { get => CostoProducto; set => CostoProducto = value; }
                public double PrecioVentaProducto1 { get => PrecioVentaProducto; set => PrecioVentaProducto = value; }
                public int CantidadProducto1 { get => CantidadProducto; set => CantidadProducto = value; }
                public string DescripcionProducto1 { get => DescripcionProducto; set => DescripcionProducto = value; }
                public double ItbisProducto1 { get => ItbisProducto; set => ItbisProducto = value; }

                public override string ToString()
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("ID:" + ID + "\nNombre Producto:" + nombreProducto + "\nDepartamento Producto:" +
                        DepartamentoProducto + "\nCosto producto:" + CostoProducto + "\nPrecio Producto:" + PrecioVentaProducto +
                        "\nCantidad Producto:" + CantidadProducto + "\nDescripción Producto:" + DescripcionProducto + "\nITBIS:" +
                        ItbisProducto);
                    return sb.ToString();
                }
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
