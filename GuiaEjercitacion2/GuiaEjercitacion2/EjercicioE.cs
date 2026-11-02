using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercitacion2
{
    public class EjercicioE
    {
        /*E1. Escenario
        Una app de delivery calcula el costo del envío de forma distinta si va en moto, en bicicleta o en auto. El
        usuario elige el vehículo al confirmar el pedido, y el mes que viene se suma el envío con dron.
        Patrón y por qué: Usaría el patron strategy para que sea facil de escalar, ya que dependiendo del vehiculo, cambia su coste de envío.

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        E2. Escenario
        Cuando un pedido de un restaurante pasa a "listo", tienen que enterarse la pantalla de la cocina, la tablet
        del mozo y la caja. El dueño ya avisó que más adelante quiere sumar un aviso por WhatsApp al cliente.
        Patrón y por qué: Usaria el patron Observer para facilitar los avisos, el pedido sería el objeto central y la pantalla de la cocina, la tablet del mozo, la caja y
        el whatsapp del cliente serían los elementos que reaccionarian al cambio de estado del pedido.

        E3. Escenario
        Todas las pantallas del sistema leen la moneda, el nombre de la sucursal y la carpeta de datos. Hoy cada
        formulario crea su propio objeto de configuración y, si se cambia la sucursal en una pantalla, las otras
        siguen mostrando la anterior.
        Patrón y por qué: Usaría singleton para unificar los formularios y no crear copias de lo mismo.

        E4. Escenario 
        El sistema lee un archivo JSON donde cada pago guardado tiene su medio como texto: "TARJETA",
        "EFECTIVO" o "QR". Al cargar el archivo hay que reconstruir, para cada pago, el objeto que sabe calcular
        su recargo.
        Patrón y por qué: Usaria primero el patron factory para traducir el texto proveniente del JSON, y de alli crear el objeto. Luego usaria el patron strategy para
        el cálculo del recargo.

        E5. Escenario
        En Program.cs se crea un único JsonRepository<Cliente> al iniciar y se le pasa por constructor al
        ClienteController. Nunca cambia durante la ejecución. Un compañero propone agregarle una factory
        "para que quede más profesional".
        Patrón y por qué: Si la instancia es unica y fija, realmente no se necesita aplicar un patron.



















        */
    }
}
