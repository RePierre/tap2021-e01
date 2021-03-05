# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.


Incapsularea - capacitatea de a repezenta concepte direct intr-un program si de a ascunde detaiile din spate
Ex: avem niste date importante si le incapsulam astfel incat sa nu poata fi accesate din exterior (de exemplu o parola)

Polimorfism - capacitatea de a oferi aceeasi interfata pentru obiecte cu implementari diferite. 
Ex: Avem o clasa cu figuri geometrice si cateva clase derivate din aceasta. Noi nu putem afla de exemplu aria unei figuri geometrice, 
chiar daca avem metodele in clasele derivate. Pentru aceasta, avem nevoie sa avem metoda respectiva si in clasa parinte, altfel apelurile nu sunt posibile.

Mostenirea - posibilitatea de a construi noi abstractizari pornind de la una deja existenta in care proprietatile se pastreaza de la clasa parinte si 
pot fi imbunatatite.
Ex: class Copil: public Parinte{}; 