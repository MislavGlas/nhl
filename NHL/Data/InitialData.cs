using NHL.Data;
using NHL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHL.Data
{
    public class InitialData
    {
        public static List<Player> getPlayers(NhlContext context)
        {
            List<Player> players = new List<Player> {
            new Player {
                FirstName = "Sven",
                LastName = "Baertschi",
                Position = "Forward",
                Country = "USA"
            },
            new Player {
                FirstName = "Hendrik",
                LastName = "Sedin",
                Position = "Left Wing",
                Country = "USA"
            },
            new Player {
                FirstName = "John",
                LastName = "Rooster",
                Position = "Right Wing",
                Country = "Canada"
            },
            new Player {
                FirstName = "Bob",
                LastName = "Plumber",
                Position = "Defense",
                Country = "Canada"
            },
        };

            return players;
        }
    }
}