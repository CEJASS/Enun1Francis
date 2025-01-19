using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Curso
{
    public string Nombre { get; set; }
    public int recuentoClases { get; set; }
    public int recuentoEjercicios { get; set; }

    public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
    {
        Nombre = nombre;
        recuentoClases = recuentoClases;
        recuentoEjercicios = recuentoEjercicios;
    }
}