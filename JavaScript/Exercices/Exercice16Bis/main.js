/**
 * Exercice16 - IfElse - Prime de licenciement
 */

let indemnite = 0;


const result = document.querySelector('#result');


const salaire = document.querySelector('#salaire');
const anciennete = document.querySelector('#anciennete');
const age = document.querySelector('#age');


function calculPrime() {
    let argent = salaire.value;
    let temps = anciennete.value;
    let old = age.value;

    if (temps >= 1 && temps <= 10) {
        indemnite += temps * argent / 2;
    }
    else if (temps > 10) {
        indemnite += 10 * argent / 2;
        indemnite += (temps - 10) * argent;
    }

    if (temps >= 1 && old > 45) {
        indemnite += (old < 50) ? 2 * argent : 5 * argent;
    }



    result.innerHTML = `Le montant de l'indemnité pour un salarié de <b>${old} ans</b> et
    avec <b>${temps}</b> années d'ancienneté s'élève à <b>${indemnite}€</b>`;
}