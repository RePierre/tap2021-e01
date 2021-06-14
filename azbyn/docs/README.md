# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.

### Încapsulare ####

Permitem accesul din exterior doar la funcționalitatea necesară.

Exemplu:
```
class Cat {
    private int _meowCounter;

    public int MeowCounter => meowCounter;
    
    public void Meow() {
        ++_meowCounter;
        Console.WriteLine("Meow");
    }
}

```

Nu vrem ca cineva din exterior să modifice variabila `_meowCounter` la o valoare arbitrară:
```
var cat = new Cat();

cat._meowCounter = 42;
```


### Mostenire ###
Preluăm funcționalitate din clasa părinte în clasa copil.
De asemenea putem folosi clasa copil în contextul în care foloseam clasa părinte.

```
class Printer {
    public void Print() {
        Console.WriteLine("Thing");
    }
}

class FancyPrinter : Printer {
    public void FancyPrint() {
        Console.Write("Fancy output: ");
        Print();
    }
}
void UsePrinter(Printer p) {} // we can pass a FancyPrinter as a parameter.
```

### Polimorfism ###
Putem avea metode care își schimbă comportamentul în funcție de parametrii.

```
void SetColor(byte r, byte g, byte b) {...}
void SetColor(uint hex) {...}
```

De asemenea putem avea metode care își schimbă comportamentul în funcție de clasa obiectului

```
class A { public virtual int val() { return 42; } } 
class B : A { public int val() { return 2; } } 
```

