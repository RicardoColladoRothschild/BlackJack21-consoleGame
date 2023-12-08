
int cartasJugador = 0;
int cartasDealer = 0;
int card_number = 0;
int coins = 0;
int option = 0;
string? nombre = "";
string? controlOtherCard = "";
Random randomly = new Random();


Console.WriteLine("¿Cual es su nombre?");
nombre = Console.ReadLine();

while (true)
{

    Console.WriteLine($"********* Bienvenido al Super Casino, {nombre} ************\n");
    Console.WriteLine("¿Cuantas fichas desea obtener?");
    coins = int.Parse(Console.ReadLine());
    Console.WriteLine("**************************************************************");
    for (int i = 0; i <= coins; i++)
    {

        cartasDealer = 0;
        cartasJugador = 0;

        switch (option)
        {
            //menu
            case 0:

                Console.WriteLine("¿Cual juego deseas jugar? (Seleccione un numero)");
                Console.WriteLine("1) BlackJack 21");
                option = Convert.ToInt32(Console.ReadLine());
                i += 1;
                break;
            case 1:
                Console.WriteLine($"Bienvenido/a {nombre}, ¿deseas tomar una carta?");
                do
                {
                    card_number = randomly.Next(1, 12);
                    Console.WriteLine($"Su nueva carta es: {card_number}");
                    cartasJugador += card_number;
                    Console.WriteLine("¿Deseas Tomar otra carta?");
                    controlOtherCard = Console.ReadLine();

                } while (controlOtherCard == "yes" ||
                        controlOtherCard == "Yes" ||
                        controlOtherCard == "si" ||
                        controlOtherCard == "Si");

                //getting dealer cards:
                cartasDealer = randomly.Next(15, 21);

                if ((cartasJugador > cartasDealer) && cartasJugador <= 21)
                {
                    Console.WriteLine("Felicitaciones le has ganado a la casa");
                    Console.WriteLine($"{nombre}, tus cartas suman: ${cartasJugador}");
                    Console.WriteLine($"Las cartas del dealer suman: ${cartasDealer}");
                }
                else if (cartasJugador > 21)
                {
                    Console.WriteLine($"Te has pasado con:{cartasJugador}, el juego es 21. ");
                }
                else if (cartasDealer > cartasJugador)
                {
                    Console.WriteLine($"Me temo que has perdido, el dealer gana por mas cartas:{cartasDealer}");
                    Console.WriteLine($"Sus cartas jugadas suman: {cartasJugador}");
                }
                option = 0;
                break;

            default:
                Console.WriteLine("YOU DID NOT SELECT A GOOD CHOICE");
                option = 0;
                break;

        }

    }

}
