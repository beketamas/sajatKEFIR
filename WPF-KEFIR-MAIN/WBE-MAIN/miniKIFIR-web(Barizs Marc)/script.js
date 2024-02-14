const adatok = [
    {
        OM_Azonosito: "78655218932",
        Neve: "Szabó Anna",
        ErtesitesiCime: "Budapest, Gellért tér 15.",
        Email: "anna@example.com",
        SzuletesiDatum: "1998-07-19T00:00:00",
        Matematika: 14,
        Magyar: 35
    },
    {
        OM_Azonosito: "15963702584",
        Neve: "Nagy Zsófia",
        ErtesitesiCime: "Debrecen, Szent István utca 8.",
        Email: "zsofia@example.com",
        SzuletesiDatum: "2000-02-22T00:00:00",
        Matematika: 27,
        Magyar: 4
    },
    {
        OM_Azonosito: "12312312300",
        Neve: "senki aki",
        ErtesitesiCime: "Debrecen, Szent István utca 8.",
        Email: "zsofia@example.com",
        SzuletesiDatum: "2000-02-22T00:00:00",
        Matematika: 50,
        Magyar: 50
    },
    {
        OM_Azonosito: "30351479261",
        Neve: "Kovács Máté",
        ErtesitesiCime: "Szeged, Erzsébet körút 45.",
        Email: "mate@example.com",
        SzuletesiDatum: "1995-11-29T00:00:00",
        Matematika: 48,
        Magyar: 15
    },
    {
        OM_Azonosito: "97401028543",
        Neve: "Tóth Bence",
        ErtesitesiCime: "Pécs, Váci utca 33.",
        Email: "bence@example.com",
        SzuletesiDatum: "1997-03-17T00:00:00",
        Matematika: 8,
        Magyar: 47
    },
    {
        OM_Azonosito: "88765031624",
        Neve: "Horváth Eszter",
        ErtesitesiCime: "Székesfehérvár, Bartók Béla út 12.",
        Email: "eszter@example.com",
        SzuletesiDatum: "1996-09-08T00:00:00",
        Matematika: 34,
        Magyar: 7
    },
    {
        OM_Azonosito: "64189075351",
        Neve: "Kiss Attila",
        ErtesitesiCime: "Miskolc, József Attila utca 18.",
        Email: "attila@example.com",
        SzuletesiDatum: "1993-12-05T00:00:00",
        Matematika: 13,
        Magyar: 48
    },
    {
        OM_Azonosito: "18734250658",
        Neve: "Fekete Laura",
        ErtesitesiCime: "Győr, Széchenyi tér 9.",
        Email: "laura@example.com",
        SzuletesiDatum: "1999-06-30T00:00:00",
        Matematika: 2,
        Magyar: 30
    },
    {
        OM_Azonosito: "51698072427",
        Neve: "Bíró Gábor",
        ErtesitesiCime: "Kecskemét, Deák Ferenc utca 21.",
        Email: "gabor@example.com",
        SzuletesiDatum: "1994-10-14T00:00:00",
        Matematika: 9,
        Magyar: 33
    },
    {
        OM_Azonosito: "60157349268",
        Neve: "Mészáros Péter",
        ErtesitesiCime: "Nyíregyháza, Petőfi Sándor utca 26.",
        Email: "peter@example.com",
        SzuletesiDatum: "2001-04-01T00:00:00",
        Matematika: 36,
        Magyar: 21
    },
    {
        OM_Azonosito: "72948316750",
        Neve: "Varga Noémi",
        ErtesitesiCime: "Szombathely, Kossuth Lajos utca 3.",
        Email: "noemi@example.com",
        SzuletesiDatum: "1992-08-18T00:00:00",
        Matematika: 24,
        Magyar: 23
    },
    {
        OM_Azonosito: "84052731649",
        Neve: "Lakatos Dóra",
        ErtesitesiCime: "Veszprém, Ady Endre utca 7.",
        Email: "dora@example.com",
        SzuletesiDatum: "2000-01-03T00:00:00",
        Matematika: 43,
        Magyar: 41
    },
    {
        OM_Azonosito: "85273941680",
        Neve: "Németh Tamás",
        ErtesitesiCime: "Szolnok, Béke tér 14.",
        Email: "tamas@example.com",
        SzuletesiDatum: "1998-05-27T00:00:00",
        Matematika: 5,
        Magyar: 49
    },
    {
        OM_Azonosito: "41593260701",
        Neve: "Orbán Katalin",
        ErtesitesiCime: "Eger, Szabadság utca 32.",
        Email: "katalin@example.com",
        SzuletesiDatum: "1996-02-11T00:00:00",
        Matematika: 37,
        Magyar: 20
    },
    {
        OM_Azonosito: "10486732952",
        Neve: "Simon Balázs",
        ErtesitesiCime: "Debrecen, Király utca 28.",
        Email: "balazs@example.com",
        SzuletesiDatum: "1995-07-07T00:00:00",
        Matematika: 20,
        Magyar: 48
    },
    {
        OM_Azonosito: "92740581643",
        Neve: "Papp Viktória",
        ErtesitesiCime: "Kaposvár, Alkotmány utca 5.",
        Email: "viktor@example.com",
        SzuletesiDatum: "1997-11-24T00:00:00",
        Matematika: 32,
        Magyar: 9
    },
    {
        OM_Azonosito: "10637851454",
        Neve: "Molnár Zoltán",
        ErtesitesiCime: "Szekszárd, Párizsi utca 17.",
        Email: "zoltan@example.com",
        SzuletesiDatum: "1993-01-16T00:00:00",
        Matematika: 3,
        Magyar: 46
    },
    {
        OM_Azonosito: "44025967885",
        Neve: "Fekete Márton",
        ErtesitesiCime: "Pécs, Rákóczi út 13.",
        Email: "marton@example.com",
        SzuletesiDatum: "1992-04-29T00:00:00",
        Matematika: 42,
        Magyar: 31
    },
    {
        OM_Azonosito: "30381425616",
        Neve: "Pál Júlia",
        ErtesitesiCime: "Sopron, Szent Gellért tér 10.",
        Email: "julia@example.com",
        SzuletesiDatum: "1999-09-02T00:00:00",
        Matematika: 49,
        Magyar: 19
    },
    {
        OM_Azonosito: "65082317920",
        Neve: "Takács Orsolya",
        ErtesitesiCime: "Eger, Andrássy út 22.",
        Email: "orsolya@example.com",
        SzuletesiDatum: "1994-06-13T00:00:00",
        Matematika: 31,
        Magyar: 18
    },
    {
        OM_Azonosito: "15374680221",
        Neve: "Kovács Ádám",
        ErtesitesiCime: "Székesfehérvár, Bajnai út 8.",
        Email: "adam@example.com",
        SzuletesiDatum: "1996-08-06T00:00:00",
        Matematika: 18,
        Magyar: 10
    }
];
let aktAdatok = [];
var ossz;
function generateTable(adat) {
    let table = '<table id="adattablazat">';
    table += '<tr id="tr"><th onclick="tablazatotRendez(0)">OM</th><th onclick="tablazatotRendez(1)">Név</th><th onclick="tablazatotRendez(2)">Matek</th><th onclick="tablazatotRendez(3)">Magyar</th><th onclick="tablazatotRendez(4)">Összes</th></tr>';
    adat.forEach(item => {
        table +=
            `<tr><td>${item.OM_Azonosito}</td>
        <td>${item.Neve}</td>
        <td>${item.Matematika}</td>
        <td>${item.Magyar}</td>
        <td>${item.Matematika + item.Magyar}</td></tr>`;
        aktAdatok.push({ "OM_Azonotsito": item.OM_Azonosito,  "Neve": item.Neve ,  "ErtesitesiCime": item.ErtesitesiCime ,  "Email": item.Email ,  "SzuletesiDatum": item.SzuletesiDatum ,  "Matematika": item.Matematika ,  "Magyar": item.Magyar },);
    });
    table += '</table>';
    return table;
}


