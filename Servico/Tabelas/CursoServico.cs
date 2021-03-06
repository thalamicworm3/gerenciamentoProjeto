﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL;
using Modelo;

namespace Servico.Tabelas
{
    class CursoServico
    {
        private CursoDAL cursoDAL = new CursoDAL();

        public void GravarCurso(Curso curso)
        {
            cursoDAL.GravarCurso(curso);
        }

        public Curso ObterCursoPorId(long id)
        {
            return cursoDAL.ObterCursoPorId(id);
        }

        public Curso EliminarCursoPorId(long id)
        {
            return cursoDAL.EliminarCursoPorId(id);
        }
    }
}
