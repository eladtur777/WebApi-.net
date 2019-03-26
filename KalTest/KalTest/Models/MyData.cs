using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalTest.Models
{
    public static class MyData
    {
        private static IList<Product> products = new List<Product>();
        public static IList<Product> Products {
            get {
                return products;
            }
            set {
                products = value;
                }
        }

        private static IList<Clients> clients = new List<Clients>();
        public static IList<Clients> Clients
        {
            get
            {
                return clients;
            }
            set
            {
                clients = value;
            }
        }

        private static IList<CardHolder> cardHolder = new List<CardHolder>();
        public static IList<CardHolder> CardHolder
        {
            get
            {
                return cardHolder;
            }
            set
            {
                cardHolder = value;
            }
        }

        private static IList<Cal4U> cal4U = new List<Cal4U>();
        public static IList<Cal4U> Cal4U
        {
            get
            {
                return cal4U;
            }
            set
            {
                cal4U = value;
            }
        }

        private static IList<State> state = new List<State>();
        public static IList<State> State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }


        private static IList<ClientsLatestVersion> clientsLatestV = new List<ClientsLatestVersion>();
        public static IList<ClientsLatestVersion> ClientsLatestV
        {
            get
            {
                return clientsLatestV;
            }
            set
            {
                clientsLatestV = value;
            }
        }
    }
}