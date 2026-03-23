# APBD-Cw2-s33646

    

Kohezja
Klasy mają jedną główną odpowiedzialność, te z folderu models opisują dane i obiekty domenowe.
UsersService zarzadza sprzetem, reportsservice ma w sobie raporty itd.

Coupling
Sprzeżenie chciałem ograniczyć robiąc tak, że w jednej klasie którą jest Program.cs bedzie do demnostracji,
logika biznesowa jest w serwisach a reguły nie są jakoś bardzo rozproszone chyba, przynajmniej ja tak to widzę, mam nadzieję ze tak jest.

Odpowiedzialność klas
Zrobiłem wiele klas i uzyłem dziedziczenia dla Laptopa,Projektora, Kamery od Przedmiotow oraz
Student i Pracownik dziedziczy po Uzytkowniku.


Co do podziału kodu, dlaczego tak zrobiłem to po prostu robiłem tak jak było w przykładowym kodzie.
Dziedziczenie można było dobrze użyc dla przedmiotów i osób, wyjątki uznałem, że również tak zrobie jak w przykładowym projekcie zwłaszcza że jest wtedy obsługa błędów jawna i czytelna.

