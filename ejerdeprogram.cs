﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_de_1_al_54
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, sum = 0, cant = 0, suma = 0, numero = 0, cantid = 0, su = 0, ejer11 = 0, ejer = 0, suma12 = 0, res12 = 0,
                cantidad13 = 0, suma13 = 0, suma14 = 0, suma15 = 0, cantidad18 = 0, canpar = 0, canim = 0, cant20 = 0, cant21 = 0, mayor = 0, menor = 0, num22 = 0,
                nume22 = 0, nume23 = 0, cana = 0, canpa = 0, sumin = 0, num24 = 0, num25 = 0, num26=0, sumul = 0, sunume =0, num27 =0, cant27 =0,
                sumu28=0, num28=0, sumaim28=0, mayor28=0,num29=0, nume29=0, cap29=0, sumim29=05, cant30=0,n1=0, n2=0, c32=0, cop32=0, sop32=0, fito=0, num33,
                n34=0, nu34=0, mul34=0, c34=0, nu35=0, n35=0, ca35=0, i35=0, num37=0, cant37=0, I=0, num39=30,num40=0, cout=0, auxi=0, cin=0,
                num41=0, xoxo=0,conteo=0, vector=0;
            string mares, meres;

            /*for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("los numeros del 0 al 100  son " + i);
            }
            Console.ReadKey();

            // ejerccicio No. 2 ///////
            for (int i = 100; i > -1; i--)
            {
                Console.WriteLine("los numeros en orden decreciente del 0 al 100 son " + i);

            }
            Console.ReadKey();

            // ejercicio No. 3 /////
            for (int i = 0; i <= 100; i++)
            {
                sum = sum + i;
                Console.WriteLine("la suma de los numeros es: " + sum);
            }
            Console.ReadKey();
            // ejericio No. 4 /////
            sum = sum + 2;
            for (num = 0; num <= 100; num = num + 2)
                Console.WriteLine("los numeros pares entre el 0 y 100 son: " + num);
            Console.ReadKey();
            // ejercicio No. 5 /////
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    cant = cant + 1;
                }

            }
            Console.Write("los numeros impares encontrados son {0}", cant);
            Console.ReadKey();
            // ejercicio No. 6 /////
            for (int i = 1; i <= 100; i = i + 2)
                suma = suma + i;
            Console.WriteLine("la suma de los numeros impares es: " + suma);
            Console.ReadKey();
            // ejercicio No. 7 /////
            Console.Write("Ingrese una cantidad de termino ");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            // ejerciciio No. 8 /////
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    cantid = cantid + 1;
                }
            }
            Console.WriteLine("Total de multiplos de 3 encontrados: {0} ", cantid);
            Console.ReadKey();
            // ejercicio No. 9 /////
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    su = su + i;
                }
            }
            Console.WriteLine("Total de la suma de numeros impares del 0 al 100: {0}", su);
            Console.ReadKey();
            // ejercicio No. 10 /////
            for (int i = 1; i <= 500; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    cantid = cantid + 1;
                }
            }
            Console.WriteLine("Cantidad de multiplos de 5 entre 1 al 500:  {0}", cantid);
            Console.ReadKey();
            // ejercicio No 11 /////
            Console.Write("Ingrese un numero para finalizar:   ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    ejer11 = ejer11 + 1;
                    ejer = ejer + i;
                }
            }
            Console.WriteLine("Multiplos de 2 encontrado: {0} ", ejer11);
            Console.WriteLine("Suma total de los multiplos: {0}", ejer);
            Console.ReadKey();
            // ejercicio No. 12 /////
            Console.Write("Ingrese un numero donde desea finalizar: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                    res12 = res12 + 1;
                    suma12 = suma12 + i;
                }
            }
            Console.WriteLine("Multiplos de 10 encontrado: {0} ", res12);
            Console.WriteLine("Suma total de los multiplos: {0}", suma12);
            Console.ReadKey();
            // ejercicio No. 13 /////
            Console.Write("Ingrese un numero menor a 500: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero >= 500)
            {
                Console.Write("El numero ingresado es mayor a 500.");
            }
            else
            {
                for (int i = numero; i <= 500; i = i + 8)
                {
                    Console.WriteLine(i);
                    suma13 = suma13 + i;
                    cantidad13 = cantidad13 + 1;
                }
            }

            Console.WriteLine("Suma de los numeros en 8 posiciones: {0}", suma13);
            Console.WriteLine("cantidad de numeros en 8 posiciones: {0}", cantidad13);
            Console.ReadKey();
            // ejercicio Nol. 14 /////
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    suma14 = suma14 + (i * i);
                }
            }
            Console.WriteLine("Suma de los cuadrados de numeros pares es: {0}", suma14);
            Console.ReadKey();
            // ejercicio No. 15 /////
            Console.Write("Introduce un numero menor que 100:");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 100)
            {
                Console.Write("No es un numero menor que 100");
            }
            else
            {
                for (int i = numero; i <= 100; i = i + 4)
                {
                    suma15 = suma15 + (i * i);
                }
            }
            Console.Write("Suma de los cuadrados de los numeros separados 4 posiciones: {0}", suma15);
            Console.ReadKey();
            // ejercicio No. 16 /////
            Console.Write("Ingrese un Número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("Numero Positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Numero Negativo");
            }
            else
            {
                Console.WriteLine("El numero es NEUTRO");
            }
            Console.ReadKey();
            // ejercicio NO. 17 /////
            Console.Write("Ingrese un Número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El Numero ingresado es PAR");
            }
            else
            {
                Console.WriteLine("El Numero ingresado es IMPAR");
            }
            Console.ReadKey();
            // ejercicio No. 18 /////
            Console.Write("Ingrese el numero donde desea Finalizar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < numero; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    cantidad18 = cantidad18 + 1;
                }
            }
            Console.WriteLine("Cantidad de multiplos de 3 encontrados: {0} ", cantidad18);
            Console.ReadKey();
            // ejercicio No. 19 /////
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    canpar = canpar + i;
                }
                else
                {
                    canim = canim + i;
                }
            }            Console.WriteLine("Suma de numeros PARES: {0}", canpar);            Console.WriteLine("Suma de numeros IMPARES: {0}", canim);            Console.ReadKey();
            // ejercicio No. 20 /////
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                    cant20 = cant20 + 1;
                }
            }            Console.WriteLine("Multiplos de 2 o 3 encontrados: {0}", cant20);            Console.ReadKey();
            // ejercicio # 21 /////
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                    cant21 = cant21 + 1;
                }
            }            Console.WriteLine("Multiplos de 2 y 3 encontrados: {0}", cant21);            Console.ReadKey();
            // ejercicio # 22 ////
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese un numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (mayor == 0)
                {
                    mayor = num22;
                    menor = 0;
                }
                if (num22 > mayor)
                {
                    mayor = num22;
                    menor = mayor;
                }
                if (num22 < menor)
                {
                    menor = num22;
                }
            }
            Console.WriteLine("El numero mayor es: {0}", mayor);
            Console.WriteLine("El numero menor es: {0}", menor);
            Console.ReadKey();
            // ejercicio # 23 /////
            Console.Write("Ingrese una cantidad  de Inicio: ");
            nume22 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese una cantidad  de Finalizacion: ");
            nume23 = Convert.ToInt32(Console.ReadLine());
            for (int i = nume22; i <= nume23; i++)
            {
                Console.WriteLine(i);
                cana = cana + 1;
                if (i % 2 == 0)
                {
                    canpa = canpa + 1;
                }
                else
                {
                    sumin = sumin + i;
                }
            }
            Console.WriteLine("Cantidad de numeros Naturales: {0}", cana);
            Console.WriteLine("Cantidad Numero Pares: {0}", canpa);
            Console.WriteLine("Suma de Numeros Impares: {0}", sumin);
            Console.ReadKey();
            // ejercicio # 24 /////
            mares = "";
            meres = "";
            for (int i = 1; i < 10; i++)
            {
                Console.Write("Ingrese un Numero: ");
                num24 = Convert.ToInt32(Console.ReadLine());
                if (num24 > 10)
                {
                    mares = mares + "" + num24 + ",";
                }
                else
                {
                    meres = meres + "" + num24 + ",";
                }
            }
            Console.WriteLine("Los numeros: {0}", mares + " " + "Son mayores que 10");
            Console.WriteLine("Los numeros: {0}", meres + " " + "Son Menores que 10");
            Console.ReadKey();
            // ejercicio #25 /////
            for (int i = 1; i < 15; i++)
            {
                Console.Write("Ingrese un numero entre el 1 al 100, excepto los Multiplos de 2:");
                num25 = Convert.ToInt32(Console.ReadLine());
                if (num25 < 0 || num25 > 100)
                {
                    Console.WriteLine("El numero ingresado no esta entre el rango de 1 - 100");
                    Console.ReadKey();
                    return;
                }
                if (num25 % 2 == 0)
                {
                    Console.WriteLine("El numero ingresado es multiplo de dos");
                    Console.ReadKey();
                    return;
            // ejercicio # 26 /////
            Console.Write("Ingrese un numero donde desea finalizar: ");
            num26 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num26; i++)
            {
                if (i % 5 == 0)
                {
                    sumul = sumul + i;
                }
                else
                {
                    Console.WriteLine(i);
                    sunume = sunume + i;
                }
            }
            Console.WriteLine("Suma de numeros Excepto los multiplos de 5: {0}", sunume);
            Console.WriteLine("Valor de la suma de los multiplos de 5: {0}", sumul);
            Console.ReadKey();
            // ejercicio # 27 /////
            Console.Write("Ingrese un Numero donde desea finalizar el conteo: ");            num27 = Convert.ToInt32(Console.ReadLine());            for (int i = 1; i <= num27; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                    cant27 = cant27 + 1;
                }
            }            Console.WriteLine("Cantidad de numeros Multiplos de 2 y 3: {0}", cant27);            Console.ReadKey();
            /// ejercicio # 28 /////
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                num28 = Convert.ToInt32(Console.ReadLine());
                if (num28 % 5 == 0)
                {
                    sumu28 = sumu28 + num28;
                }
                if (num28 > mayor28)
                {
                    mayor28 = num28;
                }
                if (num28 % 2 == 0)
                {
                    sumaim28 = sumaim28 + num28;
                }
            }
            Console.WriteLine("Suma de los Multiplos de 5: {0}", sumu28);
            Console.WriteLine("El mayor de los Numeros Ingresado: {0}", mayor28);
            Console.WriteLine("Suma de los numeros impares: {0}", sumu28);
            Console.ReadKey();
            // ejercicio # 29 /////
            Console.Write("Ingrese un Numero: ");
            num29 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro numero Mayor que el anterior: ");
            nume29 = Convert.ToInt32(Console.ReadLine());
            if (nume29 > num29)
            {
                for (int i = num29; i < nume29; i = i + 7)
                {
                    Console.WriteLine(i);
                    if (i % 2 == 0)
                    {
                        cap29 = cap29 + 1;
                    }
                    else
                    {
                        sumim29 = sumim29 + i;
                    }
                }

            }
            else
            {
                Console.WriteLine("El segundo numero no es mayor al primero.....");

            }
            Console.WriteLine("Numeros pares encontrados: {0}", cap29);
            Console.WriteLine("Suma de Numeros Impares: {0}", sumim29);
            Console.ReadKey();
            // ejercicio # 30 /////
            Console.Write("Ingrese una Cantidad: ");            cant30 = Convert.ToInt32(Console.ReadLine());            if (cant30 < 500)
            {
                Console.WriteLine("\n ========================");
                Console.WriteLine("El numero que ingreso es: {0}", cant30
                    );
                cant30 = cant30 + (cant30 * 50 / 100);
                Console.WriteLine("Total mas 50%: {0}", cant30);

            }            else if (cant30 >= 500 && cant30 < 1000)
            {
                Console.WriteLine("\n ========================");
                Console.WriteLine("El numero que ingreso es: {0}", cant30);
                cant30 = cant30 + (cant30 * 7 / 100);
                Console.WriteLine("Total mas 7%: {0}", cant30);
            }            else if (cant30 > 1000 && cant30 <= 5000)
            {
                Console.WriteLine("\n ========================");
                Console.WriteLine("El numero que ingreso es: {0}", cant30);
                cant30 = cant30 - (cant30 * 5 / 100);
                Console.WriteLine("Total menos 5%: {0}", cant30);
            }            Console.ReadKey();
            // ejercicio # 31/////
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("==========Serie {0}==========", i);
                for (int n = 1; n <= 10; n++)
                {
                    Console.WriteLine(n);
                }

            }
            Console.ReadKey();
            //  ejercicio # 32 /////

            while (n1 > n2)
            {
                Console.Write("Ingrese un valor entero positivo: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el otro valor mayor al anterior: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                if (n1 > n2)
                {
                    Console.Write("Error debe ingresar el Segundo valor mayor o igual al primero");
                }
            }
            c32 = n1;
            while (c32 <= n2)
            {
                if (c32 % 2 == 0)
                {
                    Console.WriteLine(c32);
                    cop32++;
                    sop32 = sop32 + c32;
                }
                c32++;
            }
            Console.WriteLine("Multiplos de 2 encontrados: " + cop32);
            Console.WriteLine("La suma de los multiplos de 2: " + sop32);
            Console.ReadKey();
            // ejercicio # 33 /////
            Console.Write("Ingrese un numero a calcular el Factorial: ");
            num33 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num33; i++)
            {
                fito = fito * i;
            }
            Console.WriteLine("El Factorial del numero ingresado es: {0}", fito);
            Console.ReadKey();
            // ejercicio # 34 /////
            Console.Write("Ingrese el primer número entero: ");
            n34 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número entero: ");
            nu34 = Convert.ToInt32(Console.ReadLine());
            while (c34 < n2)
            {
                mul34 = mul34 - n34;
                c34++;
            }
            Console.WriteLine("La multiplicación por sumas sucesivas es: " + mul34 * -1);
            Console.ReadKey();
            // ejercicio # 35 /////
            while (nu35 > n35)
            {
                Console.Write("Ingrese un valor entero positivo: ");
                n35 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el otro valor menor al anterior: ");
                nu35 = Convert.ToInt32(Console.ReadLine());
            }
            ca35 = n35;
            while (ca35 >= nu35)
            {
                ca35 = ca35 - nu35;
                i35++;
            }
            Console.WriteLine("El cociente por restas sucesivas es: " + i35);
            Console.WriteLine("El resto de la divisón por restas sucesivas es: " + ca35);
            Console.ReadKey();
            // ejercicio # 36 /////


            // ejercicio 3 37 /////
            Console.Write("Ingrese un numero entero positivo: ");
            num37 = Convert.ToInt32(Console.ReadLine());

            while (num37 >= 10)
            {
                cant37++;
                num37 = num37 / 10;
            }
            Console.WriteLine("El número tiene: " + (cant37 + 1) + " dígitos");
            Console.ReadKey();
            // ejercicio # 38 /////

            // ejercicio # 39 /////
            for (int i = 1; i <= num39; i++)
            {
                Console.WriteLine(i + " - " + serieFib(i));
            }
            Console.ReadKey();

        }
        public static long serieFib(int n)
        {
            if (n <= 1)
                return n;

            else return serieFib(n - 1) + serieFib(n - 2);
            // ejercicio # 40 /////
            Console.Write("Ingrese un valor: ");
            num40 = Convert.ToInt32(Console.ReadLine());
            while (cout < num40)
            {
                cout++;
                while (auxi < cout)
                {
                    auxi++;
                    if (cout % auxi == 0)
                    {
                        cin++;
                    }
                }
                if (cin == 2)
                {
                    Console.WriteLine(" " + cout);

                }
                cin = 0;
                auxi = 0;
            }
            Console.WriteLine("El menor numero primos es: 2");
            Console.ReadKey();
            // ejercicio # 41 /////

            Console.Write("Ingrese un numero ENTERO para Convertir a BINARIO: ");
            num41 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n===============");
            Console.Write("BINARIO: ");
            while ((num41) != 0)
            {
                xoxo = num41 % 2;
                Console.Write("" + xoxo);
                num41 = num41 / 2;
            }
            Console.ReadKey();*/
            // ejercicio # 42 /////

        }
}    
}         