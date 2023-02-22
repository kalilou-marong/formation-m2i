const result = document.querySelector('#result');
const number = document.querySelector('#number');
let coups = document.querySelector('#coups');

function nombreAleatoire (min,max) {
    
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

let aleatoire = nombreAleatoire(1,50)
console.log(aleatoire)
let nbCoups = 0

function demanderUnNombre () {
    let nombre = number.value
    
    if(nombre > aleatoire && nombre < 50){
        result.innerHTML = 'Le nombre aléatoire est inférieur';
        nbCoups++
    }
    else if (nombre < aleatoire && nombre > 0){
        result.innerHTML = 'Le nombre aléatoire est supérieur';
        nbCoups++
        
    }
    else if (nombre == aleatoire){
        result.innerHTML = 'Félicitations le nombre était bien ' + nombre;
        
    }
    else if (nombre < 0 || nombre > 50){
        alert('Veuillez tapez un nombre entre 1 et 50');
    }
    else {
        alert('Il y a un problème')
    }
    coups.innerHTML = 'Nombre de coups : ' + nbCoups
    
}


