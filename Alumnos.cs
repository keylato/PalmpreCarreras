using System;
using System.Collections.Generic;

namespace Palmore
{
    public class Alumnos 
    {
        public string nombre;

        public string apellido;
        public int matricula;
        

        public string DatosCompletos
        {
            get => this.nombre + " " + apellido + " "+ matricula;
        }

        public Alumnos(string nombre, string apellido, int matricula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.matricula = matricula;    
        }
        
        
        
        
        
       

        

    }
}