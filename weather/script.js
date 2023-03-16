let villeChoisie = "paris";

recevoirTemperature(villeChoisie);
recevoirHeure(villeChoisie);

let changerDeVille = document.querySelector('#changer');
changerDeVille.addEventListener('click', () => {
    villeChoisie = prompt('Quelle ville souhaitez-vous voir ?');
    recevoirTemperature(villeChoisie);
    recevoirHeure(villeChoisie);
});


function recevoirTemperature(ville) {
    const url = 'https://api.openweathermap.org/data/2.5/weather?q=' + ville + '&appid=dc8c9152e8adaad0ec8bf635818c0d42&units=metric';
    //console.log(url)

    let requete = new XMLHttpRequest();
    requete.open('GET', url);
    requete.responseType = 'json';
    requete.send();

    requete.onload = function () {
        if (requete.readyState === XMLHttpRequest.DONE) {
            if (requete.status === 200) {
                let reponse = requete.response;
                // console.log(reponse);
                let temperature = reponse.main.temp;
                let ville = reponse.name;
                // console.log(temperature);
                document.querySelector('#temperature_label').textContent = temperature;
                document.querySelector('#ville').textContent = ville;
            }
            else {
                alert('Un problème est intervenu, merci de revenir plus tard.');
            }
        }
    }
}
function recevoirHeure(ville) {
    const url = 'https://timezone.abstractapi.com/v1/current_time/?api_key=c9778d5675ad471a8db9516f993d3383&location=' + ville;

    let requete = new XMLHttpRequest();
    requete.open('GET', url);
    requete.responseType = 'json';
    requete.send();

    requete.onload = function () {
        if (requete.readyState === XMLHttpRequest.DONE) {
            if (requete.status === 200) {
                let reponse = requete.response;
                //console.log(reponse);
                let ville = reponse.datetime;
                let heure = ville.split(" ")
                let horaire = heure[1]
                //console.log(horaire)
                //console.log(ville);
                document.querySelector('#heure').textContent = horaire;
            }
            else {
                alert('Un problème est intervenu, merci de revenir plus tard.');
            }
        }
    }
}



