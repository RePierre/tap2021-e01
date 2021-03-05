# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.

Principii ale poo:
1.Mostenirea : conceptul de creare de clase noi pornind de la clase vechi 

class patrulater{ i
nt nrlaturi; 
patrulater() 
{
nrlaturi=4;
}
}
class dreptunghi : patrulater{
int l,L;
patrat(int l,int L){
this->l=l;
this->L=L;
this->nrlaturi=4;
}
}

2.Polimorfism : se atinge prin suprascriere si supraincarcare; asigura flexibilitate codului
class bani {
	
	afis(int i){
		cout<<i;
	}
	afis(double i){
		cout<< i;
	}
}
3.Abstractizarea : se realizeaza prin clase abstracte( clase care au modificatorul abstract si au cel putin o functie pur virtuala); acest principiu asigura securitate codului,procesul de prelucrare 
a datelor fiind ascus,utilizatorului afisandu se doar rezultatul finit.

			Interfata este o extensie a clasei abstracte,in sensul ca are daor functii pur virtuale;
