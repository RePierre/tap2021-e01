# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.


1.Abstractizarea
    Abstractizarea este procesul prin care se ascund anumite functionalitati.
    Se lucreaza cu clase abstracte si metode abstracte.
    O clasa abstracta este o clasa care nu poate avea instante,ea fiind creata cu scopul de a fi mostenite anumite metode.
    O metoda abstracta poate fi creata intro clasa abstracta ,dar nu are o implementare in clasa de baza ,fiind nevoie de o implementare in clasa derivata.
    O clasa abstracta poate avea si metode care nu sunt abstracte si anume care au o implementare.
2.Incapsularea si Mostenirea
      Incapsularea se refera la controlul accesibilitatii metodelor si campurilor dintr-o clasa in afara clasei si deasemenea in clasele derivate.
      Fiecare metoda sau camp are in fata ,la declarare un specificator de acces:public,private sau protected.
      La mostenire se pastreaza modificatorii de acces:
        -Daca se foloseste private ,atunci metodele si campurile de acest tip sunt accesibile doar in clasa de baza,nefiind accesibile nici in afara clasei nici in clasele derivate.
        -Daca se foloseste protected, atunci metodele si campurile de acest tip sunt sunt acce de acest tip sunt accesibile in clasa de baza si in clasele derivate, nefiind accesibile in afara clasei.
        -Daca se foloseste public, atunci metodele si campurile de acest tip sunt sunt accesible peste tot,ceea ce nu este recomandat.
       In general metodele se declara public reprezint functionalitati,iar campurile private sau protected,dar pot fi si exceptii daca se considera.


4.Polimorfism
  Polimorfismul se refera la mai multe implementari ale aceleeasi metode pentru a primi liste de parametri diferite si se realizeaza intro singura clasa sau intro ierarhie de clasa unde metoda are aceeasi semnatura ,dar are implementari diferite in clasele derivate.
