# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.

1.Abstarctizarea

Abstractizarea presupune reducerea la un model simplu a tuturor proprietăţilor şi metodelor de care dispune un obiect. 
Astfel realizarea unei clase (şablon) care ne arată ce proprietăţi si ce metode vor avea obiectele, reprezintă tocmai conceptul de abstractizare.  
Astfel clasa reprezintă o descriere a unor mulţimi de obiecte care au aceeaşi structură şi comportament. 
Până acum programarea ţinea cont de o succesiune de operaţii sau functii (programarea procedurală), dar în programarea orientată obiect accentul cade pe un ansamblu complet de date şi operaţii.

Tot prin abstractizare avem posibilitatea ca un program să ignore unele aspecte ale informației pe care o manipulează, adică posibilitatea de a se concentra asupra esențialului.  
De exemplu o masină poate fi vazută din punctul de vedere al unui proprietar sau din punctul de vedere al unui mecanic. 
Pentru un proprietar va conta probabil culoarea masinii, anul de fabricatie, marca, modelul etc., în timp ce pentru un mecanic va conta componentele mecanice, greutatea, puterea motorului, inspecţiile tehnice etc.

2. Incapsularea

Incapsularea reprezintă proprietatea claselor de a grupa datele şi metodele într-o singură structură de date. 
Incapsularea înseamnă că datele se definesc împreuna cu codul care acţioneaza asupra lor. 
Incapsularea mai este denumită şi tehnica de ascundere a datelor, deoarece poate restricţiona accesul la datele(caracteristicile) sau metodele unui obiect. 
In SAP caracteristicile sau metodele dintr-o clasă pot fi publice, private sau protejate. 
In funcţie de zona în care sunt declarate (public, private sau protected) caracteristicile pot fi accesate din exterior sau doar din interior prin diverse metode publice. 
Ca exemplu am putea sa luam o clasă masini care are ca atribute publice: marca, model, culoare şi atributul privat serie motor. 
Atributele publice pot fi folosite şi afisate şi din exterior, în timp ce pentru atributul privat vom avea nevoie de o metodă publica, de exemplu afisare_serie_motor în care vom afişa seria motorului şi aceasta metodă va fi chemata din exterior.

3. Mostenirea

Programarea orientată pe obiecte le permite claselor să moşteneasca stările (atributele) şi comportamentele(metodele) comune din alte clase, ceea ce înseamnă crearea unei clase copil pe baza unei clase parinte. 
Clasa copil conţine toate proprietătile şi metodele clasei parinte, dar poate include şi elemente noi. 
Să considerăm că avem o clasa maşina si 2 subclase limuzină şi cabrio. Dacă clasa maşina care este clasa părinte va avea de exemplu caracteristica culoare, atunci şi celelalte 2 clase copil vor dobîndi această caracteristică prin conceptul de moştenire. 
La fel se întâmplă si cu metodele care se regăsesc în clasa parinte, aceastea vor fi moştenite şi în clasa copil.

4. Polimorfism

Conceptul de polimorfism este legat de cel de moştenire, deoarece permite ca aceeaşi operaţie să se realizeze în mod diferit în clase diferite. 
Să considerăm că avem o clasa animale, cosiderată şi clasă părinte şi 3 clase copil (clasa caine, clasa pisica şi clasa rata ) care moştenesc comportamentele clasei animale. 
In clasa animale vom avea o metodă scoate_sunete care va fi moştenită de toate cele 3 clase copil. 
Tinând cont că fiecare animal va trebui să se comporte diferit în momentul când va fi apelată metoda scoate_sunete, atunci prin polimorfism vom putea face acest lucru şi vom 
permite metodei să se comporte diferit în functie de clasa în care este implementată.