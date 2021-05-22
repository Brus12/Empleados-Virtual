using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsEmpleadosVIrtual
{
    public class EmpleadoPorComision : Empleado
    {
        public override void CalculaSalario(double SA, double SH, int HT, int a)
        {
            base.CalculaSalario(SA, SH, HT, a);
        }
    }
}