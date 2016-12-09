﻿using Everything.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Everything.Models.Business
{
    public class UsuarioBusiness
    {
        EverythingEntities context = new EverythingEntities();

        public void create(usuario usuario)
        {
            context.usuario.Add(usuario);
            context.SaveChanges();
        }

        public usuario findById(int id)
        {
            return context.usuario.Find(id);
        }

    }
 
}