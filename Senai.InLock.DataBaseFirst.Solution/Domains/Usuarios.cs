﻿using System;
using System.Collections.Generic;

namespace Senai.InLock.DataBaseFirst.Solution.Domains
{
    public partial class Usuarios
    {
        public int UsuarioId { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string TipoUsuario { get; set; }
    }
}
