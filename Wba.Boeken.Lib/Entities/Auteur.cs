﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Wba.Boeken.Lib.Entities
{
    [Table("auteurs")]
    public class Auteur
    {
        [ExplicitKey]
        public string Id { get; set; }
        public string Naam { get; set; }

        public Auteur()
        {
            Id = Guid.NewGuid().ToString();
        }
        public Auteur(string naam)
        {
            Id = Guid.NewGuid().ToString();
            Naam = naam;
        }
        public Auteur(string id, string naam)
        {
            Id = id;
            Naam = naam;
        }
        public override string ToString()
        {
            return $"{Naam}";
        }
    }
}