consttableContainer = document.getElementById('dinamikusTablazatDIV');
consttableContainer.innerHTML = generateTable(adatok);
tablazatotRendez(1);

function tablazatotRendez(n) {
    let thk = document.getElementsByTagName("th");
    MindenFeher();
    thk[n].style.color = "deepskyblue";
    let table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
    table = document.getElementById("adattablazat");
    switching = true;
    dir = "asc";
    while (switching) {
        switching = false;
        rows = table.rows;
        for (i = 1; i < (rows.length - 1); i++) {
            shouldSwitch = false;
            x = rows[i].getElementsByTagName("TD")[n].innerHTML.slice(0, 4);
            y = rows[i + 1].getElementsByTagName("TD")[n].innerHTML.slice(0, 4);
            if (checkForNumber(x) && checkForNumber(y)) {
                if (dir == "asc") {
                    if (Number(x) > Number(y)) {
                        shouldSwitch = true;
                        break;
                    }
                } else if (dir == "desc") {
                    if (Number(x) < Number(y)) {
                        shouldSwitch = true;
                        break;
                    }
                }
            } else {

                if (dir == "asc") {
                    if (x.toLowerCase() > y.toLowerCase()) {
                        shouldSwitch = true;
                        break;
                    }
                } else if (dir == "desc") {
                    if (x.toLowerCase() < y.toLowerCase()) {
                        shouldSwitch = true;
                        break;
                    }
                }
            }
        }
        if (shouldSwitch) {
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
            switchcount++;
        } else {
            if (switchcount == 0 && dir == "asc") {
                dir = "desc";
                switching = true;
            }
        }
    }
}

