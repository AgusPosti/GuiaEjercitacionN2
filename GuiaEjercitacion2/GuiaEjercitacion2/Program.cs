using static GuiaEjercitacion2.EjercicioB;
using static GuiaEjercitacion2.EjercicioC;
using static GuiaEjercitacion2.EjercicioD;
using static GuiaEjercitacion2.EjercicioF;

public class Program
{
    private static void Main(string[] args)
    {
        /* B1
        var a = Contador.Instancia;
        var b = Contador.Instancia;
        Console.WriteLine(a.Siguiente());
        Console.WriteLine(b.Siguiente());
        Console.WriteLine(Contador.Instancia.Siguiente());
        Console.WriteLine(ReferenceEquals(a, b));
        */
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /* B2
        var cuenta = new Cuenta(new SinPropina());
        cuenta.Mostrar(20000);
        cuenta.CambiarPropina(new Propina10());
        cuenta.Mostrar(20000);
        cuenta.CambiarPropina(new PropinaFija(1500));
        cuenta.Mostrar(20000);
        */
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /* B3
        var canal = new Canal();
        var lu = new Fan("Lu");
        canal.Suscribir(lu);
        canal.Suscribir(new Fan("Tomi"));
        canal.Suscribir(new Estadisticas());
        canal.Publicar("Patrones en C#");
        canal.Desuscribir(lu);
        canal.Publicar("Observer en WinForms");
        */
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /* C1
        var alarma = new Alarma();
        alarma.Suscribir(new AvisoUnico());
        alarma.Suscribir(new Luz());
        alarma.Sonar();
        */
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /* D1
        var termo = new Termometro();
        termo.Suscribir(new PantallaCocina());
        termo.Suscribir(new AlarmaCalor());
        termo.Medir(25);
        termo.Medir(34);
        */
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /* D2
        string tipoElegido = "JUBILADO";
        IDescuento descuento = DescuentoFactory.Crear(tipoElegido);
        Console.WriteLine(descuento.Aplicar(10000m).ToString("0"));
        */

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /* F
        var playa = new Playa(10);
        var pantalla = new PantallaLugares();
        playa.Suscribir(pantalla);
        playa.Suscribir(new CajaObserver());
        playa.Suscribir(new AlertaOcupacionObserver());
        playa.Suscribir(new BitacoraObserver());
        // ... ingresan 8 vehículos con distintos códigos de tarifa ...
        Console.WriteLine("------------------------------------------------------");
        playa.Ingresar("AB123CD", "HORA");
        playa.Ingresar("AC456EF", "ESTADIA");
        playa.Ingresar("AD789GH", "NOCHE");
        // ...
        Console.WriteLine("------------------------------------------------------");
        playa.Egresar("AB123CD", 150); // HORA, 2 h 30 min -> $ 3.600
        playa.Egresar("AC456EF", 900); // ESTADIA, 15 h -> $ 9.600
        playa.Desuscribir(pantalla); // la pantalla deja de mostrar
        playa.Egresar("AD789GH", 600); // NOCHE -> $ 4.500
        Console.WriteLine("------------------------------------------------------");
        try { playa.Ingresar("AZ999ZZ", "SEMANAL"); }
        catch (ArgumentException ex) { Console.WriteLine("Error: " + ex.Message); }
        Console.WriteLine("--Bitácora--");
        Bitacora.Instancia.MostrarTodo();
         */
    }
}