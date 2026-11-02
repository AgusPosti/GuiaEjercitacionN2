using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercitacion2
{
    public class EjercicioC
    {
        //C1.La alarma que se rompe sola

        /*
        public interface IAlarmaObserver
        {
            void Actualizar(Alarma alarma);
        }
        public class Alarma
        {
            private readonly List<IAlarmaObserver> _observadores = new List<IAlarmaObserver>();
            public void Suscribir(IAlarmaObserver o) => _observadores.Add(o);
            public void Desuscribir(IAlarmaObserver o) => _observadores.Remove(o);
            public void Sonar()
            {
                Console.WriteLine("¡Riiiing!");
                foreach (var o in _observadores.ToList()) // ← se lo soluciona agregando el método ToList()
                    o.Actualizar(this);
            }
        }
        public class AvisoUnico : IAlarmaObserver
        {
            public void Actualizar(Alarma alarma)
            {
                Console.WriteLine("Me avisaron una vez y me doy de baja");
                alarma.Desuscribir(this);
            }
        }
        public class Luz : IAlarmaObserver
        {
            public void Actualizar(Alarma alarma) => Console.WriteLine("Luz encendida");
        }
        */
        // El error es InvalidOperationException y es de ejecución. El error ocurre porque se quiere modificar una lista mientras se recorre con un bucle foreach.
        // Se soluciona creando una copia temporal de la lista antes de recorrerla.

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // C2. Una "Strategy" sospechosa.
        /*
        public interface IEnvioStrategy
        {
            decimal Calcular(decimal pesoKg);
        }

        // Cada estrategia en su propia clase independiente
        public class EnvioMoto : IEnvioStrategy
        {
            public decimal Calcular(decimal pesoKg) => 1500 + pesoKg * 100;
        }

        public class EnvioCamion : IEnvioStrategy
        {
            public decimal Calcular(decimal pesoKg) => 8000 + pesoKg * 40;
        }

        // Cuando llega "Bicicleta", SOLO agregas esto:
        public class EnvioBicicleta : IEnvioStrategy
        {
            public decimal Calcular(decimal pesoKg) => 500 + pesoKg * 20;
        }
        */
        // El error es de diseño, al no estar creado correctamente el patron, ya que cada clase deberia ser independiente. Si se quiere agregar un tipo nuevo se obliga a modificar
        // código existente, en este caso agregar un condicional mas para el tipo bicicleta, lo que lo hace poco escalable.
        // Para corregirlo deberia crear cada tipo de medio de transporte, como una clase independiente que herede de la interfaz IEnvioStrategy.

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // C3. La factory que no compila
        /*
        public interface INotificador
        {
            void Enviar(string destino, string mensaje);
        }
        public class NotificadorMail : INotificador { }
        public class NotificadorSms : INotificador { }
        public static class NotificadorFactory
        {
            public static INotificador Crear(string canal)
            {
                if (canal == "MAIL") return new NotificadorMail();
                if (canal == "SMS") return new NotificadorSms();

                throw new ArgumentException($"El canal de notificación '{canal}' no está soportado.", nameof(canal));// correccion
            } 
        }
           El error es de compilacion, dice que no todas las rutas de acceso de código devuelven un valor.
           Se soluciona lanzando una excepcion porque si el parámetro devolviera null u otro valor que no está en los notificadores, se queda sin instrucciones sobre que retornar
           y tira error.
        */

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------









    }

}
