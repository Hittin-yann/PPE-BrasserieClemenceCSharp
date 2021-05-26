using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_brasserie
{
    class LesComptes
    {
        private int idCompte;
        private string nomCompte;
        private string prenomCompte;
        private string utilisateurCompte;
        private string pwdCompte;

        public LesComptes(int iC, string nC, string pC, string uC, string pwdC)
        {
            idCompte = iC;
            nomCompte = nC;
            prenomCompte = pC;
            utilisateurCompte = uC;
            pwdCompte = pwdC;
        }

        public int IdCompte
        {

            get => idCompte;
            set => idCompte = value;
        }
        public string NomCompte
        {

            get => nomCompte;
            set => nomCompte = value;
        }
        public string PrenomCompte
        {

            get => prenomCompte;
            set => prenomCompte = value;
        }
        public string UtilisateurCompte
        {

            get => utilisateurCompte;
            set => utilisateurCompte = value;
        }
        public string PwdCompte
        {

            get => pwdCompte;
            set => pwdCompte = value;
        }
    }
}
