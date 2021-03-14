using System;

namespace Posicion_Pantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 5); Console.WriteLine("═");
                Console.SetCursorPosition(i, 21); Console.WriteLine("═");
            }


            for (int i = 6; i <= 20; i++)
            {
                Console.SetCursorPosition(20, i); Console.WriteLine("║");
                Console.SetCursorPosition(80, i); Console.WriteLine("║");
            }

            Console.Clear();

            int pcs;

            Console.Clear();

            do
                
            {
                

                Console.Clear();

                Console.SetCursorPosition(38, 9); Console.WriteLine("   1.   QUIENES SOMOS   ");
                Console.SetCursorPosition(38, 13); Console.WriteLine("   2.   MENU APLICACION  ");
                Console.SetCursorPosition(38, 18); Console.WriteLine("   3.   SALIR   ");

                for (int i = 20; i <= 80; i++)
                {
                    Console.SetCursorPosition(i, 5); Console.WriteLine("═");
                    Console.SetCursorPosition(i, 21); Console.WriteLine("═");
                }


                for (int i = 6; i <= 20; i++)
                {
                    Console.SetCursorPosition(20, i); Console.WriteLine("║");
                    Console.SetCursorPosition(80, i); Console.WriteLine("║");
                }


                pcs = int.Parse(Console.ReadLine());


                Console.Clear();

                switch (pcs)
                    
                {
                    
     
                    case 1:

                        Console.Clear();

                        for (int i = 20; i <= 80; i++)
                        {
                            Console.SetCursorPosition(i, 5); Console.WriteLine("═");
                            Console.SetCursorPosition(i, 21); Console.WriteLine("═");
                        }


                        for (int i = 6; i <= 20; i++)
                        {
                            Console.SetCursorPosition(20, i); Console.WriteLine("║");
                            Console.SetCursorPosition(80, i); Console.WriteLine("║");
                        }

                        Console.SetCursorPosition(31, 9); Console.WriteLine(" 1.1   COMO SE LLAMA:?   ");
                        Console.SetCursorPosition(31, 14); ; Console.WriteLine("  Diego Alonso");


                        Console.SetCursorPosition(29, 20); ; Console.WriteLine(" PRESIONE ENTER PARA REGRESAR ");

                        Console.ReadKey();
                        break;



                        

                    case 2:

                        Console.Clear();

                        for (int i = 20; i <= 80; i++)
                        {
                            Console.SetCursorPosition(i, 5); Console.WriteLine("═");
                            Console.SetCursorPosition(i, 21); Console.WriteLine("═");
                        }


                        for (int i = 6; i <= 20; i++)
                        {
                            Console.SetCursorPosition(20, i); Console.WriteLine("║");
                            Console.SetCursorPosition(80, i); Console.WriteLine("║");
                        }

                        Console.SetCursorPosition(30, 7); Console.WriteLine("   2.1   MENU APLICACION  ");
                        Console.SetCursorPosition(32, 11); ; Console.WriteLine(" 1.  Agregar Personaje");
                        Console.SetCursorPosition(32, 13); ; Console.WriteLine(" 2.  Listar Personajes");
                        Console.SetCursorPosition(32, 15); ; Console.WriteLine(" 3.  Buscar Personaje ");
                        Console.SetCursorPosition(32, 20); ; Console.WriteLine(" PRESIONE ENTER PARA DEVOLVERSE ");
                        


                        

                        Console.ReadKey();

                        break;

                        

                        Console.Clear();

                    case 3:

                       

                        Console.SetCursorPosition(40, 13); Console.WriteLine("   0.   SALIR   ");

                        for (int i = 20; i <= 80; i++)
                        {
                            Console.SetCursorPosition(i, 5); Console.WriteLine("═");
                            Console.SetCursorPosition(i, 21); Console.WriteLine("═");
                        }


                        for (int i = 6; i <= 20; i++)
                        {
                            Console.SetCursorPosition(20, i); Console.WriteLine("║");
                            Console.SetCursorPosition(80, i); Console.WriteLine("║");
                        }


                        Console.ReadKey();
                        break;


                    default:
                        
                        break;

                }


            } while (pcs!=3);

            

            
            


            Console.ReadKey();
        }
    }
}
