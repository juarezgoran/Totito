/*REGLAS DEL JUEGO
* GANA QUIEN TENGA MAS CARTAS QUE EL DEALER
* PIERDE QUIEN SE PASE DE 21
* PIERDE SI TIENE LA MISMA CANTIDAD DE CARTAS QUE EL DEALER
* PIERDE SI TIENE MENOS CARTAS QUE EL DEALER*/


// FUNCIONES 
System.Random aleatoria = new System.Random(); // SINTAXIS NUMEROS RANDOM

//VARIABLES IMPLICITAS
var (op, totalJugador, totalDealer, message, switchControl, controlOtraCarta, num) =
(0, 0, 0, "", "menu", "", 0);

//USO DE CICLOS 
while (op < 2)
{
    switch (switchControl) //USO DE SWITCH CASE
    {
        case "menu":
            Console.WriteLine("B L A C K J A C K");
            Console.WriteLine("B L A C K J A C K");
            Console.WriteLine("WELCOME TO CASINO");
            Console.WriteLine("Escriba '21' para jugar al 21");
            switchControl = Console.ReadLine();
            break; //SIRVE PARA SALTAR A OTRO CASO

        case "21":
            do//USO CICLO DO WHILE
            {
                num = aleatoria.Next(1, 12);
                totalJugador = totalJugador + num;
                Console.WriteLine($"Toma tu Carta Jugador, te salio la carta: {num}");
               
               
                Console.WriteLine("¿Deseas Otra Carta?");
                controlOtraCarta = Console.ReadLine();
            } while (controlOtraCarta == "SI" || controlOtraCarta == "si" ||
           controlOtraCarta == "yes");
            totalDealer = aleatoria.Next(1, 20);//DATOS DEL DEALER
            Console.WriteLine($"El Dealer tiene {totalDealer}! y tu tienes {totalJugador}!");



 //SENTENCIA IF
 if (totalJugador > totalDealer && totalJugador < 22)
            {
                message = "Venciste al Dealer, FELICIDADES.....!!!";
            }
            else if (totalJugador > 21)
            {
                message = "Perdiste, te pasaste de 21";
            }
            else if (totalJugador < totalDealer)
            {
                message = "Perdiste vs el Dealer, LO SIENTO.....!!!!";
            }
            else if (totalJugador == totalDealer)
            {
                message = "Perdiste vs el Dealer, LO SIENTO.....!!!!";
            }
            else
            {
                message = "Condicion no valida";
            }//FIN DEL IF
            Console.WriteLine(message);
            break;
        default:
            Console.WriteLine("ERROR: NUMERO INCORRECTO!!!");
            break;
    }// FIN DEL SWITCH

    op++;
}// FIN DEL CICLO WHILE

