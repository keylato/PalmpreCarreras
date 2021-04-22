using System;
using System.Collections.Generic;

namespace Palmore
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DecirBienvenida();
            }
        string ObtenerMostrarTexto()
        {
            return "Bienvenidos a Universidad Palmore";
        }
        void DecirBienvenida()
        {
            string MostrarTexto = ObtenerMostrarTexto();
            Console.WriteLine(MostrarTexto); 
        }

       
        Carreras alumnosMultimediaSegundo = new Carreras();
        alumnosMultimediaSegundo.alumnos.Add(new Alumnos("Plankton", "Unojo", 6411));
        alumnosMultimediaSegundo.alumnos.Add(new Alumnos ("Señora", "Puff", 6412));
        alumnosMultimediaSegundo.alumnos.Add(new Alumnos("Rey", "Neptuno", 6413));
        alumnosMultimediaSegundo.alumnos.Add(new Alumnos("Holandes", "Volador", 6414));
        alumnosMultimediaSegundo.alumnos.Add(new Alumnos("Gary", "Vuelveacasa", 6415));

        Carreras alumnosArtesTercero = new Carreras();
        alumnosArtesTercero.alumnos.Add(new Alumnos("Mickey", "Mouse", 6421));
        alumnosArtesTercero.alumnos.Add(new Alumnos("Minnie", "Mouse", 6422));
        alumnosArtesTercero.alumnos.Add(new Alumnos("Pato", "Donald", 6423));
        alumnosArtesTercero.alumnos.Add(new Alumnos("Winnie", "Pooh", 6424));
        alumnosArtesTercero.alumnos.Add(new Alumnos("Rayo", "McQueen", 6425));

        Carreras alumnosMultimediaCuarto = new Carreras();
        alumnosMultimediaCuarto.alumnos.Add(new Alumnos("Patricio", "Estrella", 6416));
        alumnosMultimediaCuarto.alumnos.Add(new Alumnos("BobEsponja", "PantalonesCuadrados", 6417));
        alumnosMultimediaCuarto.alumnos.Add(new Alumnos("Calamardo", "Tentaculos", 6418));
        alumnosMultimediaCuarto.alumnos.Add(new Alumnos("Arenita", "Mejillas", 6419));
        alumnosMultimediaCuarto.alumnos.Add(new Alumnos("Don", "Cangrejo", 6420));

        Carreras alumnosArtesQuinto = new Carreras();
        alumnosArtesQuinto.alumnos.Add(new Alumnos("Sheriff", "Woody", 6426));
        alumnosArtesQuinto.alumnos.Add(new Alumnos("Buzz", "Lightyear", 6427));
        alumnosArtesQuinto.alumnos.Add(new Alumnos("Princesa", "Merida", 6428));
        alumnosArtesQuinto.alumnos.Add(new Alumnos("Blanca", "Nieves", 6429));
        alumnosArtesQuinto.alumnos.Add(new Alumnos("Princesa", "Aurora", 6430));
        
        Carreras Grupo1 = new Carreras("Segundo", "Multimedia");
        Carreras Grupo2 = new Carreras("tercero", "ArtesVisuales");
        Carreras Grupo3 = new Carreras("Cuarto", "Multimedia");
        Carreras Grupo4 = new Carreras("Quinto", "ArtesVisuales");
        Carreras Grupo5 = new Carreras("Sexto", "Multimedia");
        Carreras Grupo6 = new Carreras("Septimo", "ArtesVisuales");
        Carreras Grupo7 = new Carreras("Octavo", "Multimedia");

        Alumnos ResultadoBusquedaMatricula = alumnosArtesTercero.ConsultarPorMatricula(6421); 
        Console.WriteLine(".........");
        Console.WriteLine("Resultado de la busqueda"+ " "+ResultadoBusquedaMatricula.DatosCompletos);

     //Carreras ResultadoTodos = Carreras.ConsultarTodos(Grupo1);
       // Console.WriteLine ("Resultado de la busqueda"+ " "+ ResultadoTodos.DatosCarrera);
        
        

        

                   
            }
        }
        

        
        

       
        

        



        


      
        

   






        }
        
            

                     

    

