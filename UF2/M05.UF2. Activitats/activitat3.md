# 2. Crea un document .md en el directori de la solució (exercici 11) i indica els següents punts amb les seves respostes:

## **Exercici 11**

***Codi***  
```
/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 28/11/2023
 * 11. Implementa un programa que demani un valor per teclat i retorni el seu factorial.
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            ulong usernumber;
            Console.WriteLine("Donem un numero");
            usernumber = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"El factorial es: {Factorial(usernumber)}");

        }
        public static ulong Factorial(ulong number)
        {
            ulong result = 1;

            for (ulong i = 1; i <= number;i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
```

### a. Proves funcionals: classes d'equivalència, els valors límit corresponents i exemples de classes vàlides i classes invàlides

- Valors Límits corresponents  
**usernumber:**  
**Valor minim**: 0  
**Valor maxim**: 65

- Classes d'equivalència  
**usernumber**  
Classes vàlides: 65, 0, 46  
Classes invàlides: -50, 2.6, 70

### b. Proves estructurals: implementa un projecte de test amb les seves respectives proves unitàries i enumera-les en el document. Un cop finalitzat, indica quin tipus de proves has realitzat (amb els resultats esperats i els resultats obtinguts).

- **Test1**   
**Input:** 3
**Resultats esperats:**    
6  
**Resultats obtinguts:**    
6

- **Test2**  
**Input:** 65  
**Resultats esperats:**  
9223372036854775808
**Resultats obtinguts:**  
9223372036854775808

- **Test3**
**Input:** -50
**Resultats esperats:**  
Error ja que no permet numeros negatius
**Resultats obtinguts:**  
```
System.OverflowException: 'Value was either too large or too small for a UInt64.'
```