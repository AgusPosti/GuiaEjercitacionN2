using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercitacion2
{
    public class EjercicioB
    {
        /*
        // B1. Singleton
         public class Contador
         {
             private static Contador _instancia;
             private int _valor = 0;

             private Contador() { Console.WriteLine("Creando contador"); }

             public static Contador Instancia
             {
                 get
                 {
                     if (_instancia == null)
                     _instancia = new Contador();
                     return _instancia;
                 }
             }
             public int Siguiente()
             {
                 _valor++;
                 return _valor;
             }
         }
     */
        /* Imprime "creando contador" y debajo un contador del 1 al 3. Aparece una sola vez porque está dentro del constructor privado
        y no deja que nadie externo lo vuelva a crear. B)Siguiente() no devuelve 1 porque sigue siendo el mismo objeto y lo que hace es incrementar
        lo que ya habia, no lo reemplaza.
        */

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //B2. Strategy: la cuenta del restaurante

        /*    public interface IPropina
              {
                    string Nombre { get; }
                    decimal Calcular(decimal total);
              }
              public class SinPropina : IPropina
              {
                     public string Nombre => "Sin propina";
                     public decimal Calcular(decimal total) => 0;
              }
              public class Propina10 : IPropina
              {
                     public string Nombre => "10%";
                     public decimal Calcular(decimal total) => total * 0.10m;
              }
              public class PropinaFija : IPropina
              {
                     private readonly decimal _monto;
                     public PropinaFija(decimal monto) => _monto = monto;
                     public string Nombre => "Fija";
                     public decimal Calcular(decimal total) => _monto;
              }
              public class Cuenta
              {
                     private IPropina _propina;
                     public Cuenta(IPropina propina) => _propina = propina;
                     public void CambiarPropina(IPropina propina) => _propina = propina;
                     public void Mostrar(decimal total)
                     {
                         decimal final = total + _propina.Calcular(total);
                         Console.WriteLine($"{_propina.Nombre}: {final:0}");
                     }
              }
     */
        /* Imprime cada una de las cuentas de propinas y las muestra, el primero sin propina, el segundo con +10% y el tercero con un valor fijo que recibe por parámetro.
         El contexto es la clase "Cuenta" y las estrategias son las que heredan de la interfaz IPropina. No hubo que cambiar nada porque esa es una de las ventajas al usar
        strategy, sirve para escalar pero no para modificar.
        */

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //B3. Observer: el canal y sus suscriptores

        /*
        public interface IObservador
        {
            void Actualizar(string video);
        }
        public class Canal
        {
            private readonly List<IObservador> _suscriptores = new List<IObservador>();
            public void Suscribir(IObservador o) => _suscriptores.Add(o);
            public void Desuscribir(IObservador o) => _suscriptores.Remove(o);
            public void Publicar(string video)
            {
                Console.WriteLine($"Nuevo video: {video}");
                foreach (var s in _suscriptores.ToList())
                    s.Actualizar(video);
            }
        }
        public class Fan : IObservador
        {
            private readonly string _nombre;
            public Fan(string nombre) => _nombre = nombre;
            public void Actualizar(string video) => Console.WriteLine($" {_nombre} mira {video}");
        }
        public class Estadisticas : IObservador
        {
            private int _avisos = 0;
            public void Actualizar(string video)
            {
                _avisos++;
                Console.WriteLine($" Avisos registrados: {_avisos}");
            }
        }
        */
        /* Imprime el aviso de los videos publicados con su respectivo titulo, y debajo de ellos las personas que ven el video publicado, con el contador de los avisos registrados.
         Lu no aparece en la segunda publicacion porque se desuscribe del canal antes de la ultima publicacion, por lo que no le llega el aviso.
         Canal no conoce la clase Fan porque en ninguna parte de su código lo nombra.

        */
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------







    }
}
