using System;
using System.Collections.Generic;

namespace Palmore
{
    public class Carreras
    {
       
        public string semestre;
        public string grupo;
        public Carreras (string semestre,string grupo)
        {
           
        this.semestre = semestre;
        this.grupo = grupo; 
       }
        public string DatosCarrera
        {
            get => this.semestre+ " "+grupo;
        }
        
        public List<Alumnos> alumnos;

        public Carreras()
        {
            alumnos = new List<Alumnos>();
        }

        public Alumnos ConsultarPorMatricula (int matricula)
        {
            for (int i =0; i < alumnos.Count; i++)
            {
                if (alumnos[i].matricula == matricula)
                {
                    return alumnos[i];
                }
            }
            return null;
            
        }
        public List<Alumnos> ConsultarTodos()
        {
            return this.alumnos;
        }
        public void ConsultarYMostrarTodos()
        {
            Console.WriteLine(alumnos);
        }

        //public Carreras ConsultarTodos (int grupo)
       /// {
          //  for (int i =0; i < grupo.Count; i++)
          //  {
            //    if (Carreras[i].grupo == grupo)
            //    {
             //       return Carreras[i];
             //   }
           // }
          //  return null;

        //public List<Carreras> ConsultarTodos()
       // {
           // return this.grupo;
        //}
       // public void ConsultarYMostrarTodas()
        //{
           // Console.WriteLine(DatosCarrera);
        //}
           
            
        
        

      

    
    
            
        

        
        


    }
}