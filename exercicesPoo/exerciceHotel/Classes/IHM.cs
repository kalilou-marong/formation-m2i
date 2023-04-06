﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    public class IHM
    {

        private Hotel hotel;
        private string choix;

        public IHM()
        {

        }

        public void Start()
        {
            //Action création de l'hotel, 
            //On demande le nom de l'hotel pour le créer
            ActionCreationHotel();
            do
            {
                try { 
                Menu();
                Console.Write("Votre choix : ");
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                        ActionCreationClient();
                        break;
                    case "2":
                        ActionAfficherListeClients();
                        break;
                    case "3":
                        ActionAfficherListeReservationsClient();
                        break;
                    case "4":
                        ActionAjouterUneReservation();
                        break;
                    case "5":
                        ActionAnnulerReservation();
                        break;
                    case "6":
                        ActionAfficherListeReservations();
                        break;
                }
                }
                catch (Exception ex) { }
            }
            while (choix != "0");
            
        }

        
        private void ActionCreationHotel()
        {
            Console.Write("Merci de saisir le nom de l'hôtel : ");
            string nom = Console.ReadLine();
            hotel = new Hotel(nom);
            Console.WriteLine("Hôtel est créé");
            Continuer();
        }

        //Menu des actions
        private void Menu()
        {
            Console.WriteLine("1 --- Ajouter un client ");
            Console.WriteLine("2 --- Afficher la liste des clients ");
            Console.WriteLine("3 --- Afficher les réservations d'un client ");
            Console.WriteLine("4 --- Ajouter une réservation ");
            Console.WriteLine("5 --- Annuler une réservation ");
            Console.WriteLine("6 --- Afficher les réservations ");
        }

        private void ActionCreationClient()
        {
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le prénom : ");
            string prenom = Console.ReadLine();
            Console.Write("Merci de saisir le Téléphone : ");
            string telephone = Console.ReadLine();
            Client client = hotel.CreerClient(nom, prenom, telephone);
            Console.WriteLine("Client créé avec l'id " + client.Id);
            Continuer();
        }

        private void ActionAfficherListeClients()
        {
            Console.WriteLine("=====Liste des clients=====");
            hotel.Clients.ForEach(c =>
            {
                Console.WriteLine($"Id: {c.Id}, Nom: {c.Nom}, Prénom: {c.Prenom}, Téléphone: {c.Telephone}");
            });
            Continuer();
        }

        private void ActionAfficherListeReservationsClient()
        {
            Console.WriteLine("=====Liste des réservations d'un client =====");
            Console.Write("Id du client : ");
            int id = Convert.ToInt32(Console.ReadLine());
            hotel.Reservations.Where(r => r.Client.Id == id).ToList().ForEach(r =>
            {
                Console.WriteLine($"Id : {r.NumeroReservation}, Statut: {r.Statut}, Nombre Chambres : {r.Chambres.Count}");
            });
            Continuer();
        }

        private void ActionAjouterUneReservation()
        {
            Console.WriteLine("=====Ajouter une reservation=====");
            Client client = ActionRechercherClient();
            if(client != null)
            {
                Console.Write("Merci de saisir le nombre de personne : ");
                int nbPersonne = Convert.ToInt32(Console.ReadLine());
                Reservation reservation = hotel.CreerReservation(client, nbPersonne);
                Console.WriteLine("Réservation ajoutée avec le numéro : " + reservation.NumeroReservation);
            }
            else
            {
                Console.WriteLine("Aucun client avec cet id");
            }
            Continuer();
        }

        private void ActionAnnulerReservation()
        {
            Console.WriteLine("=====Annuler une reservation=====");
            Console.Write("Numéro de réservation : ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if(hotel.AnnulerReservation(numero))
            {
                Console.WriteLine("La réservation a été annulée");
            }
            else
            {
                Console.WriteLine("Erreur d'annulation");
            }
            Continuer();
        }

        private void ActionAfficherListeReservations()
        {
            Console.WriteLine("=====Liste des réservations =====");
            hotel.Reservations.ForEach(r =>
            {
                Console.WriteLine($"Id : {r.NumeroReservation}, Statut: {r.Statut}, Nombre Chambres : {r.Chambres.Count}");
            });
            Continuer();
        }

        private Client ActionRechercherClient()
        {
            Console.Write("Merci de saisir l'id du client : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Client client = hotel.Clients.FirstOrDefault(c => c.Id == id);
            return client;
        }


        private void Continuer()
        {
            Console.Write("Une touche pour continuer...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
