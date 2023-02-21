export default class Voiture {

    constructor(modele = "Clio", couleur = "Blanche", reservoir = 45, consommation = 5.5) {
        this.Modele = modele;
        this.Couleur = couleur;
        this.Reservoir = reservoir;
        this.Consommation = consommation;
        this.Carburant = reservoir;
        this.Demarree = false;
        this.EnRoute = false;
    }

    Demarrer() {
        if (this.Demarree === true)
            console.log("Le véhicule est déjà démarré ! Le moteur Tourne déjà");
        else {
            console.log("Le véhicule est démarré, le moteur tourne!");
            this.Demarree = true;
        }
    }

    Arreter() {
        if (this.Demarree === true) {
            console.log("Le véhicule s'arrête");
            this.Demarree = false;
        }
        else {
            console.log("Le véhicule est déjà à l'arrêt!");
        }
    }

    Rouler(distance) {
        if (this.Demarree === true && distance < this.Carburant) {
            console.log('Le vehicule se met en route!')
            this.EnRoute = true
            this.Carburant = reservoir - distance
        }
        else if (distance > this.Carburant) {
            console.log('Il n\'y a pas assez de carburant')
            this.Demarree = false;
        }
        else {
            console.log('Démarrez le vehicule!')
        }
    }

    Stopper() {
        if (this.EnRoute === true) {
            console.log('Le véhicule freine!')
            this.EnRoute = false
        }
        else {
            console.log('Le vehicule est à l\'arrêt')
        }
    }

    Reculer() {
        if (this.EnRoute === false && this.Demarree===true) {
            console.log('Le véhicule fait marche arrière!')
        }
        else if (this.EnRoute === true) {
            console.log('Le vehicule est en train de conduire')
        }
        else {
            console.log('Démarrez le véhicule!')
        }
    }

    Klaxonner() {
        console.log('Le véhicule klaxonne!')
    }

    Refule(litres) {
        if (this.EnRoute===false){
        this.Carburant = this.Carburant + litres
        if(this.Carburant>this.Reservoir){
            this.Carburant=this.Reservoir
            console.log('Vous avez le plein, récupérez votre monnaie !!!')
        }
    }
    else {
        console.log('Arrêtez la voiture!')
    }
    }
}