
int cartasJugador = 0;
int cartasDealer = 0;
int coins = 0;
int option = 1;
string? nombre = "";

Random randomly = new Random();
    
    
Console.WriteLine("¿Cual es su nombre?");
nombre = Console.ReadLine();

while (true) {

    Console.WriteLine($"********* Bienvenido al Super Casino, {nombre} ************\n");
    Console.WriteLine("¿Cuantas fichas desea obtener?");
    coins = int.Parse(Console.ReadLine());
    Console.WriteLine("**************************************************************");
    for (int i = 0; i <= coins; i ++) {

        cartasDealer = 0;
        cartasJugador = 0;
        
        option = Convert.ToInt32(Console.ReadLine());

        switch (option) 
        {
            //menu
            case 0:

                Console.WriteLine("¿Cual juego deseas jugar? (Seleccione un numero)");
                Console.WriteLine("1) BlackJack 21");
                option = Convert.ToInt32(Console.ReadLine());
                i += 1;
                break;
            case 2:
                Console.WriteLine($"Bienvenido/a {nombre}, ¿deseas tomar una carta?");
                do 
                { 
                        
                } while ();
                break;

        }
        
    }

}
