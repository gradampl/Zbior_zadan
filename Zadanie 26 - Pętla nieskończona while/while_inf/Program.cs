﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    Jak wiesz lub nie pętla nieskończona oznacza, że będzie wykonywała swoje instrukcje cały czas. 
    W tym programie skorzystasz z takiej możliwości w pętli while. 

    a więc...
    1. Stwórz klasę petle
    2. Stwórz metodę nieskonczona_petla()    <= zastanów się co oznacza taki sposób prezentacji metody
    3. W metodzie nieskonczna_petla() stwórz pętle while, która dopóki będzie prawdziwa, wypisze na
    ekran Kotek. Więc aby stworzyć pętlę nieskończną musimy ustawić
    jej warunek na sztucznie prawdziwy. Jak to robimy?

    Zapamiętaj raz a dobrze, TO BARDZO WAŻNE:
    W C# wystarczy w warunku napisać słowo true aby otrzymać pętlę nieskończoną np. while(true)
    bądź wystarczy napisać warunek który zawsze będzie prawdziwy np. x == 5 , ustawiamy x = 5 
    i nie zmieniamy x. Wtedy cały czas warunek będzie prawdziwy. Sprawdź sobie oba przypadki
    żeby Ci się lepiej utrwaliły. 
    
    4. Stwórz konstruktor statyczny (dla przećwiczenia).
    5. Za pomocą konstruktora statycznego stwórz obiekt.
    6. Wywołaj funkcję nieskonczona_petla(). Skompiluj program i uruchom. 
    7. Zaobserwuj efekt. 

    A więc zapamiętaj:
    - Wszystko o pętli While
    - Metoda typu void - czym jest, jak ją użyć?
    - Jak tworzymy pętlę nieskończoną sztucznie? (dwa sposoby)
    - Jak tworzymy klasę, metodę, obiekt, konstruktor statyczny i definicje tych pojęć.

    ==================================================================
    PO ZADANIU ! 
    Dodatek:
    Jak wykonasz już główne zadanie, to teraz polecam Ci sprawdzić czy rzeczywiście ta teoria
    powyżej ma sens na podstawie doświadczenia.

    stwórz zmienną typu całkowitego np. int liczba = 10, i daj w warunku while(liczba) A
    w środku pętli umieść liczba--.

    twój program ma na ekran drukować kolejno te liczby, czyli powinien zrobić tak:
    10
    9
    8
    .... itd.. (czyli te liczby ze zmiennej int liczba tak?)

    Te doświadczenie pokaże Ci, że gdy pętla natrafi na 0, zakończy działanie (a więc nie będzie nieskończona).
*/

namespace while_inf
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
