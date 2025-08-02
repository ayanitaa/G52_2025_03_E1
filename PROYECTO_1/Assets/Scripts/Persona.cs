using UnityEngine;
using System;

namespace packagePersona
{
    [Serializable]
    public class Persona
    {

        private string nameP;
        private string mailP;
        private string dirP;

        public Persona()
        {
        }

        public Persona(string nameP, string mailP, string dirP)
        {
            this.nameP = nameP;
            this.mailP = mailP;
            this.dirP = dirP;
        }
    }
}
