﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YumoGameProject
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalityId { get; set; }

        public List<Game> ownedGames = new List<Game>();
    }
}
