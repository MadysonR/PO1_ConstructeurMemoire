namespace PO1_ConstructeurMemoire
{
    public class Joueur
    {
        private string nom;
        private Equipe equipe;

        public Joueur(string nom, Equipe equipe)
        {
            Nom = nom;
            Equipe = equipe;
        }

        public string Nom { get => nom; set => nom = value; }
        public Equipe Equipe { get => equipe; set => equipe = value; }

        public override string? ToString()
        {
            return Nom + " des " + Equipe.Nom;
        }
    }
    
}
