namespace APBD_cw2.Models;
//nasza przestrzeń nazw (namespace nie musi korelować z folderem - może być "namespace APBD_cw2.blahblahblah;"

//interferjsy - zaczynamy zawsze od dużej literki I
public interface IEmployee
{
    double CalculateSalary();
}

//dziedziczenie
public class Person : IEmployee
{
    public string Email { get; set; }
    public double CalculateSalary()
    {
        throw new NotImplementedException();
    }
}

public class Student : Person
{
    //fields
    private int _id; //pola prywatne często mają podłogę z przodu (są one wtedy pierwsze w podpowiedziach
    private string _name;
    private string _surname;
    private string _email;
    //w C# zamiast tworzenia pól, potem getterów i setterów możemy skorzystac z property (prop) - tworzymy je wtedy z dużej litery zgodnie z konwencja
    //Auto-property - w jednej linii kodu mmay prywatne pole oraz metodę get i set opakowane razem
    
    public string Imie { get; set; } //w sharplab.io można sprawdzić niskopoziomowo co się dzieje w naszym kodzie
    public string Nazwisko { get; set; }
    public int Id { get; set; }
    
    //konstruktory
    /*public Student()
    {
        
    }*/
    
    
    //Full property
    //private string _imie;

    /*public string Imie
    {
        //get => _imie;
        //set => _imie = value;
        //lub
        get
        {
            return _imie;
        }
        set
        {
            //dodajmy walidację
            if (value == null)
            {
                throw new ArgumentNullException("Imie");
            }
            _imie = value; //Value to słowo kluczowe równoważne z przypisywanym przez nas przy wywołaniu set na obiekcie klasy Student
        }
    }*/
    
    //methods
    public void CalculateAverageGrade()
    {
        
    }
    
    public string GetName()
    {
        return _name;
    }

    // tak też można stworzyć prostszy Getter
    // public string GetName() => _name;

    public void SetName(string name)
    {
        if (name == null) //walidacja
        {
            return;
        }
        _name = name;
    }


    public void DisplayInfo()
    {
        
    }
}

// W C# wszytskie kolekcje dziedziczą po tzw interfejsie IEnumerable\<T>
// więcej w Lecture2
// kiedy interfejs / jakie wzorce projektowe / dobre architektury 