internal class Program
{

    static int[,] tablero; 
    static int puntaje = 0; 

    private static void Main(string[] args)
    {
        //Quiz final
        /*Peso: 100%: Tablero numérico 
Desarrollar un programa en C# que simule un juego de suma y movimiento en un tablero NxN. El 
objetivo del juego es mover el cero "0" a través del tablero para sumar los valores de las casillas y 
acumular puntos, evitando los obstáculos.  
Requisitos del Programa: 
1. Inicialización del Tablero: 
 El tablero es una matriz de NxN. 
 La posición inicial es en [0,0] y debe estar representada por el número cero 0. 
 Las demás posiciones del tablero deben ser llenadas con números aleatorios entre 1 y 9. 
2. Menú de Opciones: 
 Implementar un menú con las siguientes opciones: 
Mover Derecha 
Mover Izquierda 
Mover Arriba 
Mover Abajo 
Esc para Salir del Juego 
3. Movimientos del Jugador: 
 Permitir al jugador mover el "0" en la dirección indicada por el menú usando las teclas de 
dirección o las teclas WASD. 
 Si el usuario mueve el “0” con la tecla Flecha Arriba, se moverá, y si la mueve con W 
también debe moverse sin problema. Recuerden WASD es: Tecla W hacia arriba, tecla A 
hacia la izquierda, tecla S hacia abajo y tecla D hacia la derecha. 
 El jugador no puede moverse fuera de los límites del tablero. 
 Cada vez que el jugador se mueva a una nueva casilla, el valor de la casilla debe sumarse al 
puntaje y la casilla debe ser reemplazada por un 0. 
4. Mostrar el Tablero: 
 Mostrar el tablero actualizado después de cada movimiento, indicando la posición actual del 
jugador. 
 Mostrar el puntaje acumulado del jugador. */


        InicializaTablero(5); // Inicializamos el tablero con tamaño 5x5

        ConsoleKeyInfo tecla;
        do
        {
            MostrarTablero(); 
            Console.WriteLine("Puntaje: " + puntaje); 
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Mover Derecha");
            Console.WriteLine("2. Mover Izquierda");
            Console.WriteLine("3. Mover Arriba");
            Console.WriteLine("4. Mover Abajo");
            Console.WriteLine("Esc para Salir del Juego");


            tecla = Console.ReadKey(true);

            
            switch (tecla.Key)
            {
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    Mover(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    Mover(0, -1);
                    break;
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    Mover(-1, 0);
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    Mover(1, 0);
                    break;
            }
        } while (tecla.Key != ConsoleKey.Escape);
    }

    static void InicializaTablero(int n) //metodo para inicializar el tablero, me genera error la variable tablero
    {
        tablero = new int[n, n]; 

        
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tablero[i, j] = rnd.Next(1, 10);
            }
        }
    }

    static void Mover(int hx, int hy)
    {
        
        int posX = 0, posY = 0;
        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                if (tablero[i, j] == 0)
                {
                    posX = i;
                    posY = j;
                    break;
                }
            }
        }

        
        int nuevaPosX = posX + hx;
        int nuevaPosY = posY + hy;

       
        if (nuevaPosX >= 0 && nuevaPosX < tablero.GetLength(0) &&
            nuevaPosY >= 0 && nuevaPosY < tablero.GetLength(1))
        {
            
            puntaje += tablero[nuevaPosX, nuevaPosY];
            tablero[posX, posY] = tablero[nuevaPosX, nuevaPosY];
            tablero[nuevaPosX, nuevaPosY] = 0;
        }
    }

    static void MostrarTablero()
    {
        // Mostramos el tablero en consola
        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                if (tablero[i, j] == 0)
                {
                    Console.Write("0 ");
                }
                else
                {
                    Console.Write(tablero[i, j] + " ");
                }
            }
            
        }
    }
}

 
