using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercitacion2
{
    public class EjercicioF
    {
        /*
        //interface de la cual heredan las tarifas con strategy para que cada cálculo funcione por separado
        public interface ITarifa
        {
            string Nombre { get; }
            decimal Calcular(int minutos);
        }

      

        public class TarifaHora : ITarifa
        {
            public string Nombre => "Tarifa por hora";
            public decimal Calcular(int minutos)
            {
                int horas = (int)Math.Ceiling(minutos / 60.0);
                return horas * 1200m;
            }
        }

        public class TarifaEstadia : ITarifa
        {
            public string Nombre => "Tarifa por estadía";
            public decimal Calcular(int minutos)
            {
                if (minutos <= 720) 
                {
                    return 6000m;
                }

                int minutosExtra = minutos - 720;
                int horasExtra = (int)Math.Ceiling(minutosExtra / 60.0);

                return 6000m + (horasExtra * 1200m);
            }
        }

        public class TarifaNocturna : ITarifa
        {
            public string Nombre => "Tarifa nocturna";
            public decimal Calcular(int minutos)
            {
                return 4500m; 
            }
        }

        //aplicando factory para centralizar la creacion de las tarifas
        public static class TarifaFactory
        {
            public static ITarifa Crear(string codigo)
            {
                switch (codigo.ToUpper())
                {
                    case "HORA": return new TarifaHora();
                    case "ESTADIA": return new TarifaEstadia();
                    case "NOCHE": return new TarifaNocturna();
                    default: throw new ArgumentException($"Codigo de tarifa inválido {codigo.ToString()}");
                }
            }

            public static List<string> CodigosDisponibles()
            {
                return new List<string> { "HORA", "ESTADIA", "NOCHE" };
            }
        }

        public class EventoPlaya()
        {
            public string Tipo { get; set; }
            public string Patente {get; set;}
            public decimal Importe { get; set; }
            public int LugaresLibres { get; set; }
        }

        //aplico observer para que diferentes componentes del estacionamiento reaccionen cuando ingresa o egresa un vehiculo
        public interface IPlayaObserver
        {
            void Actualizar(EventoPlaya evento);
        }

        public class PantallaLugares : IPlayaObserver
        {
            public void Actualizar(EventoPlaya evento)
            {
                Console.WriteLine($"[Pantalla] Lugares disponibles: {evento.LugaresLibres}");
            }
        }

        public class CajaObserver : IPlayaObserver
        {
            private decimal TotalRecaudado = 0;
            public void Actualizar(EventoPlaya evento)
            {
                if (evento.Tipo == "Egreso")
                {
                    TotalRecaudado += evento.Importe;

                    Console.WriteLine($"[Caja] Cobrado $ {evento.Importe} a {evento.Patente}. Recaudado: $ {TotalRecaudado}");
                }
            }
        }

        public class AlertaOcupacionObserver : IPlayaObserver
        {
            public void Actualizar(EventoPlaya evento)
            {
                if (evento.LugaresLibres <= 2)
                {
                    Console.WriteLine($"[Alerta] Quedan {evento.LugaresLibres} lugares!");
                }
            }
        }

        // se usa singleton para garantizar que exista una unica instancia de la clase bitacora para registrar todos los movimientos de los vehiculos
        public sealed class Bitacora
        {
            private static readonly Bitacora instancia = new Bitacora();
            private List<string> registros = new List<string>();
            private Bitacora()
            {

            }

            public static Bitacora Instancia
            {
                get { return instancia; }
            }

            public void Registrar(string texto)
            {
                registros.Add(texto);
            }

            public void MostrarTodo()
            {
                foreach (string registro in registros)
                {
                    Console.WriteLine(registro);
                }
            }
        }

        public class BitacoraObserver : IPlayaObserver
        {
            public void Actualizar(EventoPlaya evento)
            {
                string registro = $"{evento.Tipo} - Patente: {evento.Patente} - " +
                                  $"Importe: {evento.Importe} - " +
                                  $"Lugares libres: {evento.LugaresLibres}";

                Bitacora.Instancia.Registrar(registro);
            }
        }


        public class Playa
        {
            private int capacidad;
            private Dictionary<string, (DateTime ingreso, ITarifa tarifa)> vehiculos;

            private List<IPlayaObserver> observadores;

            public Playa(int capacidad)
            {
                if (capacidad <= 0)
                {
                    throw new ArgumentException("La capacidad debe ser mayor a cero.");
                }

                this.capacidad = capacidad;
                vehiculos = new Dictionary<string, (DateTime, ITarifa)>();
                observadores = new List<IPlayaObserver>();
            }
            public int LugaresLibres
            {
                get { return capacidad - vehiculos.Count; }
            }

            public void Suscribir(IPlayaObserver observer)
            {
                observadores.Add(observer);
            }

            public void Desuscribir(IPlayaObserver observer)
            {
                observadores.Remove(observer);
            }

            private void Notificar(EventoPlaya evento)
            {
                foreach (IPlayaObserver observer in observadores)
                {
                    observer.Actualizar(evento);
                }
            }


            public void Ingresar(string patente, string codigoTarifa)
            {
                patente = patente.Trim().ToUpper();

                if (LugaresLibres <= 0)
                {
                    Console.WriteLine("No hay lugares disponibles.");
                    return;
                }

                if (vehiculos.ContainsKey(patente))
                {
                    Console.WriteLine("El vehiculo ya está registrado.");
                    return;
                }

                ITarifa tarifa = TarifaFactory.Crear(codigoTarifa);

                vehiculos.Add(patente, (DateTime.Now, tarifa));

                Console.WriteLine($"Ingresó el vehículo {patente}");
                Console.WriteLine($"Tarifa seleccionada: {tarifa.Nombre}");

                EventoPlaya evento = new EventoPlaya
                {
                    Tipo = "Ingreso",
                    Patente = patente,
                    Importe = 0,
                    LugaresLibres = LugaresLibres
                };
                
                Notificar(evento);
            }

            public void Egresar(string patente, int minutos)
            {
                patente = patente.Trim().ToUpper();

                if (!vehiculos.ContainsKey(patente))
                {
                    Console.WriteLine("Error: El vehículo no está registrado.");
                    return;
                }

                if (minutos < 0)
                {
                    Console.WriteLine("Error: Los minutos no pueden ser negativos.");
                    return;
                }

                var datos = vehiculos[patente];

                decimal importe = datos.tarifa.Calcular(minutos);

                vehiculos.Remove(patente);

                EventoPlaya evento = new EventoPlaya
                {
                    Tipo = "Egreso",
                    Patente = patente,
                    Importe = importe,
                    LugaresLibres = LugaresLibres
                };

                Notificar(evento);
            }
        }
*/
    }
}
