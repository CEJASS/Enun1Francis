using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Estudiante : Persona
{
    public int IdEstudiante { get; set; }

    public Estudiante(string nombre, int idEstudiante) : base(nombre)
    {
        IdEstudiante = idEstudiante;
    }
}