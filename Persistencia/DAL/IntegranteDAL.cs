﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Contexts;
using Modelo;
using System.Data.Entity;

namespace Persistencia.DAL
{
    class IntegranteDAL
    {
        private EFContext context = new EFContext();

        public void CriarIntegrante(Integrante integrante)
        {
            if (integrante.IntegranteId == null)
            {
                context.integrantes.Add(integrante);
            }
            else
            {
                context.Entry(integrante).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public Integrante ObterIntegrantePorId(long id)
        {
            return context.integrantes.Where(i => i.IntegranteId == id).Include(p => p.projeto).Include(u => u.usuarios).Include(c => c.cargo).First();
        }

        public Integrante EliminarIntegrante(long id)
        {
            Integrante integrante = ObterIntegrantePorId(id);
            context.integrantes.Remove(integrante);
            context.SaveChanges();
            return integrante;
        }
    }
}
