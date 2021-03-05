# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.


### Abstractizarea
-pastrarea aspectelor importante (generale) si ignorarea detaliilor nesemnificative(specifice)
Ex. : In cazul in care task-ul tau va fi de a crea o functionalitate de salvare in baza de date, colegii tai vor folosi functionalitatea cand vor salva lucruri in baza de date, iar in acest caz ei nu vor trebui sa stie modul de implementare si pur si simplu sa o foloseasca cu un efort minim.

#### Incapsulare
- ascunderea implementarii fata de client
Ex. :Daca luam tot exemplul precendent in care tu faci functionalitatea de adaugare in baza de date, e posibil ca acolo sa ai niste variabile in care sa tii username-ul si parola de conectare la baza de date si nu ai vrea ca o alta functionalitatea sa poata modifica variabila username sau din gresala ea sa fie suprascrisa de un username folosit in zona de creare useri.

##### Modularizare
-impartirea unui sistem complex in parti (module) manevrabile

###### Ierarhizare
-clasificarea pe nivele de abstractizare
Ex. : ContDebit si ContCredit ce mostenesc Cont ce contine proprietatile: Titular, Sold, depune(), extrage()

###### Polimorfism
-aceeasi forma sintactica poate avea diferite intelesuri in functie de contextul de utilizare
Ex. : In cadrul unui site de vanzari auto putem avea o clasa Vehicle, iar in aceasta vom creea o metoda care sa ne aduca informatiile unei masini pe baza nr. de inmatriculare.
	  In acelasi timp putem face asta si pe baza seriei de sasiu. Asadar ele primesc input-uri diferite dar afiseaza acelasi lucru.