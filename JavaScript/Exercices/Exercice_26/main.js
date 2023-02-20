const result = document.querySelector('#result');

let note1 = prompt('Quelle est la note ?');
note1 = parseInt(note1)
let note2 = prompt('Quelle est la note ?');
note2 = parseInt(note2)
let note3 = prompt('Quelle est la note ?');
note3 = parseInt(note3)
let note4 = prompt('Quelle est la note ?');
note4 = parseInt(note4)
let note5 = prompt('Quelle est la note ?');
note5 = parseInt(note5)

let tableau = [note1, note2, note3, note4, note5];
let plus = 0
let moins = 21
let moyenne = (note1 + note2 + note3 + note4 + note5) / 5


for (i = 1; i <= 5; i++) {
    result.innerHTML += '<p>En note ' + i + ', vous avez saisi ' + tableau[i - 1] + ' /20<p>';
}
for (j = 0; j < tableau.length; j++) {
    if (tableau[j] > plus) {
        plus = tableau[j]
    }
    if (tableau[j] < moins) {
        moins = tableau[j]
    }
}

result.innerHTML += '<p> La meilleure note est de ' + plus + '/20 <p>'
result.innerHTML += '<p> La moins bonne note est de ' + moins + '/20<p>'
result.innerHTML += '<p> La moyenne des notes est de ' + moyenne / 5 + '/20<p>'
console.log(moyenne)