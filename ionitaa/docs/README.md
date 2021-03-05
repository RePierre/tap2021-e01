# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.

##Rezolvare##
Incapsularea este un mecanism care leagă împreună cod şi date şi le păstrează pe ambele în siguranţă faţă de intervenţii din afară şi de utilizări greşite.  În 
acest fel, un obiect dispune de  un nivel semnificativ  de protecţie care împiedică modificarea accidentală sau utilizarea incorectă a părţilor proprii obiectului 
de către secţiuni ale programului cu care nu are legătură.

Polimorfism este caracteristica ce permite unei interfeţe să fie folosită cu o clasă generală de acţiuni. Acţiunea specifică selectată este determinată de natura
precisă a situaţiei.  De exemplu, se poate implementa un program care defineşte trei tipuri de memorie stivă. Una este folosită pentru valori întregi, una pentru
valori tip caracter şi una pentru valori în virgulă mobilă. Datorită polimorfismului se pot crea trei perechi de funcţii numite push() şi pop() – câte una pentru
fiecare  tip de date.

Mostenirea este procesul prin care un obiect poate să preia prototipul altui obiect. Acest lucru este important deoarece se admite conceptul de clasificare.
Majoritatea cunoştinţelor despre lumea înconjurătoare sunt accesibile deoarece sunt clasificate ierarhic. De exemplu, un pisica sphynx face parte din clasa pisica,
care la rândul său face parte din clasa mamifere care se află în marea clasă animale. Fără utilizarea claselor, fiecare obiect ar trebui definit explicitându-se
toate caracteristicile sale. Însă, prin folosirea clasificărilor, un obiect are nevoie doar de definirea acelor calităţi care îl fac unic în clasa sa. Mecanismul
moştenirii este acela care face posibil ca un obiect să fie un exemplar specific al unui caz mai general.