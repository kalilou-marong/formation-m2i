﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    public class Hotel
    {
        private string nom;
        private List<Client> clients;
        private List<Chambre> chambres;
        private List<Reservation> reservations;

        public string Nom { get => nom; set => nom = value; }
        public List<Client> Clients { get => clients; set => clients = value; }
        public List<Chambre> Chambres { get => chambres; set => chambres = value; }
        public List<Reservation> Reservations { get => reservations; set => reservations = value; }

        public Hotel(string nom)
        {
            Nom = nom;
            //Créer et ajouter des chambres => A faire
            Chambres = new List<Chambre>();
            //Un objet Random
            Random r = new Random();
            for(int i=1; i <= 30; i++)
            {
                Chambre chambre = new Chambre(r.Next(50,200), r.Next(1,4));
                Chambres.Add(chambre);
            }

            Reservations = new List<Reservation>();
            Clients = new List<Client>();
        }

        //Méthode pour créer et ajouter un Client
        public Client CreerClient(string nom, string prenom, string telephone)
        {
            //A Faire
            Client client = new Client(nom, prenom, telephone);
            Clients.Add(client);
            return client;
        }

        //Méthode pour Créer une réservation
        public Reservation CreerReservation(Client client, List<Chambre> chambres)
        {
            Reservation reservation = new Reservation(client);
            chambres.ForEach(c =>
            {
                //Ajoute la chambre dans la reservation
                reservation.Chambres.Add(c);
                c.Statut = StatutChambre.Occupe;
            });
            Reservations.Add(reservation);
            return reservation;
        }

        public Reservation CreerReservation(Client client, int nbPersonne)
        {
            Reservation reservation = new Reservation(client);
            int nbPlaces = nbPersonne;
            Chambres.ForEach(c =>
            {
                if (c.Statut == StatutChambre.Libre && nbPlaces > 0)
                {
                    reservation.Chambres.Add(c);
                    c.Statut = StatutChambre.Occupe;
                    nbPlaces -= c.Nb_personne;
                }
            });
            Reservations.Add(reservation);
            return reservation;
        }

        public bool AnnulerReservation(int numeroReservation)
        {
            //A faire
            //1 Rechercher la reservation
            Reservation reservation = Reservations.FirstOrDefault(r => r.NumeroReservation == numeroReservation);
            if(reservation != null)
            {
                //2 Modifier le statut de la reservation
                if(reservation.Statut != StatutReservation.Annule)
                {
                    reservation.Statut = StatutReservation.Annule;
                    reservation.Chambres.ForEach(c =>
                    {
                        c.Statut = StatutChambre.Libre;
                    });
                    return true;
                }
            }
            return false;
        }

        //public bool ModifierEtatChambre(int numeroChambre, StatutChambre nouveauStatut)
        //{
        //    return false;
        //}
    }
}
