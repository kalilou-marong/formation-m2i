/*
 * Les Classes en Javascript
 */

import Voiture from './js/Voiture.js';

/*let voitureDeNicolas = new Voiture();

console.log(voitureDeNicolas);

voitureDeNicolas.Demarrer();
voitureDeNicolas.Demarrer();
voitureDeNicolas.Demarrer();
voitureDeNicolas.Demarrer();

let voitureDeJeanne = new Voiture("C3", "Bleu", 50, 5);

console.log(voitureDeJeanne);

voitureDeJeanne.Demarrer();
voitureDeJeanne.Demarrer();
voitureDeJeanne.Demarrer();
voitureDeJeanne.Demarrer();*/

const result = document.querySelector('#result')
let voitureDeKalilou = new Voiture("twingo", 'noire', 45, 5);

console.log(voitureDeKalilou);

voitureDeKalilou.Demarrer();
voitureDeKalilou.Rouler();
voitureDeKalilou.Stopper();
voitureDeKalilou.Klaxonner();
voitureDeKalilou.Arreter();
voitureDeKalilou.Rouler(14);
//voitureDeKalilou.Reculer();
voitureDeKalilou.Refule(10);


