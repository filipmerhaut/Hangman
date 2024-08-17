Implementujte klasickou hru šibenice, kde uživatel hádá písemna ve skrytém slově. 
Má omezený počet pokusů (např. 10), pokud slovo uhodne než pokusy vyprší, vyhrál. 
Funkce:
- Načtení seznamu vstupních slov z textového souboru
- Výběr náhodného slova ze seznamu
- Zobrazení aktuálního stavu slova s neohodnutými písmeny jak podrtržíky.
- Zadávání písmen hráčem. 
- Zobrazení zbývajících pokusů.
- Zobrazení již zadaných písmen. 
- Vyhodnocení výhry nebo prohry. 

Bonusove:
- volba obtížnosti 
- zobrazení "kresby" přibývajícího oběšence 
- implementuj načtení slov s pomocí interface s možností vybrat jiného "providera" (např. sqlite databázi)
- hrátky s diakritikou
- konfigurační soubor 
- unit testy 
- využití linq


-------------------------
druhá verze zadání (viz email 13.7.2024)

Popis projektu:

Cílem projektu je vytvořit konzolovou hru Hangman (oběšenec) v jazyce C#. Hráč bude hádat skryté slovo po písmenech. Pokud hráč uhodne písmeno správně, odhalí se ve slově na všech odpovídajících pozicích. Pokud hráč tipne špatně, přidá se část k "oběšenci". Hra končí, když hráč uhodne celé slovo nebo když je "oběšenec" kompletní.

 

Funkčnost hry:

Výběr slova: Program náhodně vybere slovo ze seznamu slov.
Zobrazení slova: Na začátku hry se zobrazí skryté slovo jako řada podtržítek (_ _ _).
Vstup hráče: Hráč zadá písmeno, které si myslí, že je ve slově.
Kontrola vstupu: pokud znak není písmeno, program ho upozorní + tento pokus se neodečte z limitu
Kontrola písmena:
Pokud je písmeno ve slově, program odhalí písmeno na všech odpovídajících pozicích.
Pokud písmeno není ve slově, přidá se část těla k "oběšenci".
Výpis již zadaných písmen
Počet pokusů: Hráč má omezený počet špatných pokusů (např. 10).
Konec hry: Hra končí, když hráč buď uhodne celé slovo, nebo udělá příliš mnoho chyb a oběšenec je kompletní.
Opakování hry: Po skončení hry má hráč možnost hrát znovu.
 

Technické požadavky:

Seznam slov:

Seznam slov může být uložen přímo v kódu nebo v externím souboru (např. .txt).

Konzolová aplikace:

Vstupy a výstupy se budou provádět pomocí konzole.

 

Rozšíření (volitelné):

Konfigurační soubor: strukturovaný (xml, csv, json, .config) konfigurační soubor s parametrem pro nastavení maximálního počtu pokusů
Ukládání výsledků: Implementovat ukládání a načítání výsledků her (např. počet výher/proher).
Více kategorií slov: Mít více kategorií slov, ze kterých si hráč může vybrat (např. zvířata, země, jídlo).
"GUI": Postupné "grafické" zobrazení oběšence (pomocí "ASCII art")
 