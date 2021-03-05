# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.

Principiile programarii OOP sunt urmatoarele:

1)Incapsularea - imbinarea datelor si metodelor care sunt procesate, in principal getters si setters

Exemplu:


public abstract class PocketChange
{ public decimal change
protected PocketChange(decimal change)
{
	this.change=change;
}
public abstract decimal PaperCurrency();

}

2)Mostenirea - Avem o clasa derivata ce mosteneste(pastreaza proprieteati-le acesteia si le poate modifica) din clasa parinte metode si variabile


Exemplu: public class SodaVendingMachine:PocketChange{
public override decimal PaperCurrency(){return change/2.0;}}


3)Polimorfismul- Mai multe derivate impartasesc acelasi comportament. Se realizeaza cu overload(acelasi nume la metoda) sau override(putem redefini metoda)	



Exemplu: public class SodaVendingMachine:PocketChange{
public override decimal PaperCurrency(){return change/2.0;}   <----Override
} 


public class SodaVendingMachine:PocketChange{
protected PocketChange(decimal change)
{
	this.change=2*change;     <----Overload
}  
} 
ACELASI EXEMPLU ! dar restructurat


Abstractizarea fiind ceva general codului/programarii.