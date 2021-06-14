# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.

Principiile programării orientate obiect sunt:
1) Procesul de abstractizare a datelor are legatură cu ascunderea anumitor elemente care compun clasele
   și punerea în evidență a acelor informații esențiale pentru un utilizator. 
   Abstractizarea poate fi facută fie prin clase abstracte, fie prin interfețe. 
   De exemplu, atunci când lucrezi într-o echipă de programatori ai putea primi un task în care e nevoie să creezi 
   funcționalitatea de salvare în baza de date. Ceilalți colegi vor folosi funcționalitatea ta de foarte multe ori 
   când vor salva lucruri în baza de date. Dar ei nu trebuie să știe exact cum salvezi tu acele date,
   cum ai scris codul și ce se întâmplă mai exact în funcționalitatea ta.
   Ei vor folosi funcționalitatea ta trimițând datele în baza de date cu un efort minim. 
   În acest mod, codul aplicației este format din bucățele de cod care fac anumite lucruri bine definite.
2) Încapsularea este procesul prin care ținem datele și funcțiile separate de exterior. 
   Daca luam exemplul de la abstractizare în care tu faci funcționalitatea de adăugare în baza de date,
   e posibil ca acolo să ai niște variabile în care să ții username-ul și parola de conectare la baza de date. 
   În cazul ăsta, nu ai vrea ca o altă funcționalitate să poată modifica variabila username sau din greșealp ea sp fie suprascrisă
   de un username folosit în zona de creare. Prin încapsulare creem o capsulă care delimitează interiorul de exterior.
3) Moștenirea dă voie unor clase să preia proprietăși din alte clase. 
   Un exemplu ar fi în cazul unei aplicații prin care vindem mașini.
   Aceste mașini au în general aceleași proprietăți cu câteva mici diferențe.
   Toate vor avea un anumit tip de combustibil, capacitate cilindrică a motorului sau preț. 
   Diferența vine atunci cănd ne interesează numărul de locuri în cazul unui autoturism și masa maximă de transport în cazul unui camion.
   În codul nostru, vom avea nevoie de 2 clase și anume Car și Truck care au destul de multe proprietăți în comun. 
   Ca să nu duplicăm proprietățile acestea putem să face, o clasă principală numită Vehicle care va avea proprietățile comune 
   și apoi clasele Car și Truck care vor moșteni Vehicle și vor avea în plus proprietățile specifice.
4) Polimorfismul este procesul prin care putem să creem mai multe copii ale aceleiași metode care poate să primească inputuri diferite.
   Ca exemplu putem să luăm un site de vânzări auto.
   La moștenire am stabilit că avem nevoie de o clasă Vehicle și în ea vrem să creem o metodă care să ne aducă toate informațiile unei mașini
   pe baza numărului de ânmatriculare. În același timp vrem să putem face acest lucru și pe baza seriei de șasiu.
   Aceste 2 date sunt diferite ca format și lungime așa că avem nevoie de 2 metode, cu același nume care primesc inputuri diferite dar afișeaza același lucru.
   