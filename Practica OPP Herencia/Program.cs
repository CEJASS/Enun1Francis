class Program
{
    static void Main(string[] args)
    {
        
        Clase clase = new Clase("Desarrollo de Software");

        
        Estudiante estudiante1 = new Estudiante("Jasser", 1);
        Estudiante estudiante2 = new Estudiante("Job", 2);
        clase.agregarEstudiante(estudiante1);
        clase.agregarEstudiante(estudiante2);

        
        Profesor profesor = new Profesor("Francis Ramirez");
        clase.agregarProfesor(profesor);


        Curso curso = new Curso("Programacion 2", 20, 10);
        profesor.agregarCurso(curso);

      
        Console.WriteLine($"Clase: {clase.ID}");
        Console.WriteLine("Estudiantes:");
        foreach (var est in clase.Estudiantes)
        {
            Console.WriteLine($"- {est.Nombre} (ID: {est.IdEstudiante})");
        }

        Console.WriteLine("Profesores:");
        foreach (var prof in clase.Profesores)
        {
            Console.WriteLine($"- {prof.Nombre}");
            Console.WriteLine("  Cursos:");
            foreach (var cur in prof.Cursos)
            {
                Console.WriteLine($"    - {cur.Nombre} (Clases: {cur.recuentoClases}, Ejercicios: {cur.recuentoEjercicios})");
            }
        }
    }
}
