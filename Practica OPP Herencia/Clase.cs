using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Clase
{
    public string ID { get; set; }
    public List<Estudiante> Estudiantes { get; private set; }
    public List<Profesor> Profesores { get; private set; }

    public Clase(string ID)
    {
        ID = ID;
        Estudiantes = new List<Estudiante>();
        Profesores = new List<Profesor>();
    }

    public void agregarEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
    }

    public void agregarProfesor(Profesor profesor)
    {
        Profesores.Add(profesor);
    }
}
