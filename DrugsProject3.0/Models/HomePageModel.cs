﻿using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class HomePageModel
    {
        public IBL Bl { get; set; }
        public HomePageModel()
        {
            Bl = new BlObject();
        }

        public User GetUser(string id)
        {
             return Bl.GetUser(id);
        }
    }
}