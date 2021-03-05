# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Principiile programării Orientate-Obiect ##
Enumerați principiile programării orientate obiect și pentru fiecare principiu dați o descriere și un exemplu.

Principiile POO sunt:</br>
1. Incapsularea:</br>
Imbinarea datelor si metodelor care le proceseaza. Capacitatea de a oferi garantii ca o abstractizare este utilizata numai in conformitate cu specificatiile sale.
</br>
Exemplu:</br>
Pentru fiecare extragere dintr-un cont bancar, se verifica daca exista suficiente fonduri:</br>
Metoda: </br>
public decimal withdraw(decimal ammount){ </br>
	if(Balance <= ammount) </br>
		throw new InvalidOperationException("Fonduri insuficiente"); </br>
	else </br>
		this.Balance -=ammount; </br>
	return ammount; </br>
}
Main: </br>
try{ </br>
	account.withdraw(ammount) </br>
}catch(InvalidOperationException e){</br>
	Console.WriteLine(e.Message)</br>
}</br>
Alt exemplu: Daca se implementeaza o clasa care reprezinta un magazin in momentul in care se cere un produs de catre consumator, trebuie verificat in stocul magazinului daca acel produs mai este disponibil, in caz contrar, se arunca o exceptie si se afiseaza mesajul acesteia.
</br>
</br>
2. Mostenirea:</br> 
Proprietatile tipului parinte se pastreaza si la copii. In alte cuvinte, reprezinta posibilitatea de a construi noi abstractizari pornind de la una deja existenta. Clasele "copil" pastreaza proprietatile clasei "parinte".
</br>
Exemplu:</br>
Clasa persoana va avea proprietatile: nume si cnp,care este private, si metodele de getName(), getCnp() si constructorul. Clasa Student mosteneste clasa Persoana astfel ca ea va avea si proprietatile si metodele clasei parinte, comportandu-se si ca un obiecte de tipul clasei Persoana. </br>
</br>	
Alt exemplu:</br>
Clasa animal va avea specificat tipul si metoda pentru getTip() si constructor. Clasa pisica mosteneste clasa animal ceea ce inseamna ca se comporta si ca un obiect de tip animal, dar si ca un obiect de tip pisica.</br></br>
3.Polimorfismul: </br>
Acelasi comportament manifestat de mai multe tipuri. Este capacitatea unor entitati de a lua forme diferite. </br>

Exemplu: </br>
Un exemplu este prin crearea unei clase abstracte. Clasele care o vor mosteni vor trebui sa implementeze metodele virtuale ale clasei parinte. </br>
Daca clasa abstracta ar fi clasa "Persoana" iar constructorul in care atribuim un nume si un cnp este virtual, atunci clasa angajat va avea atribuit in constructor si un loc de munca. </br>
