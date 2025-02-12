let datum = new Date();
let Ev = datum.getFullYear();
let Ho = datum.getMonth();
let Nap = datum.getDate();
let NapSorsz = datum.getDay();

//Szökőév-e az aktuális év
function Szokoev(Ev){
    AzE = false;
    /* Szökőév, ha egy év maradék nélkül osztható 4-el, de nem osztható maradék nélkül 100-al
       A 100-al maradék nélkül osztható évek akkor szökőévek, ha 400-al is maradék nélkül
       oszthatók --> https://hu.wikipedia.org/wiki/Szökőév */
    if((Ev%4 == 0) && (Ev%100 != 0)){
        AzE = true;                 //szökőév
    } else if(Ev%400 == 0){
        AzE = true;                 //szököőv
    }
    return AzE;
}

/*  Hónap névnapjainak meghatározása */  
function Havinev(Ev,Ho,Nap) {  
    let SzokoevE = Szokoev(Ev);
    if (Ho == 0){ 
        let Napok = ["Fruzsina", "Ábel", "Genovéva, Benjámin", "Titusz, Leona", "Simon", "Boldizsár",
        "Attila, Ramóna", "Gyöngyvér", "Marcell", "Melánia", "Ágota", "Ernő", "Veronika", "Bódog",
        "Lóránt, Loránd", "Gusztáv", "Antal, Antónia", "Piroska", "Sára, Márió", "Fábián, Sebestyén", 
        "Ágnes", "Vince, Artúr", "Zelma, Rajmund", "Timót", "Pál", "Vanda, Paula", "Angelika",
        "Károly, Karola", "Adél", "Martina, Gerda", "Marcella"];
        return Napok[Nap-1];
    }  
    if (Ho == 1){
        /*Szökőévben február 24-29 közt eltérőek a névnapok, 24-n pedig nincs névnap*/
        if (SzokoevE == false){ 
            let Napok = ["Ignác", "Karolina, Aida", "Balázs", "Ráhel, Csenge", "Ágota, Ingrid",
            "Dorottya, Dóra", "Tódor, Rómeó", "Aranka", "Abigél, Alex", "Elvira", "Bertold, Marietta",
            "Lívia, Lídia", "Ella, Linda", "Bálint", "Kolos, Georgina", "Julianna, Lilla", "Donát",
            "Bernadett", "Zsuzsanna", "Aladár, Álmos", "Eleonóra", "Gerzson", "Alfréd", "Mátyás",
            "Géza", "Edina", "Ákos, Bátor", "Elemér"];
            return Napok[Nap-1];
        } else { 
            let Napok = ["Ignác", "Karolina, Aida", "Balázs", "Ráhel, Csenge", "Ágota, Ingrid",
            "Dorottya, Dóra", "Tódor, Rómeó", "Aranka", "Abigél, Alex", "Elvira", "Bertold, Marietta",
            "Lívia, Lídia", "Ella, Linda", "Bálint", "Kolos, Georgina", "Julianna, Lilla", "Donát",
            "Bernadett", "Zsuzsanna", "Aladár, Álmos", "Eleonóra", "Gerzson", "Alfréd", "Szökőnap",
            "Mátyás", "Géza", "Edina", "Ákos, Bátor", "Elemér"]; 
            return Napok[Nap-1];
        }  
    }
    if (Ho == 2){ 
        let Napok = ["Albin", "Lujza", "Kornélia", "Kázmér", "Adorján, Adrián", "Leonóra, Inez", "Tamás", 
        "Zoltán", "Franciska, Fanni", "Ildikó", "Szilárd", "Gergely", "Krisztián, Ajtony", "Matild",
        "Kristóf", "Henrietta", "Gertrúd, Patrik", "Sándor, Ede", "József, Bánk", "Klaudia", "Benedek",
        "Beáta, Izolda", "Emoke", "Gábor, Karina", "Irén, Irisz", "Emánuel", "Hajnalka", "Gedeon, Johanna",
        "Auguszta", "Zalán", "Árpád"]; 
        return Napok[Nap-1];
    }  
    if (Ho == 3){ 
        let Napok = ["Hugó", "Áron", "Buda, Richárd", "Izidor", "Vince", "Vilmos, Bíborka", "Herman",
        "Dénes", "Erhard", "Zsolt", "Leó, Szaniszló", "Gyula", "Ida", "Tibor", "Anasztázia, Tas", "Csongor",
        "Rudolf", "Andrea, Ilma", "Emma", "Tivadar", "Konrád", "Csilla, Noémi", "Béla", "György", "Márk",
        "Ervin", "Zita, Mariann", "Valéria", "Péter", "Katalin, Kitti"];
        return Napok[Nap-1];
    }  
    if (Ho == 4){ 
        let Napok = ["Fülöp, Jakab", "Zsigmond", "Tímea, Irma", "Mónika, Flórián", "Györgyi", "Ivett, Frida",
        "Gizella", "Mihály", "Gergely", "Ármin, Pálma", "Ferenc", "Pongrác", "Szervác, Imola", "Bonifác", 
        "Zsófia, Szonja", "Mózes, Botond", "Paszkál", "Erik, Alexandra", "Ivó, Milán", "Bernát, Felícia",
        "Konstantin", "Júlia, Rita", "Dezső", "Eszter, Eliza", "Orbán", "Fülöp, Evelin", "Hella", "Emil, Csanád",
        "Magdolna", "Janka, Zsanett", "Angéla, Petronella"];
        return Napok[Nap-1];
    }  
    if (Ho == 5){ 
        let Napok = ["Tünde", "Kármen, Anita", "Klotild", "Bulcsú", "Fatime", "Norbert, Cintia", "Róbert", "Medárd",
        "Félix", "Margit, Gréta", "Barnabás", "Villo", "Antal, Anett", "Vazul", "Jolán, Vid", "Jusztin", "Laura, Alida",  
        "Arnold, Levente", "Gyárfás", "Rafael", "Alajos, Leila", "Paulina", "Zoltán", "Iván", "Vilmos", "János, Pál",
        "László", "Levente, Irén", "Péter, Pál", "Pál"];
        return Napok[Nap-1];
    }  
    if (Ho == 6){ 
        let Napok = ["Tihamér, Annamária", "Ottó", "Kornél, Soma", "Ulrik", "Emese, Sarolta", "Csaba", "Appolónia",
        "Ellák", "Lukrécia", "Amália", "Nóra, Lili", "Izabella, Dalma", "Jeno", "Örs, Stella", "Henrik, Roland",
        "Valter", "Endre, Elek", "Frigyes", "Emília", "Illés", "Dániel, Daniella", "Magdolna", "Lenke", "Kinga, Kincső",
        "Kristóf, Jakab", "Anna, Anikó", "Olga, Liliána", "Szabolcs", "Márta, Flóra", "Judit, Xénia", "Oszkár"];
        return Napok[Nap-1];
    }  
    if (Ho == 7){ 
        let Napok = ["Boglárka", "Lehel", "Hermina", "Domonkos, Dominika", "Krisztina", "Berta, Bettina", "Ibolya",
        "László", "Emöd", "Lörinc", "Zsuzsanna, Tiborc", "Klára", "Ipoly", "Marcell", "Mária", "Ábrahám", "Jácint", "Ilona",
        "Huba", "István", "Sámuel, Hajna", "Menyhért, Mirjam", "Bence", "Bertalan", "Lajos, Patrícia", "Izsó", "Gáspár",
        "Ágoston", "Beatrix, Erna", "Rózsa", "Erika, Bella"]; 
        return Napok[Nap-1];
    }  
    if (Ho == 8){ 
        let Napok = ["Egyed, Egon", "Rebeka, Dorina", "Hilda", "Rozália", "Viktor, Lőrinc", "Zakariás", "Regina",
        "Mária, Adrienn", "Ádám", "Nikolett, Hunor", "Teodóra", "Mária", "Kornél", "Szeréna, Roxána", "Enikő, Melitta",
        "Edit", "Zsófia", "Diána", "Vilhelmina", "Friderika", "Máté, Mirella", "Móric", "Tekla", "Gellért, Mercédesz",
        "Eufrozina, Kende", "Jusztina", "Adalbert", "Vencel", "Mihály", "Jeromos"];
        return Napok[Nap-1];
    }  
    if (Ho == 9){ 
        let Napok = ["Malvin", "Petra", "Helga", "Ferenc", "Aurél", "Brúnó, Renáta", "Amália", "Koppány", "Dénes", 
        "Gedeon", "Brigitta, Gitta", "Miksa", "Kálmán, Ede", "Helén", "Teréz", "Gál", "Hedvig", "Lukács", "Nándor", 
        "Vendel", "Orsolya", "Előd", "Gyöngyi", "Salamon", "Blanka, Bianka", "Dömötör", "Szabina", "Simon, Szimonetta", 
        "Nárcisz", "Alfonz", "Farkas"];
        return Napok[Nap-1];
    }  
    if (Ho == 10){ 
        let Napok = ["Marianna", "Achilles", "Győző", "Károly", "Imre", "Lénárd", "Rezső", "Zsombor", "Tivadar", "Réka",
        "Márton", "Jónás, Renátó", "Szilvia", "Aliz", "Albert, Lipót", "Ödön", "Hortenzia, Gergő", "Jenő", 
        "Erzsébet, Zsóka", "Jolán", "Olivér", "Cecília", "Kelemen, Klementina", "Emma", "Katalin", "Virág", "Virgil",
        "Stefánia", "Taksony", "András, Andor"];
        return Napok[Nap-1];
    }  
    if (Ho == 11){ 
        let Napok = ["Elza", "Melinda, Vivien", "Ferenc, Olívia", "Borbála, Barbara", "Vilma", "Miklós", "Ambrus",
        "Mária", "Natália", "Judit", "Árpád", "Gabriella", "Luca, Otília", "Szilárda", "Valér", "Etelka, Aletta", 
        "Lázár, Olimpia",  "Auguszta", "Viola", "Teofil", "Tamás", "Zéno", "Viktória", "Ádám, Éva", "Eugénia", 
        "István", "János", "Kamilla", "Tamás, Tamara", "Dávid", "Szilveszter"]; 
        return Napok[Nap-1];
    }  
    
}  
 
function Honev(Ho){
    let Month = ["január", "február", "március", "április", "május", "június", "július", 
    "augusztus", "szeptember", "október", "november", "december"];
    return Month[Ho];
}
function Week(Day){
    let HetNapjai = ["vasárnap","hétfő","kedd","szerda","csütörtök","péntek","szombat"];
    return HetNapjai[Day];
}

document.getElementById("nevnap").innerHTML = Ev+". "+Honev(Ho)+" "+Nap+"., "+Week(NapSorsz)+
                                              "<br><span>"+Havinev(Ev,Ho,Nap)+"</span> névnapja van";




