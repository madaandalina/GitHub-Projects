using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiecte_FP_nota_5
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            /*
            //**************************************************exercitiul 1***************************************************
            
            ///ex 1 1.Rezolvati ec de gradul 1 cu o necunoscuta
            //ax + b = 0; input: a,b  x= -b/a, a e la numitor a!=0

            float a = float.Parse(Console.ReadLine());
            float b= float.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("nu exista solutie");
            }
            else
            {
                Console.WriteLine("x= " + (-b / a));
            }
            */


            //************************************************************exercitiul 2*************************************
            //ex 2. .Rezolvati ec de gradul 2 cu o necunoscuta
            //ax ^ 2 + bx + c = 0; input: a,b,c;

            /* 
            float a= float.Parse(Console.ReadLine());
            float b= float.Parse(Console.ReadLine());
            float c= float.Parse(Console.ReadLine());
            float delta;

            if(a == 0)
            {
                Console.WriteLine("Nu exista solutie ");
            }
            else
            {
                delta= b*b - 4*a*c;
                if(delta == 0)
                {
                    Console.WriteLine (-b/(2*a) );
                }else if(delta > 0)
                {
                    Console.WriteLine("x1 " + (-b +Math.Sqrt(delta))/(2*a)  );
                    Console.WriteLine("x2 " + (-b - Math.Sqrt(delta)) / (2 * a));
                }
                else 
                {
                    Console.WriteLine("nu exista solutie reala");

                }

            }
            */


            /*
            //**********************************************exercitiul 3*************************************************

            //3.Sa se determine daca n e divizibil cu k

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if(n % k == 0)
            {
                Console.WriteLine(n + " este divizibil cu " + k);
            }
            else
            {
                Console.WriteLine(n + " nu este divizibil cu " + k);

            }
            */

            /*
            //************************************* exercitiul 4 ***********************************************************

          
            int an = int.Parse(Console.ReadLine());
            bool bisect = false;

            if((an % 4 ==0) && (an % 100 != 0))
            {
                bisect = true;                  

            }
            if(an % 400 == 0)
            {
                bisect = true;

            }
            if(bisect == true)
            {
                Console.WriteLine("anul " + an+ " este bisect");
            }
            else
            {
                Console.WriteLine("anul " + an + " nu este bisect");

            }
            */

            /*
            //************************************* exercitiul 5 ***********************************************************
            //5.Extrageti a k-a cifra dintr-un numar, numarand cifrele de la dreapta spre stanga, incepand de la 0

            
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int poz = 0;

      
                while (n != 0)
                {
                    if (poz == k)
                    {
                        Console.WriteLine("numarul de pe pozitia " + k + " este " + n % 10);
                    }

                    n = n / 10;
                    poz++;
                }
            */
            


            /*
            //************************************* exercitiul 6 ***********************************************************
            //6.Se dau 3 numere pozitive a,b,c, sa se determine daca aceste numere pot fi lungimile laturilor unui triunghi
            //ex 1,2, 3 nu se poate forma .... 2,4,5 se poate forma
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

           // SUMA A DOUA LATURI E MAI MARE CA A3A

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Se poate forma un triunghi ");
            }
            else
            {
                Console.WriteLine("Nu se poate forma un triunghi ");

            }
            */

            //************************************* exercitiul 7 ***********************************************************
            //operatia swap - se dau 2 var numerice a si b , trebuie interschimbate valorile lor (aux)

            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int aux = a;
            a = b;
            b = aux;

            Console.WriteLine(a + " " + b);*/

            //************************************* exercitiul 8 ***********************************************************
            // swap restrictionat -se dau 2 var a si b, sa se interschimbe valorile lor, fara a folosi nici - o alta variabila suplimentara.

            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;


            Console.WriteLine("a si b interschimbate " + a + " " + b);*/

            /*

            //************************************* exercitiul 9 ***********************************************************
            //afisati toti divizorii numarului natural n.

            int n = int.Parse(Console.ReadLine());



            for (int d = 1; d <= n; d++)
            {
                
                if (n % d == 0)
                {
                    Console.WriteLine(d);
                }          
            }

            */

            /*
            //************************************* exercitiul 10 ***********************************************************
            //10.Test de primalitate, sa se determine daca un nr nat n este prim

            int n = int.Parse(Console.ReadLine());
            int cont = 0;


            for (int d = 1; d <= n; d++)
            {
               
                if (n % d == 0)
                {
                    cont++;
                }

            }

            if(cont == 2)
            {
                Console.WriteLine("Numarul este prim ");
            }
            else
            {
                Console.WriteLine("Numarul nu este prim ");
            }
            */

            //************************************* exercitiul 11 ***********************************************************
            //inversarea cifrelor unui nr. se da un nr natural n, trebuie det oglinditul sau.

            /*
            //varianta 2
            int m = int.Parse(Console.ReadLine());
            int cop = 0;

            while (m != 0)
            {

               cop = cop * 10 + m % 10;
                m = m / 10;
            }
            Console.WriteLine("oglindit " + cop);
            */

            /*
            //************************************* exercitiul 12 ***********************************************************
            //12.Se dau 2 nr nat a si b, cu a<b, si un nr nat n.Cate nr divizibile cu n, exista in intervalul [a,b]
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int cont = 0;       

            for (int i = a; i <= b; i++)
            {
                if (i % n  == 0)
                {
                    Console.WriteLine(i);
                    cont++;
                }
            }

            Console.WriteLine("cont " + cont);
            */

            /*
            
            //************************************ exercitiul 13 ***********************************************************
            // 13.Se dau 2 nr, y1 si y2, sa se determine cati ani bisecti intre[y1, y2]
            int y = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int cont = 0;         

            bool bisect = false;

            for (int an = y; an <= x; an++)
            {
                //bisect = false;
               
                if (an % 4 == 0 && an % 100 != 0)
                {

                    bisect = true;
                    cont++;
                }
                if (an % 400 == 0)
                {
                    bisect = true;
                    cont++;
                }

            }


            Console.WriteLine("Numarul de ani bisecti in intervalul " + y + " si " + x + " este " + cont);
            */



            /*
            //************************************ exercitiul 14 ***********************************************************
            //se da un nr n, sa se det daca este palindrom.

            int n = int.Parse(Console.ReadLine());
            int c = n;
            int pal = 0;

            while( c != 0)
            {
                pal = pal * 10 + c % 10;
                c = c / 10;
            }

            if( pal == n)
            {
                Console.WriteLine("Numarul este palindrom");
            }else
            {
                Console.WriteLine("Numarul nu este palindrom"); 
            }
            */

            /*
            //************************************ exercitiul 15 ***********************************************************

            //15.Se dau 3 numere, sa se afiseze in ordine crescatoare

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //a b c 6 permutari 

            Console.WriteLine("rezultatul este: ");

            //a > b > c, b>c 
            if (a > b && a > c && b > c)
            {
                Console.WriteLine(c + " " + b + " " + a + " ");
            }
            if (a > b && a > c && b < c)
            {
                Console.WriteLine(b + " " + c + " " + a + " ");
            }
            // b>a>c a>c
            if (b > a && b > c && c < a)
            {
                Console.WriteLine(c + " " + a + " " + b + " ");
            }
            if (b > a && b > c && c > a)
            {
                Console.WriteLine(a + " " + c + " " + b + " ");
            }
            //c>a>b c> b
            if (c > a && c > b && b > a)
            {
                Console.WriteLine(a + " " + b + " " + c + " ");
            }
            if (c > a && c > b && b < a)
            {
                Console.WriteLine(b + " " +  a + " " + c + " ");
            }
            */


            //************************************ exercitiul 16 ***********************************************************
            /*
            // 16. Se dau 5 numere, sa se afiseze in ordine crescatoare
            // Sortare in ordine crescatoare cu if-urile alea multe fiecaare cu fiecare 
            // a -b, a-c, a-d, a-e,
            // b-c, b-d, b-e
            // c-d, c-e
            // d- e
            // a b c d e


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int aux;
            Console.WriteLine($"{a} {b} {c} {d} {e}");

            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (a > d) { aux = a; a = d; d = aux; }
            if (a > e) { aux = a; a = e; e = aux; }
            if (b > c) { aux = b; b = c; c = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > e) { aux = b; b = e; e = aux; }
            if (c > d) { aux = c; c = d; d = aux; }
            if (c > e) { aux = c; c = e; e = aux; }
            if (d > e) { aux = d; d = e; e = aux; }

            Console.WriteLine($"{a} {b} {c} {d} {e}");
            */



            /*
             //************************************ exercitiul 17 ***********************************************************
             //17.CMMDC a 2 numere, a si b (Euclid)  cel m mare divizor comun 12= 2*2*3  - 4 =2*2 -> 2 (comuni, put cea mai mica)
             //cmmmc (comuni si necomuni la put cea mai mare 12, 4  4*3 -12

             int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());

            while(a != b)
             {
                 if (a > b)
                 {
                     a = a - b;
                 }


                 else //if (a < b) <---nu e necesar
                 {
                     b = b - a;   

                 }

             }

             Console.WriteLine("cmmdc euclid este " + a);
         */

            /*
            // *************************************EXERCITIUL 18*******************************************************
            //cmmmc

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int aa = a;
            int bb = b;

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }


                else //if (a < b) <---nu e necesar
                {
                    b = b - a;

                }

            }

            Console.WriteLine("cmmmc euclid este " aa*bb/ + a);
            */




            /*
            
            //************************************* exercitiul 19 ***********************************************************

            //19.Descompunerea in factori primi a unui nr.

            int n = int.Parse(Console.ReadLine());
            

            for (int d = 2; d <n ; d++)
            {
                int p = 0;
                while (n % d == 0)
                {
                    p++;
                    n = n / d;
                }
                if (p != 0)
                {
                    Console.WriteLine(d + " la puterea " + p);
                }

            }
            */



            /*
            //************************************* exercitiul 20 ***********************************************************

            
            //20.Se da un nr nat n, se cere sa se determine daca n este format prin repetarea unui nr format din exact 2 cifre de mai multe ori.
            //EXP: 2323,909090

           
            int n = int.Parse(Console.ReadLine());
            int x = n % 100;
            n = n / 100;
            bool ident = true;

            while (n != 0)
            {
                if (n % 100 != x)
                {
                    ident = false;
                }
                n = n / 100;

            }
            if (ident == true)
            {
                Console.WriteLine("da");
            }
            else
            {
                Console.WriteLine("nu");
            }
            */


            /*
            //************************************* exercitiul 21 ***********************************************************
            //23322232
            //21.Se da un nr, sa se determine daca in scrierea numarului apar exact 2 cifre.
EXP: 233232323

            int n = int.Parse(Console.ReadLine());
            int a = n % 10;
            int b=0;
            int cont = 1;

            while (n != 0)
            {
                if ((n % 10 != a) && (cont==1))
                {
                    b = n % 10;
                    cont++;

                }
                if ((n%10 != a) && (n %10 != b))
                {
                    cont++;
                }
                n = n / 10;
                    
            }

            if(cont == 2)
            {
                Console.WriteLine("nr din 2 cifre ");
            }else
            {
                Console.WriteLine("nr din mai multe cifre");
            }
            
            


            /*
            //************************************* exercitiul 22 ***********************************************************

            
            //22.Se dau 2 nr nat, m si n, se cere sa se afiseze fractia m/ n in forma zecimala
            //EXP: 13 / 30 = 0.4(3)

            float n = int.Parse(Console.ReadLine());
            float m = int.Parse(Console.ReadLine());

            Console.WriteLine(n / m);
            */


            /*
            //23.Scrieti un program care ghiceste un nr intre 1 si 1024 prin folosirea unor intrebari(Este nr>= x ?,Este mai mic decat x ?)
            
            int n = rnd.Next(0,1024);
            int ghi = int.Parse(Console.ReadLine());

            while(n != ghi)
            {

                if (ghi < n)
                {
                    Console.WriteLine("prea mic");
                    ghi = int.Parse(Console.ReadLine());

                }
                else if (ghi > n)
                {
                    Console.WriteLine("prea mare ");
                    ghi = int.Parse(Console.ReadLine());
                }

            }
           
            
            if (ghi == n)
            {
                Console.WriteLine("ai ghicit numarul! din: " + n);
            }
            */







            Console.ReadLine();

        }
    }
}
