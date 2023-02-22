/**
 * EXERCICE09 - Les Variables et Opérateurs Arithmetiques - Calcul taux intérêts
 */


const result = document.querySelector('#result');



    let resultat = "";
    let interets = 0;
    let capitalFinal = 0;
    
    const capitalInitial = document.querySelector('#capital');
    const tauxInterets = document.querySelector('#interets');
    const duree = document.querySelector('#epargne');

function calculInteret(){


let cap = capitalInitial.value;
let taux = tauxInterets.value;
let temps = duree.value;
console.log(cap);
console.log(taux);
console.log(temps);


capitalFinal = Math.round(cap * Math.pow(1 + (taux / 100), temps));
interets = Math.round(capitalFinal - cap);


resultat = `Avec un capital initial de <b>${cap}€</b>, placé à <b>${taux}%</b> pendant <b>${temps} année(s)</b>,
<ul>
<li>Le montant total des intérêts s'élévera à <b>${interets}€</b></li>
<li>Le capital final à l'issue sera de <b>${capitalFinal}€</b></li>
</ul>`;


result.innerHTML = `${resultat}`;
}