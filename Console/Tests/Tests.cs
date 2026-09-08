using Modeles.Entites;
using Modeles.Entites.Astres;
using Modeles.Entites.Vaisseaux;
using Modeles.Galaxies;
using Modeles.Interfaces;

namespace AppConsole
{
    public static class Tests
    {

        /// <summary>
        /// Exécute les tests demandés dans l'énoncé.
        /// </summary>
        public static void Executer()
        {
            Console.WriteLine("TESTS DU TP");
            Console.WriteLine("--------------------------------");

            // 1. CryptoVaisseau
            var crypto = new CryptoVaisseau(
                "CryptoVaisseau",
                1,
                1);

            Console.WriteLine("\n1. CryptoVaisseau");
            Console.WriteLine(
                $"Message : {crypto.Communiquer("À l'aide !")}");

            crypto.Deplacer(2, 2);

            Console.WriteLine(
                $"Position : ({crypto.PositionX}, {crypto.PositionY})");


            // 2. VerbaAstre
            var verba = new VerbaAstre(
                "VerbaAstre",
                5,
                5);

            Console.WriteLine("\n2. VerbaAstre");
            Console.WriteLine(
                verba.Communiquer("Allo!"));


            // 3. NovaSolara
            var nova = new NovaSolara(
                "NovaSolara",
                10,
                10,
                100);

            nova.Deplacer(-5, 2);

            Console.WriteLine("\n3. NovaSolara");
            Console.WriteLine(
                $"Position : ({nova.PositionX}, {nova.PositionY})");

            Console.WriteLine(
                $"Luminosité : {nova.Luminosite:0.##}");


            // 4. Galaxie
            var galaxie = new Galaxie<Entite>();

            galaxie.AjouterEntite(crypto);
            galaxie.AjouterEntite(verba);
            galaxie.AjouterEntite(nova);

            Console.WriteLine("\n4. Galaxie");
            Console.WriteLine(
                $"Nombre d'entités : {galaxie.Entites.Count}");


            // 5. Entité la plus proche
            var astre = new VerbaAstre(
                "Astre",
                9,
                9);

            var plusProche =
                galaxie.TrouverEntitePlusProche(astre);

            Console.WriteLine("\n5. Entité la plus proche");
            Console.WriteLine(
                plusProche?.Nom ?? "Aucune entité");


            // 6. Vaisseau vitesse 2
            var vaisseau = new Vaisseau(
                "Vaisseau",
                20,
                20,
                2);

            vaisseau.Deplacer(-2, -2);

            Console.WriteLine("\n6. Vaisseau");
            Console.WriteLine(
                $"Position : ({vaisseau.PositionX}, {vaisseau.PositionY})");


            // 7. Liste des communicants
            var communicants = new List<ICommunication>
        {
            crypto,
            verba
        };

            Console.WriteLine("\n7. Communications");

            foreach (var communicant in communicants)
            {
                Console.WriteLine(
                    communicant.Communiquer("Super message !!!"));
            }

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("FIN DES TESTS");
        }
    }
}
