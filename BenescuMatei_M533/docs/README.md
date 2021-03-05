# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.

Principiile programarii orientate obiect sunt: 
	Mostenire(Inheritance): proprietatea de a mosteni o clasa parinte si pastra toate metodele si proprietatile acesteia

Exemplu: class Persoana{
	private:
		string nume;
		string Id;
		uint_32t varsta;
		};



	class Student:Persoana{
	private:
		int nota1;
		int nota2;
		int medie;
		string clasa;



	};







	Polimorfism (polymorfism): este proprietatea de a avea un comportament diferint pentru situatii diferite
		Sunt doua tipuri de polimorfism:
			1. Overloading- 

			class Functie{
				public:
					void fun(int x){

					std::cout<<"x: "<<x;
					}
					void fun(double x){

					std::cout<<"x: "<<x;
					
					}
					void fun(int x,int y){
					std::cout<<"x: "<<x<<"\n y: "<<y;

					}



			}

	2.Overriding
		
		class Parinte{

			virtual void print()
			{std::cout<<" afiseaza ceva"<<endl;
			}


			void afis(){
				std::cout<<"afiseaza altceva"<<endl;

			}

		};
		class Derivat:public Parinte{
			
			public: void print(){std::cout<<"afiseaza derivata";}
			void show(){std::cout<<"afiseaza altceva derivata";}
	
		

		}




	Encapsulare (encapsulation): Toate metodele si campurile undei structuri pot fi inglobate ("wrapped") intr-o clasa
	Exemplu:
	class Masina{
		protected string Marca;
		protected string AnFabricatie;
	


	}
	class Camion: Masina{
		bool DieselSauBenzina;

	}
