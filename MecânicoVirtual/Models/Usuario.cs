﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MecanicoVirtual.Models
{
    public class Usuario
    {
        public int Id_USER { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }

        public string Senha { get; set; }

    }
}