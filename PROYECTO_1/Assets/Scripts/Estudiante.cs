using UnityEngine;
using System;

namespace packagePersona
{
    [Serializable]

    public class Estudiante : Persona
    {
        private string codeE;
        private string nameECarrera;

        public Estudiante()
        {
        }

        public Estudiante(string codeE, string nameECarrera, string nameP, string mailP, string dirP)
            :base(nameP, mailP, dirP)
        {
            this.codeE = codeE;
            this.nameECarrera = nameECarrera;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string NameECarrera { get => nameECarrera; set => nameECarrera = value; }
    }
}