﻿using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IServicioSeguridad
    {
        public bool ValidarUsuario(Usuario usuario);
    }
}