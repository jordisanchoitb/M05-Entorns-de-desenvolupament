# 2. Crea un document .md en el directori de la solució (exercicis 1 i 2) i indica els següents punts amb les seves respostes:

## **Exercici 1**

***Codi***  
```
/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 1. Crea un programa que demani dos nombres per teclat i validi 
 * si aquests són naturals. Un cop validats, haurà d’indicar quin dels dos nombres és més gran o si tots dos són iguals.
 * 
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Msg1 = "Introdueix un numero";
            const string Msg2 = "Introdueix un altre numero";
            int num1, num2;
            Console.WriteLine(Msg1);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Msg2);
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El primer numero introduit es natural? {(IsPositive(num1) ? "SI" : "NO")}");
            Console.WriteLine($"El segon numero introduit es natural? {(IsPositive(num2) ? "SI" : "NO")}");
            Bigger(num1, num2);
        }
        public static bool IsPositive(int num)
        {
            return num > 0;
        }

        public static void Bigger(int num1, int num2)
        {
            const string MSGEquals = "Els dos nombres son iguals";
            const string MSGBigger = "EL numero {0} es el mes gran dels dos.";

            if (num1 == num2) 
            { 
                Console.WriteLine(MSGEquals);
            }
            else if (num1 > num2)
            {
                Console.WriteLine(MSGBigger, num1);
            } else 
            {
                Console.WriteLine(MSGBigger, num2);
            }
        }
    }
}
```

### a. Proves funcionals: classes d'equivalència, els valors límit corresponents i exemples de classes vàlides i classes invàlides

- Valors Límits corresponents  
**Num1 i Num2:**  
**Valor minim**: 1  
**Valor maxim**: 2147483647

- Classes d'equivalència  
**num1**  
Classes vàlides: 9, 2, 4  
Classes invàlides: -9, 0.6, -7  
**num2**  
Classes vàlides: 79, 8, 46  
Classes invàlides: -5, 2.6, -36

### b. Proves estructurals: implementa un projecte de test amb les seves respectives proves unitàries i enumera-les en el document. Un cop finalitzat, indica quin tipus de proves has realitzat (amb els resultats esperats i els resultats obtinguts).

- **Test1**   
**Input:** 9, 4
**Resultats esperats:**    
El primer nombre introduit es natural? SI  
El segon nombre introduit es natural? SI  
El numero 9 es el mes gran dels dos.  
**Resultats obtinguts:**    
El primer nombre introduit es natural? SI  
El segon nombre introduit es natural? SI  
El numero 9 es el mes gran dels dos.

- **Test2**  
**Input:** -84, 9  
**Resultats esperats:**  
El primer nombre introduit es natural? NO  
El segon nombre introduit es natural? SI  
El numero 9 es el mes gran dels dos  
**Resultats obtinguts:**  
El primer nombre introduit es natural? NO  
El segon nombre introduit es natural? SI  
El numero 9 es el mes gran dels dos.

- **Test3**
**Input:** 16, 16
**Resultats esperats:**  
El primer nombre introduit es natural? SI  
El segon nombre introduit es natural? SI  
Els dos nombres son iguals  
**Resultats obtinguts:**  
El primer nombre introduit es natural? SI  
El segon nombre introduit es natural? SI  
Els dos nombres son iguals


- **Test4**
**Input:** 0.5, 2  
**Resultats esperats:**  
Error del programa ja que no accepta floats     
**Resultats obtinguts:**
```  
Exeption Ungalndled   
System.FormatException: 'The input string '0.6' was not in a correct format.'  
```

## **Exercici 2**

***Codi***  
```
/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 2. Crea un programa que demani per teclat un la base i 
 * l’exponent i retorni la potència
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MSGBase = "Introdueix la base del numero";
            const string MSGPower = "Introdueix l'exponen del numero";
            int basenumber, powernumber;
            Console.WriteLine(MSGBase);
            basenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MSGPower);
            powernumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La potencia es: " + Power(basenumber, powernumber));
        }
        public static int Power(int basenum, int powernum)
        {
            int power = 1;
            if (powernum >= 0) 
            {
                for (int i = 1; i < powernum; i++)
                {
                    power *= basenum;
                }
            } else
            {
                for (int i = 1; i < powernum; i++)
                {
                    power /= basenum;
                }
            }
            return power;
        }
    }
}
```

### a. Proves funcionals: classes d'equivalència, els valors límit corresponents i exemples de classes vàlides i classes invàlides

- Valors Límits corresponents  
**Numero Base i Exponent**  
Valor minim: 0  
Valor maxim: 2147483647

- Classes d'equivalència  
**Numero Base**  
Classes vàlides: 10, 8, 12  
Classes invàlides: -50, 0.98, -7  
**Exponent**  
Classes vàlides: 4, 9, 16  
Classes invàlides: -7, 0.9, -37

### b. Proves estructurals: implementa un projecte de test amb les seves respectives proves unitàries i enumera-les en el document. Un cop finalitzat, indica quin tipus de proves has realitzat (amb els resultats esperats i els resultats obtinguts).

- **Test1**   
**Input:** 8, 0  
**Resultats esperats:**  
1  
**Resultats obtinguts:**    
1

- **Test2**  
**Input:** -8, 8  
**Resultats esperats:**  
-16777216  
**Resultats obtinguts:**  
-16777216

- **Test3**  
**Input:** 4, -4  
**Resultats esperats:**  
0.003906
**Resultats obtinguts:**  
0.003906

- **Test4**  
**Input:** 0.5, 2   
**Resultats esperats:**  
Error del programa ja que no accepta floats     
**Resultats obtinguts:**  
```  
Exeption Ungalndled   
System.FormatException: 'The input string '0.5' was not in a correct format.'  
```