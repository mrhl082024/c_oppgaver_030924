using System.Collections;

namespace c_oppgaver_030924;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("\n");

        int skumleTall = 420;
        string kodingSuger = "Kan du lære med koding privat eg forstår ikke en dritt!";
        double skumleTallDecimaler = 0.69;
        char c = '@';

        Console.WriteLine(kodingSuger);
        Console.WriteLine(skumleTall);
        Console.WriteLine(skumleTallDecimaler);
        Console.WriteLine(skumleTall + skumleTallDecimaler);
        Console.WriteLine(c);

        Console.WriteLine("\n");

        int[] myNum = [10, 20, 30, 40];
        for (int i = 0; i < myNum.Length; i = i + 1)
        {
            Console.WriteLine(myNum[i]);
        }


        string[] myStrings = ["forstår", "fortsatt", "jævelig lite"];
        foreach (string item in myStrings)
        {
            Console.WriteLine(item);
        }

        List<string> nyTekst = new List<string>();
        nyTekst.Add("BMW");
        nyTekst.Add("Volvo");
        nyTekst.Add("Audi");
        foreach (string nyItem in nyTekst)
        {
            Console.WriteLine(nyItem);
        }
        /* Oppgaver
        Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
        Lag en variabel av datatypen string og tilden en vilkårlig tekst
        Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
        Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav)
        Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke
        Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
        Lag en List av datatypen string og tildel verdier ved hjelp av List sin innebygde metode "Add()"
        Legg til flere strings i listen deres
        Skriv ut verdiene i listen ved hjelp av en foreach-løkke
        */

        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        myDictionary.Add(1, "one");
        myDictionary.Add(2, "two");
        myDictionary.Add(3, "three");
        foreach (var item3 in myDictionary)
        {
            Console.WriteLine(item3);
        }

        int a = 10;
        int b = 20;
        Console.WriteLine(a + b);
        string fname = Console.ReadLine();
        myMethod(fname);

        /*
        Lag en Dictionary med integer-nøkkel og string-verdi slik
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        Skriv ut verdiene i Dictionary ved å anvende en foreach-løkke ved hjelp av datatypen var
        Lag en metode av typen integer som legger sammen to tall, int a og int b
        Lag en metode av typen string som skrive ut en liten hilsen til brukeren ved å bruke en parametervariabel.
        */
    }

    static void myMethod(string fname)
    {
        Console.WriteLine(fname + "\n" + "Sees igjen");
    }



}