function checkForNumber(value) {
    var numericValue = parseFloat(value);

    if (!isNaN(numericValue)) {
        return true;
    } else {
        return false;
    }
}

function Listaz() {
    while (aktAdatok.length > 0) {
        aktAdatok.pop();
      }
    let tablazat = document.getElementById('dinamikusTablazatDIV')
    if (document.getElementById("minPontszamID").value > 100) {
        tablazat =
            tablazat.innerHTML = "Nem lehet 100 pontnál több pontja senkinek!";
    } else {
        tablazat.innerHTML = "";
        let minPontszam = document.getElementById("minPontszamID").value;
        let tableE = '<table id="adattablazat">';
        tableE += '<tr id="tr"><th onclick="tablazatotRendez(0)">OM</th><th onclick="tablazatotRendez(1)">Név</th><th onclick="tablazatotRendez(2)">Matek</th><th onclick="tablazatotRendez(3)">Magyar</th><th onclick="tablazatotRendez(4)">Összes</th></tr>';
        adatok.forEach(item => {
            ossz = Number(item.Matematika) + Number(item.Magyar)
            if (Number(minPontszam) <= ossz) {
                tableE +=
                    `<tr><td>${item.OM_Azonosito}</td>
                <td>${item.Neve}</td>
                <td>${item.Matematika}</td>
                <td>${item.Magyar}</td>
            <td>${item.Matematika + item.Magyar}</td></tr>`;
            aktAdatok.push({ "OM_Azonotsito": item.OM_Azonosito,  "Neve": item.Neve ,  "ErtesitesiCime": item.ErtesitesiCime ,  "Email": item.Email ,  "SzuletesiDatum": item.SzuletesiDatum ,  "Matematika": item.Matematika ,  "Magyar": item.Magyar },);
            }
        });
        tableE += '</table>';
        if (tableE.includes("td")) {
            tablazat.innerHTML = tableE;
        }
        else {
            tablazat.innerHTML = "Nincs ilyen ember!"
        }

    }
}

function MindenFeher() {
    let thk = document.getElementsByTagName("th");
    thk[0].style.color = "white";
    thk[1].style.color = "white";
    thk[2].style.color = "white";
    thk[3].style.color = "white";
    thk[4].style.color = "white";
}

function csvATALAKIT(array) {
    let csv = '';
    const keys = Object.keys(array[0]);

    csv += keys.join(';') + '\n';

    array.forEach(item => {
        keys.forEach(key => {
            if (typeof item[key] === 'string' && item[key].includes(';')) {
                csv += `"${item[key]}"` + ';';
            } else {
                csv += item[key] + ';';
            }
        });
        csv += '\n';
    });

    return csv;
}

function downloadCSV(csvData, filename) {
    const blob = new Blob([csvData], { type: 'text/csv;charset=utf-8;' });
    if (navigator.msSaveBlob) { // IE 10+
        navigator.msSaveBlob(blob, filename);
    } else {
        const link = document.createElement('a');
        if (link.download !== undefined) {
            const url = URL.createObjectURL(blob);
            link.setAttribute('href', url);
            link.setAttribute('download', filename);
            link.style.visibility = 'hidden';
            document.body.appendChild(link);
            link.click();
            document.body.removeChild(link);
        }
    }
}

function CSVBE(){
    const csv = csvATALAKIT(aktAdatok);
    downloadCSV(csv, 'export.csv');
}

