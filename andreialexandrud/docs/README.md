# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.



1. Inheritance (Base Class and Derived Class)

    public class Animal // Base Class
    {
        public void Method1()
        {
          //
        }
    }

    public class Mamifer : Animal // Derived Class
    {
          //
    }

2. Polimorfism


    class Animal 
    {
        public virtual void animalSound() 
        {
        Console.WriteLine("Sunet!!!");
        }
    }

    class Corb : Animal  //Derived Class override "animalSound" from Base Class
    {
      public override void animalSound() 
      {
        Console.WriteLine("Cra cra!");
      }
    }

3. Abstraction, the process by which some sensible informations are hidden by the user
 
    abstract class Animal
    {
 
      public abstract void animalSound();
 
      public void sleep()
      {
        Console.WriteLine("Sound");
      }
    }

    class Corb : Animal
    {
      public override void animalSound()
      {
    
        Console.WriteLine("Cra cra!!!");
      }
    }

    In this case, method "animalSound()" cand be called only from "Corb" object.


    4. Encapsulation => a group of methods, properties, and members (from class), are linked to a single entity(our object in this case).
