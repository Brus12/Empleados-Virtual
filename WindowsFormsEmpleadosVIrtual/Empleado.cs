using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsEmpleadosVIrtual
{
    public class Empleado
    {
        public double SalarioSemanal;
        public double SueldoXHoras;
        public double Sueldo;
        public double SueldoBase;
        public double VentasBrutas;

        public virtual void CalculaSalario(double SA, double SH, int HT, int a)
        {
            if (a==1)
            {
                // SA = Salario
                // SH = 0
                // HT = 0
                Sueldo = SA;
            }
            if (a==2)
            {
                // SA = 0
                // SH = Sueldo Hora
                // HT = Horas Trabajadas
                if (HT <= 40)
                {
                    Sueldo = SH * HT;
                }
                if (HT > 40)
                {
                    Sueldo = 40 * SH + (HT - 40) * SH * 1.5;
                }
            }
            if (a==3)
            {
                //SA = Tarifas de Comision
                //SH Ventas Brutas
                // HT =0
                Sueldo = SA * SH;
            }
            if (a==4)
            {
                //SA = Tarifas de Comision
                //SH = Salario Base
                //HT = Ventas Brutas
                Sueldo = (SA * HT) + SH;
            }
        }
        
    }
}