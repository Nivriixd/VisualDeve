using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualDev
{

    internal class CODE
    {
        static bool p = false, y = false, e = false, i = false, o = false, h = false;
        
        public static void colores(int c)
        {
            switch (c)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Black;
                break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case 7:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case 8:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;

                case 10:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;

                case 11:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;

                case 12:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;

                case 13:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;

                case 14:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;

                case 15:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                case 16:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                case 17:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
            
        }

        public static void logo()
        {
            colores(1);
            Console.Write("");
        }

        public static void menu()
        {
                Console.BackgroundColor = ConsoleColor.White;
                colores(1);
                Console.Clear();
                logo();

                colores(1);
                Console.Write("¡BIEVENIDO! AQUI PODRAS HACER TODO TIPO DE CONVRSIONES." + "\nPara ello deberas elegir una de las opciones que aparecen a Continuacion (Selecciona numero o escribe el nombre de la operacion)");
                colores(8);
                Console.WriteLine("\n " + "\n████████████████████████████████████████████████████████████████████████████████");

                colores(2);
                Console.Write("1◄ ");
                colores(1);
                Console.WriteLine("Conversion de Longitudes");

                colores(2);
                Console.Write("2◄ ");
                colores(1);
                Console.WriteLine("Conversion de Tiempo");

                colores(2);
                Console.Write("3◄ ");
                colores(1);
                Console.WriteLine("Conversion de Velocidades");

                colores(2);
                Console.Write("4◄ ");
                colores(1);
                Console.WriteLine("Conversion de Energia");

                colores(2);
                Console.Write("5◄ ");
                colores(1);
                Console.WriteLine("Conversion de Fuerzas");

                colores(2);
                Console.Write("6◄ ");
                colores(1);
                Console.WriteLine("Salir");

                colores(2);
                Console.Write("7◄ ");
                colores(1);
                Console.WriteLine("Extras");

                colores(1);
                Console.WriteLine("No encuentra la que busca? (responda que no)");
            }

        public static void menuL()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            logo();

            colores(1);
            Console.Write("Ahora elige que tipo deseas! \n(escribe el numero o nombre de la conversion)");

            colores(2);
            Console.Write("\n1◄ ");
            colores(1);
            Console.WriteLine("Milimetros (mm) a Centimetros (cm)");

            colores(2);
            Console.Write("2◄ ");
            colores(1);
            Console.WriteLine("Centimetros (cm) a Metros (m)");

            colores(2);
            Console.Write("3◄ ");
            colores(1);
            Console.WriteLine("Metros (m) a Kilometros (km)\n " + "\n████████████████████████████████████████████████████████████████████████████████");
            
            colores(2);
            Console.Write("\n4◄ ");
            colores(1);
            Console.WriteLine("Pulgadas (in) a Pies (ft)");

            colores(2);
            Console.Write("5◄ ");
            colores(1);
            Console.WriteLine("Pies (ft) a Yardas (yd)");

            colores(2);
            Console.Write("6◄ ");
            colores(1);
            Console.WriteLine("Yardas (yd) a Millas (mi)\n " + "\n████████████████████████████████████████████████████████████████████████████████");

            colores(2);
            Console.Write("\n7◄ ");
            colores(1);
            Console.WriteLine("Pulgadas (in) a Centimetros (cm)");

            colores(2);
            Console.Write("8◄ ");
            colores(1);
            Console.WriteLine("Pies (ft) a Metros (m)");

            colores(2);
            Console.Write("9◄ ");
            colores(1);
            Console.WriteLine("Yardas (yd) a Metros (m)");

            colores(2);
            Console.Write("10◄ ");
            colores(1);
            Console.WriteLine("Millas (mi) a Kilometros (km)");

            colores(2);
            Console.Write("11◄ ");
            colores(1);
            Console.WriteLine("Volver");
        }
        public static void conv1(int m)
        {
            Console.Clear();
            double numeros;
            logo();
            Console.BackgroundColor = ConsoleColor.White;

            switch (m)
            {
                case 1:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de milimetros para convertirlo a centimetros: ");
                    string n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = Math.Round(numeros / 10, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 2:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de centimetros para convertirlo a metros: ");
                    n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = Math.Round(numeros / 100, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 3:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de metros para convertirlo a kilometros: ");
                    n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = Math.Round(numeros / 1000, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 4:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de pulgadas para convertirlo a pies: ");
                    n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = Math.Round(numeros / 12, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 5:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de pies para convertirlo a yardas: ");
                    n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = Math.Round(numeros / 3, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 6:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de yardas para convertirlo a millas: ");
                    n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = Math.Round(numeros / 1760, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 7:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de pulgadas para convertirlo a centimetros: ");
                    n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = Math.Round(numeros * 2.54, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 8:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de pies para convertirlo a metros: ");
                    n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = Math.Round(numeros * 0.3, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 9:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de yardas para convertirlo a metros: ");
                    n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = numeros * 0.9;

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 10:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de millas para convertirlo a kilometros: ");
                    n1 = Console.ReadLine();

                    if (double.TryParse(n1, out numeros))
                    {
                        double result = Math.Round(numeros * 1.6, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numeros + " es: " + result);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;
            }
        }

        public static void menuT()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            logo();

            colores(1);
            Console.Write("Ahora elige que tipo deseas! \n(escribe el numero o nombre de la conversion)");

            colores(2);
            Console.Write("\n1◄ ");
            colores(1);
            Console.WriteLine("Segundos a Minutos");

            colores(2);
            Console.Write("2◄ ");
            colores(1);
            Console.WriteLine("Minutos a Horas");

            colores(2);
            Console.Write("3◄ ");
            colores(1);
            Console.WriteLine("Horas a Dias ");

            colores(2);
            Console.Write("4◄ ");
            colores(1);
            Console.WriteLine("Dias a Semanas");

            colores(2);
            Console.Write("5◄ ");
            colores(1);
            Console.WriteLine("Dias a Meses");

            colores(2);
            Console.Write("6◄ ");
            colores(1);
            Console.WriteLine("Dias a Años");

            colores(2);
            Console.Write("7◄ ");
            colores(1);
            Console.WriteLine("Semanas a Meses");

            colores(2);
            Console.Write("8◄ ");
            colores(1);
            Console.WriteLine("Meses a Años");

            colores(2);
            Console.Write("9◄ ");
            colores(1);
            Console.WriteLine("Volver");
        }
        public static void conv2(int z)
        {
            Console.Clear();
            double numbers;
            logo();
            Console.BackgroundColor = ConsoleColor.White;

            switch (z)
            {
                case 1:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de segundos para convertirlo a minutos: ");
                    string n2 = Console.ReadLine();

                    if (double.TryParse(n2, out numbers))
                    {
                        double resultado = Math.Round(numbers / 60, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numbers + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 2:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de minutos para convertirlo a horas: ");
                    n2 = Console.ReadLine();

                    if (double.TryParse(n2, out numbers))
                    {
                        double resultado = Math.Round(numbers / 60, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numbers + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 3:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de horas para convertirlo a dias: ");
                    n2 = Console.ReadLine();

                    if (double.TryParse(n2, out numbers))
                    {
                        double resultado = Math.Round(numbers / 24, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numbers + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 4:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de dias para convertirlo a semanas: ");
                    n2 = Console.ReadLine();

                    if (double.TryParse(n2, out numbers))
                    {
                        double resultado = Math.Round(numbers / 7, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numbers + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 5:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de dias para convertirlo a meses: ");
                    n2 = Console.ReadLine();

                    if (double.TryParse(n2, out numbers))
                    {
                        double resultado = Math.Round(numbers / 30, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numbers + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 6:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de dias para convertirlo a años: ");
                    n2 = Console.ReadLine();

                    if (double.TryParse(n2, out numbers))
                    {
                        double resultado = Math.Round(numbers / 365, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numbers + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 7:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de semanas para convertirlo a meses: ");
                    n2 = Console.ReadLine();

                    if (double.TryParse(n2, out numbers))
                    {
                        double resultado = Math.Round(numbers / 4.3, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numbers + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 8:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de meses para convertirlo a años: ");
                    n2 = Console.ReadLine();

                    if (double.TryParse(n2, out numbers))
                    {
                        double resultado = Math.Round(numbers / 12, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numbers + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;
            }
        }

        public static void menuV()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            logo();

            colores(1);
            Console.WriteLine("Ahora elige que tipo deseas! \n(escribe el numero o nombre de la conversion)\n");

            colores(2);
            Console.Write("\n1◄ ");
            colores(1);
            Console.WriteLine("Metros por Segundo (m/s) a Kilometros por Hora (km/h)");

            colores(2);
            Console.Write("2◄ ");
            colores(1);
            Console.WriteLine("Pies por Segundo (ft/s) a Millas por Hora (mph)");

            colores(2);
            Console.Write("3◄ ");
            colores(1);
            Console.WriteLine("Metros por Segundo (m/s) a Millas por Hora(mph)");

            colores(2);
            Console.Write("4◄ ");
            colores(1);
            Console.WriteLine("Kilmetros por Hora (km/h) a Millas por Hora (mph)");

            colores(2);
            Console.Write("5◄ ");
            colores(1);
            Console.WriteLine("Pies por Segundo (ft/s) a Metros por Segundo (m/s)");

            colores(2);
            Console.Write("6◄ ");
            colores(1);
            Console.WriteLine("Volver");
        }
        public static void conv3(int a)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            double num;
            logo();

            switch (a)
            {
                case 1:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de metros por segundo para convertirlo a kilometros por hora: ");
                    string n3 = Console.ReadLine();

                    if (double.TryParse(n3, out num))
                    {
                        double resultado = Math.Round(num * 3.6, 2);

                        Console.WriteLine("El resultado tras la conversion de " + num + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 2:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de pies por segundo para convertirlo a millas por hora: ");
                    n3 = Console.ReadLine();

                    if (double.TryParse(n3, out num))
                    {
                        double resultado = Math.Round(num * 0.6, 2);

                        Console.WriteLine("El resultado tras la conversion de " + num + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 3:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de metros por hora para convertirlo a millas por hora: ");
                    n3 = Console.ReadLine();

                    if (double.TryParse(n3, out num))
                    {
                        double resultado = Math.Round(num * 0.000621371, 2);

                        Console.WriteLine("El resultado tras la conversion de " + num + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 4:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de kilometros por hora para convertirlo a millas por hora: ");
                    n3 = Console.ReadLine();

                    if (double.TryParse(n3, out num))
                    {
                        double resultado = Math.Round(num * 0.6, 2);

                        Console.WriteLine("El resultado tras la conversion de " + num + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 5:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de pies por segundo para convertirlo a metros por segundo: ");
                    n3 = Console.ReadLine();

                    if (double.TryParse(n3, out num))
                    {
                        double resultado = Math.Round(num * 0.3, 2);

                        Console.WriteLine("El resultado tras la conversion de " + num + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;
            }
        }

        public static void menuE()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            logo();

            colores(1);
            Console.Write("Ahora elige que tipo deseas! \n(escribe el numero o nombre de la conversion)\n");

            colores(2);
            Console.Write("\n1◄ ");
            colores(1);
            Console.WriteLine("Julios (j) a Kilojulios (kj)");

            colores(2);
            Console.Write("2◄ ");
            colores(1);
            Console.WriteLine("Julios (j) a Calorias (cal)");

            colores(2);
            Console.Write("3◄ ");
            colores(1);
            Console.WriteLine("Julios (j) a Kilocalorias (kcal)");

            colores(2);
            Console.Write("4◄ ");
            colores(1);
            Console.WriteLine("Julio (j) a Watt-hora (wh)");

            colores(2);
            Console.Write("5◄ ");
            colores(1);
            Console.WriteLine("Watt-hora (wh) a Kilowatt-hora (kWh)");

            colores(2);
            Console.Write("6◄ ");
            colores(1);
            Console.WriteLine("Calorias (cal) a Kilojulios (kj)");

            colores(2);
            Console.Write("7◄ ");
            colores(1);
            Console.WriteLine("Kilocalorias (kcal) a Kilojulios (kj)");

            colores(2);
            Console.Write("8◄ ");
            colores(1);
            Console.WriteLine("Kilowatt-hora (kWh) a Megajulios");

            colores(2);
            Console.Write("9◄ ");
            colores(1);
            Console.WriteLine("Volver");
        }
        public static void conv4(int w)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            double numero;
            logo();

            switch (w)
            {
                case 1:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de julios para convertirlo a kilojulios: ");
                    string n4 = Console.ReadLine();

                    if (double.TryParse(n4, out numero))
                    {
                        double resultado = Math.Round(numero / 1000, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numero + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 2:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de julios para convertirlo a calorias: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out numero))
                    {
                        double resultado = Math.Round(numero / 4.1, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numero + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 3:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de julios para convertirlo a kilocalorias: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out numero))
                    {
                        double resultado = Math.Round(numero / 4184, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numero + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 4:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de julios para convertirlo a watt-hora: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out numero))
                    {
                        double resultado = Math.Round(numero / 3600, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numero + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 5:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de watt-hora para convertirlo a kilowatt-hora: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out numero))
                    {
                        double resultado = Math.Round(numero / 1000, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numero + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 6:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de Calorias para convertirlo a kilojulios: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out numero))
                    {
                        double resultado = Math.Round(numero * 0.004184, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numero + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 7:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de Kilocalorias para convertirlo a kilojulios: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out numero))
                    {
                        double resultado = Math.Round(numero * 4.1, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numero + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 8:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de kilowatt-hora para convertirlo a megajulios: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out numero))
                    {
                        double resultado = Math.Round(numero * 3.6, 2);

                        Console.WriteLine("El resultado tras la conversion de " + numero + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;
            }
        }

        public static void menuF()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            logo();

            colores(1);
            Console.Write("Ahora elige que tipo deseas! \n(escribe el numero o nombre de la conversion)\n");

            colores(2);
            Console.Write("\n1◄ ");
            colores(1);
            Console.WriteLine("Newton (N) a Kilonewton (kN)");

            colores(2);
            Console.Write("2◄ ");
            colores(1);
            Console.WriteLine("Newton (N) a Dina (dyn)");

            colores(2);
            Console.Write("3◄ ");
            colores(1);
            Console.WriteLine("Newton (N) a Kilogramo-fuerza (kgf)");

            colores(2);
            Console.Write("4◄ ");
            colores(1);
            Console.WriteLine("Newton (N) a Libra-fuerza (lbf)");

            colores(2);
            Console.Write("5◄ ");
            colores(1);
            Console.WriteLine("Kilogramo-fuerza (kgf) a Libra-fuerza (lbf)");

            colores(2);
            Console.Write("6◄ ");
            colores(1);
            Console.WriteLine("Volver");
        }
        public static void conv5(int r)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            double nume;
            logo();

            switch (r)
            {
                case 1:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de newton para convertirlo a kilonewton: ");
                    string n4 = Console.ReadLine();

                    if (double.TryParse(n4, out nume))
                    {
                        double resultado = Math.Round(nume / 1000, 2);

                        Console.WriteLine("El resultado tras la conversion de " + nume + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 2:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de newton para convertirlo a dina: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out nume))
                    {
                        double resultado = Math.Round(nume * 100000, 2);

                        Console.WriteLine("El resultado tras la conversion de " + nume + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 3:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de newton para convertirlo a kilogramo-fuerza: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out nume))
                    {
                        double resultado = Math.Round(nume / 9.8, 2);

                        Console.WriteLine("El resultado tras la conversion de " + nume + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 4:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de newton para convertirlo a libra-fuerza: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out nume))
                    {
                        double resultado = Math.Round(nume / 4.4, 2);

                        Console.WriteLine("El resultado tras la conversion de " + nume + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;

                case 5:
                    colores(1);
                    Console.WriteLine("Muy buena eleccion!\n" + "\nAhora ingresa el numero de kilogramo-fuerza para convertirlo a libre-fuerza: ");
                    n4 = Console.ReadLine();

                    if (double.TryParse(n4, out nume))
                    {
                        double resultado = Math.Round(nume * 2.2, 2);

                        Console.WriteLine("El resultado tras la conversion de " + nume + " es: " + resultado);
                        Console.Read();
                    }

                    else
                    {
                        colores(14);
                        Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                        Console.Read();
                    }
                    break;
            }
        }
        static void Main()
        {
            p = false;
            string seleccion;
            while (!p)
            {
                p = false;
                menu();
                seleccion = Console.ReadLine();

                if (seleccion.Contains("Longitud", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("la longitud", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("conversion de longitud", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("1", StringComparison.OrdinalIgnoreCase))
                {
                    y = false;
                    while (!y)
                    {
                        menuL();
                        seleccion = Console.ReadLine();

                        if (seleccion.Equals("milimetros a centimetros", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("1", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(1);
                            Console.Read();
                        }

                        else if (seleccion.Equals("centimetros a metros", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("2", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(2);
                        }

                        else if (seleccion.Equals("metros a kilometros", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("3", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(3);
                        }

                        else if (seleccion.Equals("pulgadas a pies", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("4", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(4);
                        }

                        else if (seleccion.Equals("pies a yardas", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("5", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(5);
                        }

                        else if (seleccion.Equals("yardas a millas", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("6", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(6);
                        }

                        else if (seleccion.Equals("pulgadas a centimetros", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("7", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(7);
                        }

                        else if (seleccion.Equals("pies a metros", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("8", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(8);
                        }

                        else if (seleccion.Equals("yardas a metros", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("9", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(9);
                        }

                        else if (seleccion.Equals("millas a kilometros", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("10", StringComparison.OrdinalIgnoreCase))
                        {
                            conv1(10);
                        }

                        else if (seleccion.Contains("volver", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("11", StringComparison.OrdinalIgnoreCase))
                        {
                            y = true;
                        }

                        else
                        {
                            colores(14);
                            Console.WriteLine("Parametros no validos! Coloque bien su eleccion, todo segun la indicacion dada anteriormente");
                            Console.Read();
                        }
                    }
                }

                else if (seleccion.Contains("Tiempo", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("el tiempo", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("conversion de tiempo", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("2", StringComparison.OrdinalIgnoreCase))
                {
                    e = false;
                    while (!e) {
                    menuT();
                    seleccion = Console.ReadLine();

                        if (seleccion.Equals("segundos a minutos", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("1", StringComparison.OrdinalIgnoreCase))
                        {
                            conv2(1);
                        }

                        else if (seleccion.Equals("Minutos a horas", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("2", StringComparison.OrdinalIgnoreCase))
                        {
                            conv2(2);
                        }

                        else if (seleccion.Equals("Horas a dias", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("3", StringComparison.OrdinalIgnoreCase))
                        {
                            conv2(3);
                        }

                        else if (seleccion.Equals("dias a semanas", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("4", StringComparison.OrdinalIgnoreCase))
                        {
                            conv2(4);
                        }

                        else if (seleccion.Equals("dias a meses", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("5", StringComparison.OrdinalIgnoreCase))
                        {
                            conv2(5);
                        }

                        else if (seleccion.Equals("dias a años", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("6", StringComparison.OrdinalIgnoreCase))
                        {
                            conv2(6);
                        }

                        else if (seleccion.Equals("semanas a meses", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("7", StringComparison.OrdinalIgnoreCase))
                        {
                            conv2(7);
                        }

                        else if (seleccion.Equals("meses a años", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("8", StringComparison.OrdinalIgnoreCase))
                        {
                            conv2(8);
                        }

                        else if (seleccion.Contains("volver", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("9", StringComparison.OrdinalIgnoreCase))
                        {
                            e = true;
                        }
                    }
                }

                else if (seleccion.Contains("Velocidad", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("la velocidad", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("conversion de velocidad", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("3", StringComparison.OrdinalIgnoreCase))
                {
                    i = false;
                    while (!i)
                    {
                        menuV();
                        seleccion = Console.ReadLine();

                        if (seleccion.Equals("metros por segundo a kilometros por hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("1", StringComparison.OrdinalIgnoreCase))
                        {
                            conv3(1);
                        }

                        else if (seleccion.Equals("pies por segundo a millas por hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("2", StringComparison.OrdinalIgnoreCase))
                        {
                            conv3(2);
                        }

                        else if (seleccion.Equals("metros por segundo a millas por hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("3", StringComparison.OrdinalIgnoreCase))
                        {
                            conv3(3);
                        }

                        else if (seleccion.Equals("kilometros por hora a millas por hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("4", StringComparison.OrdinalIgnoreCase))
                        {
                            conv3(4);
                        }

                        else if (seleccion.Equals("Pies por segundo a metros por segundo", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("5", StringComparison.OrdinalIgnoreCase))
                        {
                            conv3(5);
                        }

                        else if (seleccion.Contains("Volver", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("6", StringComparison.OrdinalIgnoreCase))
                        {
                            i = true;
                        }
                    }
                }

                else if (seleccion.Contains("Energia", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("energÍa", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("conversion de Energia", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("4", StringComparison.OrdinalIgnoreCase))
                {
                    o = false;
                    while (!o) {
                        menuE();
                        seleccion = Console.ReadLine();

                        if (seleccion.Equals("Julios a Kilojulios", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("1", StringComparison.OrdinalIgnoreCase))
                        {
                            conv4(1);
                        }

                        else if (seleccion.Equals("julios a calorias", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("2", StringComparison.OrdinalIgnoreCase))
                        {
                            conv4(2);
                        }

                        else if (seleccion.Equals("Julios a Kilocalorias", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("3", StringComparison.OrdinalIgnoreCase))
                        {
                            conv4(3);
                        }

                        else if (seleccion.Equals("julios a watt-hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("4", StringComparison.OrdinalIgnoreCase))
                        {
                            conv4(4);
                        }

                        else if (seleccion.Equals("watt-hora a kilowatt-hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("5", StringComparison.OrdinalIgnoreCase))
                        {
                            conv4(5);
                        }

                        else if (seleccion.Equals("calorias a kilojulios", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("6", StringComparison.OrdinalIgnoreCase))
                        {
                            conv4(6);
                        }

                        else if (seleccion.Equals("Kilocalorias a kilojulios", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("7", StringComparison.OrdinalIgnoreCase))
                        {
                            conv4(7);
                        }

                        else if (seleccion.Equals("Kilowatt-hora a megajulios", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("8", StringComparison.OrdinalIgnoreCase))
                        {
                            conv4(8);
                        }

                        else if (seleccion.Contains("volver", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("9", StringComparison.OrdinalIgnoreCase))
                        {
                            o = true;
                        }
                    }
                }

                else if (seleccion.Contains("Fuerza", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("la fuerza", StringComparison.OrdinalIgnoreCase) || seleccion.Contains("conversion de fuerza", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("5", StringComparison.OrdinalIgnoreCase))
                {
                    h = false;
                    while (!h)
                    {
                        menuF();
                        seleccion = Console.ReadLine();

                        if (seleccion.Equals("metros por segundo a kilometros por hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("1", StringComparison.OrdinalIgnoreCase))
                        {
                            conv5(1);
                        }

                        else if (seleccion.Equals("pies por segundo a millas por hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("2", StringComparison.OrdinalIgnoreCase))
                        {
                            conv5(2);
                        }

                        else if (seleccion.Equals("metros por segundo a millas por hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("3", StringComparison.OrdinalIgnoreCase))
                        {
                            conv5(3);
                        }

                        else if (seleccion.Equals("kilometros por hora a millas por hora", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("4", StringComparison.OrdinalIgnoreCase))
                        {
                            conv5(4);
                        }

                        else if (seleccion.Equals("Pies por segundo a metros por segundo", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("5", StringComparison.OrdinalIgnoreCase))
                        {
                            conv5(5);
                        }

                        else if (seleccion.Contains("Volver", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("6", StringComparison.OrdinalIgnoreCase))
                        {
                            h = true;
                        }
                    }
                }

                else if (seleccion.Contains("salir", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("6", StringComparison.OrdinalIgnoreCase))
                {
                    p = true;
                }

                else if (seleccion.Contains("formula", StringComparison.OrdinalIgnoreCase) || seleccion.Equals("no", StringComparison.OrdinalIgnoreCase))
                {

                }
            }
        }
    }
}
