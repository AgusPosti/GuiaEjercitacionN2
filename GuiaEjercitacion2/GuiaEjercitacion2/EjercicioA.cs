using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercitacion2
{
    internal class EjercicioA
    {
        /* 
          A1. Las tres reglas del Singleton 
          -¿Cuál de las tres reglas es la que impide que otra clase escriba new AppLogger()?
                C) El constructor privado es el que lo impide, porque no deja que nadie externo a la clase pueda instanciarla.
          
          ------------------------------------------------------------------------------------------------------------------------------------------------------------------------


          A2. Lazy initialization      
          -En la propiedad Instancia del Singleton, ¿qué significa que la inicialización sea "lazy" (perezosa)?
                A) Se llama lazy porque la instancia se crea una vez que se pide por primera vez y no antes, para optimizar recursos.

        ------------------------------------------------------------------------------------------------------------------------------------------------------------------------

          A3. Qué resuelve Strategy
          - ¿Cuál es el problema principal que resuelve el patrón Strategy?
                D) Reemplazar un condicional que elige entre variantes de un algoritmo por clases intercambiables detrás de una interfaz.
        
        ------------------------------------------------------------------------------------------------------------------------------------------------------------------------

          A4. El contexto en Strategy
          - En Strategy, ¿qué hace el "contexto" (por ejemplo, Cuenta o CalculadoraPrecio)?
                B) Usa una estrategia a traves de la interfaz y le delega el cálculo, sin saber cual es. Si en un futuro se quiere agregar otro descuento,
            solo tiene que llamar a la misma interfaz.

        ------------------------------------------------------------------------------------------------------------------------------------------------------------------------

          A5. Cuándo se justifica una factory
          - ¿En cuál de estos casos SÍ se justifica una factory?
                C) El medio de pago llega como texto ("QR", "EFECTIVO") dessde un ComboBox y desde un JSON, y hay que crear un objeto correcto en varios lugares.

        ------------------------------------------------------------------------------------------------------------------------------------------------------------------------

          A6. Simple Factory vs Factory Method
          - ¿Qué distingue al Factory Method del GoF de una Simple Factory?
                A) En factory Method, una superclase con lógica de negocio declara el método de creación y cada subclase decide qué producto concreto crear. El
            simple factory es mucho mas simple, funciona con if y switch pero si quieres hacer un cambio a futuro, hay que tocar código en varios lugares.

        ------------------------------------------------------------------------------------------------------------------------------------------------------------------------

          A7. Qué guarda el notificador
          - En Observer, ¿qué guarda el notificador?
                B) Una lista de referencias a objetos que implementan la interfaz suscriptora.

        ------------------------------------------------------------------------------------------------------------------------------------------------------------------------

          A8. El suscriptor olvidado
          - Un FormTablero se suscribe al controller al abrirse, pero NO se desuscribe al cerrarse. ¿Qué pasa en la siguiente notificación?
                D) El controller le sigue avisando a un formulario destruido: puede saltar una excepción y el objeto nunca se libera de memoria.
            
        ------------------------------------------------------------------------------------------------------------------------------------------------------------------------

          A9. Observer en WinForms
          - En la línea btnGuardar.Click += btnGuardar_Click; ¿qué rol del patrón Observer cumple btnGuardar_Click?
                B) Suscriptor. Es quien espera hasta que se efectua el click y reacciona ejecutando la logica que contiene.

        ------------------------------------------------------------------------------------------------------------------------------------------------------------------------

          A10. Open/Closed en la práctica
          - Con Observer bien aplicado, gerencia pide un aviso nuevo cada vez que se cancela un envío. ¿Qué hacés?
                C) Creás una clase que implementa la interfaz suscriptora y la suscribís en Program.cs.



         */
    }
}
