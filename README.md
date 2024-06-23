# ASP.NET Core Web App (MVC) Project

## Način izrade zadatka

Unutar Microsoft Visual Studia je kreiran novi ASP.NET Core Web App (MVC) projekt. Projekt je povezan s bazom podataka korištenjem Entity Framework-a i sadrži jedan kontroler `Product` koji upravlja sa korisničkim zahtjevima vezanim uz prikaz proizvoda. Svaka akcija unutar kontrolera vraća `View` objekt s parametrima proizvoda koji će se prikazati na web stranici. Za svaku akciju je izrađena View datoteka koja definira kako će se podaci prikazivati unutar web preglednika. Obavljeni su samo osnovni zahtjevi zadatka.

## Tehnologije potrebne za izvođenje programa

- Microsoft Visual Studio
- Microsoft SQL Server Management Studio (SSMS)
- Preglednik (Chrome)

## Postavljanje baze

1. Unutar `appsettings.json` datoteke potrebno je promijeniti naziv servera na neki od servera koji se nalaze na vašem računalu:
    ```json
    "DefaultConnection": "Server=[Naziv_servera];Database=KingDb;Trusted_Connection=True;TrustServerCertificate=True""
    ```
2. Unutar Visual Studia potrebno je otvoriti Package Manager Console (Tools -> NuGet Package Manager -> Package Manager Console) i unesti komandu:
    ```shell
    update-database
    ```
3. Unutar SSMS-a se je potrebno povezati na server koji ste naveli u `appsettings.json` i trebala bi biti vidljiva baza podataka `KingDb`, što znači da je postavljanje baze uspješno.

## Pokretanje programskog rješenja

1. Unutar Visual Studia je potrebno postaviti Debugging sa HTTP protokolom i pokrenuti program.
2. Otvorit će se početna web stranica sa izbornikom na kojem se nalazi poveznica na stranicu sa proizvodima.
3. Kada se otvori stranica sa proizvodima, pozvat će se kontroler `Product` i akcija `Index` koja će dohvatiti sve proizvode iz baze podataka.
4. Na stranici s proizvodima se još nalaze dvije forme (search i filter), te nazivi svakog proizvoda koji unutar tablice predstavljaju gumbe za prikaz njihovih detalja.
5. Unosom teksta u search polje (npr. Product2) i pritiskom na gumb s povećalom prikazati će se svi oni proizvodi koji sadrže uneseni tekst u svom nazivu.
6. Unosom kategorije (npr. Toy ili War), te minimalnih i maksimalnih vrijednosti cijena prikazati će se proizvodi koji odgovaraju unesenim parametrima. 
