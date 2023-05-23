using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BabaVelhaGuardaDigital.Models.Usuarios;

namespace BabaVelhaGuardaDigital.Models.Participantes
{
    public class Participante
    {
        public int ParticipanteId { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public int Gols { get; set; }

        public int Assistencias { get; set; }

        public Usuario usuario { get; set; }
    }
}
