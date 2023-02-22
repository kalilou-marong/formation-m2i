/**
 * EXERCICE 29 - FOR - Chaine Entiers
 */


let affichage = `<h2>Liste d'entiers chaînés</h2><br><hr>`;



const number = document.querySelector('#nombre');

function chaineEntiers() {
    let nombre = number.value

    affichage += nombre >= 0 && nombre < 10 ? `<p>Vous avez saisi le chiffre <b>${nombre}</b></p>` : nombre > 9 ? `<p>Vous avez saisi le nombre <b>${nombre}</b></p>` : `<p>Veuillez saisir un <b>nombre</b></p>`;

    if (!isNaN(nombre)) {
        affichage += `<p>Voici la liste d'entiers chaînés dont la somme est égale à <b>${nombre}</b>:</p><ul>`;
        let i = 1;

        while (i <= nombre / 2 + 1) {
            let somme = i;
            let chaine = nombre + " = " + i;
            let j = i + 1;
            while (j <= nombre / 2 + 1) {
                somme += j;
                chaine += "+" + j;
                if (somme == nombre) {
                    affichage += `<li>${chaine}</li>`;
                    break;
                }
                else if (somme > nombre)
                    break;
                j++;
            }
            i++;
        }
        affichage += "</ul>";
    }
    else {
        affichage += `<p>Erreur, Veuillez saisir un nombre...</p>`;
    }




    const result = document.querySelector('#result');


    result.innerHTML = affichage;
}