/**
 * EXERCICE 25 - FOR - Chaine Entiers
 */

let affichage = `<h2>Liste d'entiers chaînés</h2><br><hr>`;


const nombre = document.querySelector('#nombre');

function chaineEntiers() {
    let number = nombre.value
    affichage += number >= 0 && number < 10 ?
        `<p>Vous avez saisi le chiffre <b>${number}</b></p>`
        :
        number > 9 ? `<p>Vous avez saisi le nombre <b>${number}</b></p>`
            :
            `<p>Veuillez saisir un <b>nombre</b></p>`;

    if (!isNaN(number)) {
        affichage += `<p>Voici la liste d'entiers chaînés dont la somme est égale à <b>${number}</b>:</p><ul>`;

        for (let i = 1; i <= number / 2 + 1; i++) {
            let somme = i;

            let chaine = `${number} = ${i}`;
            console.log(chaine);
            console.log(somme);
            for (let j = i + 1; j <= number / 2 + 1; j++) {
                somme += j;
                chaine += "+" + j;
                console.log(chaine);
                console.log(somme);
                if (somme == number) {
                    affichage += `<li>${chaine}</li>`;
                    break;
                }
                else if (somme > number)
                    break;
            }
        }
        affichage += "</ul>";
    }



    const result = document.querySelector('#result');

    result.innerHTML = affichage;
}