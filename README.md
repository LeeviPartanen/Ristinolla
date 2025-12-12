# Ristinollapeli (Tic-Tac-Toe) - C# Windows Forms App

## Sovelluksen toiminta ja käyttötarkoitus
Tämä sovellus on perinteinen ristinollapeli, joka on rakennettu C#-kielellä käyttäen Windows Forms-kirjastoa. Sovellus tarjoaa kaksinpeli-moodin, jossa kaksi pelaajaa voivat pelata ristinollaa samalla tietokoneella.

Pelin tarkoituksena on täyttää 3x3-ruudun pelilauta omilla merkeillään ("X" tai "O") siten, että pelaaja saa kolme peräkkäistä merkkiä joko vaakasuoraan, pystysuoraan, tai nurkasta nurkkaan. Pelissä on mukana pistelaskuri, joka pitää kirjaa kummankin pelaajan voitoista, ja peli voidaan nollata milloin tahansa, jolloin peli alkaa alusta.

## Vuokaavio
![Uusi vuokaavio](https://github.com/user-attachments/assets/0234ccf7-6ac4-4e3c-928e-8e77a62d265d)

## Kuvakaappaukset
![image](https://github.com/user-attachments/assets/a4737467-23f8-4863-9974-8873514b4995)
- Pelilaudan alkuperäinen näkymä

![image](https://github.com/user-attachments/assets/d73cb5db-a29f-4868-986f-1e4eee667f47)
- Pelin aikana napit, joissa näkyy "X" ja "O"

![image](https://github.com/user-attachments/assets/193201b8-3ff7-48b6-9cd1-6ec53f013116)
- Voittajan ilmoittaminen

## Koodin pääkohdat
### Pelilogiikka
Pelin logiikka perustuu nappeihin, joita pelaajat klikkalevat vuorotellen. Pelissä on kaksi pääfunktiota, jotka huolehtivat napin klikkaamisesta ja voittajan tarkistamisesta.

![image](https://github.com/user-attachments/assets/6098698c-9473-4074-9851-b053a030e8d2)


### Voittotarkistus
Pelissä tarkistetaan, onko jollain pelaajalla kolme peräkkäistä merkkiä pelilaudalla. Tämä tehdään Check()-metodilla.

![image](https://github.com/user-attachments/assets/ae55d8cd-13d9-4dd3-bc24-16b2a4f05641)


### Pelin nollaus
Pelin voi nollata milloin tahansa painamalla "Pelaa uudestaan"-nappia. Tämä palauttaa pelilaudan alkuperäiseen tilaan ja nollaa pelin edistymisen:

![image](https://github.com/user-attachments/assets/84d85e08-d0ff-431c-83dd-18f18294c59c)



## Jatkokehitysudeat
- **AI-pelaaja**: Yksinpelitila, jossa pelaaja voi pelata tekoälyä vastaan.
- **Ajastin**: Ajastin, joka rajoittaa pelaajan vuoron keston.
- **Erilaisia teemoja**: Käyttäjä voi valita eri visuaalisia teemoja pelilaudalle.
- **Pisteiden tallennus**: Lisätä mahdollisuus tallentaa ja ladata pistetilanteet useamman pelin ajalta.
