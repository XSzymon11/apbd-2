// w języku C# nazwa pliku i nazwa klasy nie muszą być takie same
public class CosTam // PascalCase - CosTam
{
    public static void Main(string[] args)
    {
        // typy danych string (konwencja jest taka, ze piszemy z małej)
        // typy złożone piszemy z dużej litery (poza string)
        string zdanie = "Ala ma kota";
        int a = 2;
        double b = 2.4;

        // ify i pentle generalnie funkcjonują tak samo
        int[] arr = [1, 2, 3, 4];

        int wiekAni = 20; //CamelCase - wiekAni
        Console.WriteLine("Hello World!");
        
        // 1.Nullable types (boxing/unboxing)
        //int s = null; // nie działa
        int? s1 = null; //znak zapytania dodany przy dowolnym typie prostym oznacza, że ten typ prosty może przechowywać null
        //inaczej
        Nullable<int> s2 = null; //klasa Nullable to jest tzw Wrapper (opakowuje nam i pozwala przechowywać typ prosty) 
        
        //jak sprawdzić czy tam jest null?
        if (s1 == null)
        {
            
        }

        if (s1.HasValue) // jeśli ma wartość, inaczej - jeśli nie jest null'em
        {
            
        }
    }
}

// w jednym pliku możemy mieć wiele klas/interfejsó - nie jest to zalecane
public class Student
{
    
}

// w przypadku Javy mamy package, a w przypadku C# mamy namespacese
// namespace działają jak fodlery na dysku
// najważniejsze dla nas będą - Klasy, Interfejsy, trochę mniej Structury, Enumy i Recordy
// Struct jest pewną uproszczoną formą klasy, przechowywaną trochę inaczej w pamięci - bardziej na stosie a nie stercie
// Record ma domyślne funkcje związane z porównywaniem obiektów zaimplementowane w sobie
// przydatne  wimplementacji konkretnych wzoróców programowania