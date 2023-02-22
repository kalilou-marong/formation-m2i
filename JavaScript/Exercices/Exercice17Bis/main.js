/**
 * Exercice17 - IfElse - Calcul Impôts
 */

let tranche1 = 10778,
    tranche2 = 27479,
    tranche3 = 78571,
    tranche4 = 168995,
    nbParts = 0,
    revenuImposable = 0,
    montantImpot = 0;


const result = document.querySelector('#result');


const revenus = document.querySelector('#revenus');
const nbAdulte = document.querySelector('#nbAdulte');
const nbEnfants = document.querySelector('#nbEnfants');

function calculImpots() {
    let argent = revenus.value;
    let adultes = nbAdulte.value;
    let enfants = nbEnfants.value;


    if (enfants <= 2)
        nbParts = adultes + enfants * 0.5;
    else
        nbParts = adultes + enfants - 1;


    revenuImposable = argent / nbParts;

    if (revenuImposable >= tranche1 && revenuImposable < tranche2)
        montantImpot = (revenuImposable - (tranche1 - 1)) * 0.11;
    else if (revenuImposable >= tranche2 && revenuImposable < tranche3)
        montantImpot = (revenuImposable - (tranche2 - 1)) * 0.3 + ((tranche2 - 1) - tranche1) * 0.11;
    else if (revenuImposable >= tranche3 && revenuImposable < tranche4)
        montantImpot = (revenuImposable - (tranche3 - 1)) * 0.41 + ((tranche3 - 1) - tranche2) * 0.3 + ((tranche2 - 1) - tranche1) * 0.11;
    else if (revenuImposable >= tranche4)
        montantImpot = (revenuImposable - (tranche4 - 1)) * 0.45 + ((tranche4 - 1) - tranche3) * 0.41 + ((tranche3 - 1) - tranche2) * 0.3 + ((tranche2 - 1) - tranche1) * 0.11;

    console.log(montantImpot);



    montantImpot *= nbParts;
    console.log(montantImpot);



    result.innerHTML = `Le montant de l'impôt sur le revenu pour un foyer composé de <b>${adultes} adulte(s)</b> et
                    de <b>${enfants} enfant(s)</b>, avec un revenu fiscal de <b>${argent}€</b> 
                    s'élève à <b>${Math.round(montantImpot)}€</b>`;
}