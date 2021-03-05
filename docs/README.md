# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.


Principiile programării Orientate-Obiect sunt:
Incapsularea;
Mostenirea;
Polimorfismul;

Incapsularea reprezinta proprietatea unei clase de a mentine grupat intregul cod ce descrie functionalitatile unui obiect.

Ca exemplu am putea lua o clasa Animal, care are ca atribute publice: nume, culoare  si atribut privat: tip. Atributele publice pot fi folosite si afisate si din exterior, in timp ce pentru atributul privat vom avea nevoie de o metoda publica, de exemplu afisare_tip in care vom afisa tipul animalului si aceasta metoda va fi apelata din exterior.

Mostenirea reprezinta capacitatea de a defini noi tipuri prin extinderea unora deja existente.

Consideram ca avem o clasa principala, Animal si doua subclase: catel si pisica. Daca clasa Animal, care este clasa parinte va avea de exemplu caracteristica nume, atunci si celelalte doua clase vor dobandi aceasta caracteristica prin procesul de mostenire. La fel se intampla si cu metodele descrise in clasa parinte, Animal, acestea vor fi mostenite de clasele pisica si catel.

Polimorfismul reprezinta capacitatea unor entitati de a lua forme diferite.

Avem clasa parinte, Animal, si trei clase copil: catel, pisica, rata, care mostenesc comportamentul clasei Animal. In clasa animal vom avea o metoda: sunet, care va fi mostenita de toate cele trei clase copil. Tinand cont ca fiecare animal va trebui sa se comporte diferit in momentul in care va fi apelata metoda sunet, atunci prin polimorfism vom putea face acest lucru si vom permite metodei sa se comporte diferit in functie de clasa in care este implementata.