using exerciceChaise.Classes;

Chaise ChaiseBlanche = new Chaise(4, "bois", "blanche");
Chaise ChaiseNoire = new Chaise(2, "métal", "noire");
Chaise ChaiseBleue = new Chaise(6, "plastique", "bleue");

Console.WriteLine($"Je suis une chaise, avec {ChaiseBlanche.Nbpieds} en {ChaiseBlanche.Materiaux} de couleur {ChaiseBlanche.Couleur}.");
Console.WriteLine($"Je suis une chaise, avec {ChaiseNoire.Nbpieds} en {ChaiseBlanche.Materiaux} de couleur {ChaiseBlanche.Couleur}.");
Console.WriteLine($"Je suis une chaise, avec {ChaiseBleue.Nbpieds} en {ChaiseBlanche.Materiaux} de couleur {ChaiseBlanche.Couleur}.");


