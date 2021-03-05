# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.

1. Incapsularea = asigura faptul ca obiectele nu pot schimba starea interna a altor obiecte in mod direct( ci doar
                  prin metode puse la dispozitie de obiectul respectiv); doar metodele proprii ale obiectului pot
                   accesa starea acestuia;
   Exemplu:
   namspace RectangleApplication{
          class Rectangle{
                publuc double length;
                public double width;
                public double GetArea(){
                    return length * width;
                }
                public void Display(){
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
                }
          }
          class ExecuteRectangle{
                static void Main(string[] args){
                    Rectabgle r= nre Rectangle();
                    r.length=4.5;
                    r.width=3.5;
                    r.Display();
                    Cconsole.ReadLine();
                }
          }
   }


   2.Mostenirea = permite definirea si crearea unro clase plecand de la alte clase deja definite.
                Acestea pot impartasi comportamentul lor, fara a fi nevoie de a-l redefini.

    class Vechicle{
        public string brand = "Ford";
        public void honk(){
            Console.WriteLine("Bip");
        }
    }
    class Car: Vehicle{
        public string modeName = "Mustang";
    }
    class Program{
        static void Main(string[] args){
            car myCar=new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand+" "+myCar.modeName);
        }
    }
    
    3.Polimorfism = capacitatea de a oferi aceeasi interfata pentru obiecte cu implementari diferite. Conduce la
           simplificarea codului folosind abstractiuni.

           class Animal{
                  public void animalSound(){
                        Console.WirteLine("The animal makes a sound");
                  }
           }
           class Pig : Animal{
                  public void animalSound(){
                        Console.WriteLine("The pig says: guit guit");
                  }
           }
           class Dog: Animal{
                  public void animalSound(){
                        Console.WiteLine("The dog says: ham ham");
                  }
           }

           class Program{
                  static void Mian(string[] args){
                        Animal myAnimal=new Animal();
                        Animal myPig=new Pig();
                        Animal myDog=new Dog();

                        myAnimal.animalSound();
                        myPig.animalSound();
                        myDog.animalSound();
                  }
           }