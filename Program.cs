internal class Program
{
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


        InicializarTablero(5); // Inicializamos el tablero con tamaño 5x5

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

        }
}