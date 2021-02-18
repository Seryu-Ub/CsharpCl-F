using System;
using System.Diagnostics;

namespace Seryu
{
    class Program
    {
        static void Main()
        {

            void Reciproque()
            {
                Console.Title = "SeryuApp | Réciproque du théorème de Pythagore";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"/ Réciproque du théorème de Pythagore \");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Ne pas mettre de . ou de ; (Exemple 2,45)" + Environment.NewLine);

                Console.WriteLine("Veuillez saisir la valeur de l'hypoténuse :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double hy = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Veuillez saisir la valeur d'un des autres côtés :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double cote1 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Veuillez saisir la valeur du dernier côté :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double cote2 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                double result1 = (cote1 * cote1);
                double result2 = (cote2 * cote2);
                double hy2 = (hy * hy);

                double result3 = (result1 + result2);

                if (result3 == hy2)
                {
                    Console.WriteLine(Environment.NewLine + @"Donc, d'après la réciproque du théorème de Pythagore, on peut affirmé que le réctangle et réctangle en 'x'" + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Le triangle n'est pas réctangle" + Environment.NewLine);
                }

                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();
            }

            void Theoreme()
            {
                Console.Title = "SeryuApp | Théorème de Pythagore";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"/ Théorème de Pythagore \");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Ne pas mettre de . ou de ; (Exemple 2,45)" + Environment.NewLine);

                double resultat;

                Console.WriteLine("Veuillez saisir la valeur d'un des autres côtés :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double cote1 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Veuillez saisir la valeur du dernier côté :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double cote2 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                double result1 = (cote1 * cote1);
                double result2 = (cote2 * cote2);

                resultat = (result1 + result2);

                Console.WriteLine(Environment.NewLine + "Voici le resultat : Racine carré de " + resultat + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();
            }

            void Moyenne()
            {
                Console.Title = "SeryuApp | Calculer une moyenne";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"/ Calculer une moyenne \");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Ne pas mettre de . ou de ; (Exemple 2,45)" + Environment.NewLine);
                Console.WriteLine("Pour le nombre de donnée ne pas mettre un nombre à virgule" + Environment.NewLine);

                Console.WriteLine("Veuillez saisir le nombre de donnée :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double ns = double.Parse(Console.ReadLine());

                Console.ResetColor();

                if (ns == 0) return;

                int nombre = 0;

                double resultat = 0;

                while (nombre != ns)
                {
                    Console.WriteLine(Environment.NewLine + "Insérer la nouvelle donnée :" + Environment.NewLine);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    resultat = resultat + double.Parse(Console.ReadLine());
                    Console.ResetColor();
                    nombre++;
                }

                resultat = resultat / ns;

                Console.WriteLine(Environment.NewLine + "La moyenne de toutes ces données est " + resultat + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();
            }

            void Triangle()
            {
                Console.Title = "SeryuApp | L'aire d'un triangle";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"/ Calculer l'aire d'un triangle \");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Ne pas mettre de . ou de ; (Exemple 2,45)" + Environment.NewLine);

                double aire;

                Console.WriteLine("Veuillez saisir la valeur de la base :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double based1 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Veuillez saisir la valeur de la hauteur :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double ha = double.Parse(Console.ReadLine());
                Console.ResetColor();

                aire = (based1 * ha / 2);

                Console.WriteLine(Environment.NewLine + "Voici l'aire du triangle " + aire + " cm carré" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();

            }

            void Trapeze()
            {
                Console.Title = "SeryuApp | L'aire d'un trapèze";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"/ Calculer l'aire d'un trapèze \");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Ne pas mettre de . ou de ; (Exemple 2,45)" + Environment.NewLine);

                double aire;

                Console.WriteLine("Veuillez saisir la valeur de la grande base :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double based1 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Veuillez saisir la valeur de la petite base :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double based2 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Veuillez saisir la valeur de la hauteur :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double ha = double.Parse(Console.ReadLine());
                Console.ResetColor();

                aire = ((based1 + based2) * ha / 2);

                Console.WriteLine(Environment.NewLine + "Voici l'aire du trapèze : " + aire + " cm carré" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();

            }

            void Cercle()
            {
                Console.Title = "SeryuApp | L'aire d'un cercle";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"/ Calculer l'aire d'un cercle \");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Pi = 3.14");
                Console.WriteLine("Ne pas mettre de . ou de ; (Exemple 2,45)" + Environment.NewLine);

                double aire;

                Console.WriteLine("Veuillez saisir la valeur du rayon :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double rayon = double.Parse(Console.ReadLine());

                Console.ResetColor();

                const double pi = 3.14;

                aire = pi * (rayon * rayon);

                Console.WriteLine(Environment.NewLine + "Voici l'aire du cercle : " + aire + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();
            }

            void TriangleR()
            {
                Console.Title = "SeryuApp | L'aire d'un Triangle Rectangle";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"/ Calculer l'aire d'un triangle rectangle \");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Ne pas mettre de . ou de ; (Exemple 2,45)" + Environment.NewLine);

                double aire;

                Console.WriteLine("Veuillez saisir la valeur de l'un des côtés adjacents à l'hypoténuse :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double cote1 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Veuillez saisir la valeur du dernier côté adjacent à l'hypoténuse :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double cote2 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                aire = (cote1 * cote2 / 2);

                Console.WriteLine(Environment.NewLine + "Voici l'aire du triangle rectangle " + aire + " cm carré" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();
            }

            void Parall()
            {
                Console.Title = "SeryuApp | L'aire d'un parallélo";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"/ Calculer l'aire d'un parallélogramme \");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Ne pas mettre de . ou de ; (Exemple 2,45)" + Environment.NewLine);

                double aire;

                Console.WriteLine("Veuillez saisir la valeur de la base :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double based1 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Veuillez saisir la valeur de la hauteur :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double ha = double.Parse(Console.ReadLine());
                Console.ResetColor();

                aire = (based1 * ha);

                Console.WriteLine(Environment.NewLine + "Voici l'aire d'un parallélogramme " + aire + " cm carré" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();
            }

            void Rectangle()
            {
                Console.Title = "SeryuApp | L'aire d'un rectangle";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"/ Calculer l'aire d'un rectangle \");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Ne pas mettre de . ou de ; (Exemple 2,45)" + Environment.NewLine);

                double aire;

                Console.WriteLine("Veuillez saisir la valeur de la base :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double based1 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Veuillez saisir la valeur de la hauteur :" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;
                double ha = double.Parse(Console.ReadLine());
                Console.ResetColor();

                aire = (based1 * ha);

                Console.WriteLine(Environment.NewLine + "Voici l'aire d'un rectangle " + aire + " cm carré" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();
            }

            void JustePrix()
            {
                Console.Title = "SeryuApp | JustePrix";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Environment.NewLine + "Nombre générer aléatoirement ( Entre 1 et 100 )" + Environment.NewLine);
                Console.ResetColor();

                Random rnd = new Random();

                int number = rnd.Next(1, 100);

                double hy = 0;

                while (number != hy)
                {
                    hy = double.Parse(Console.ReadLine());

                    if (number < hy)
                    {
                        Console.WriteLine("Le nombre est plus petit" + Environment.NewLine);
                    }

                    if (number > hy)
                    {
                        Console.WriteLine("Le nombre est plus grand" + Environment.NewLine);
                    }

                }

                if (number == hy)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Environment.NewLine + "Vous avez trouvé le juste prix !");
                    Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                    Console.ResetColor();
                }

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();
            }

            Console.SetWindowSize(132, 30);
            Console.Title = "SeryuApp";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ________________________________________");
            Console.WriteLine("|                                        |");
            Console.WriteLine("| Calculateur de fonction en c# by Seryû |");
            Console.WriteLine("| Etat du code : Open Source             |");
            Console.WriteLine("| Commande importante : Retour           |");
            Console.WriteLine("| 'Retour = Revenir au pannel principal' |");
            Console.WriteLine("| 'Calculatrice = Ouvre la calculatrice' |");
            Console.WriteLine("| Commande spécial : Credit  / Secret    |");
            Console.WriteLine("|________________________________________|");
            Console.ResetColor();
            Console.WriteLine(@"");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" ________________________________________________________________________________________________________________________________");
            Console.WriteLine(@"|                                                                                                                                |");
            Console.WriteLine(@"| [ 1 ] Réciproque du théorème de Pythagore            [ 2 ] Théorème de Pythagore             [ 3 ] Calculer une moyenne        |");
            Console.WriteLine(@"| [ 4 ] Calculer l'aire d'un triangle                  [ 5 ] Calculer l'aire d'un trapèze      [ 6 ] Calculer l'aire d'un cercle |");
            Console.WriteLine(@"| [ 7 ] Calculer l'aire d'un triangle rectangle        [ 8 ] Calculer l'aire d'un parallélo... [ 9 ] Calculer l'aire d'un rect.. |");
            Console.WriteLine(@"|________________________________________________________________________________________________________________________________|");
            Console.WriteLine(Environment.NewLine + "Ecrivez 'Calculatrice' pour ouvrir celle-ci" + Environment.NewLine);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            string op = Console.ReadLine();
            Console.ResetColor();

            if (op == "1")
            {
                Reciproque();
            }

            if (op == "2")
            {
                Theoreme();
            }

            if (op == "3")
            {
                Moyenne();
            }

            if (op == "4")
            {
                Triangle();
            }

            if (op == "5")
            {
                Trapeze();
            }

            if (op == "6")
            {
                Cercle();
            }

            if (op == "7")
            {
                TriangleR();
            }

            if (op == "8")
            {
                Parall();
            }

            if (op == "9")
            {
                Rectangle();
            }

            if (op == "Calculatrice")
            {
                Calculatrice();
            }

            if (op == "Credit")

            {
                Console.Title = "SeryuApp | Crédit";
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" _________________________________________");
                Console.WriteLine("|                                         |");
                Console.WriteLine("| Code : OpenSource                       |");
                Console.WriteLine("| By   : Seryu                            |");
                Console.WriteLine("| Github : https://github.com/Seryu-Ub    |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("| Help : Gaetaen                          |");
                Console.WriteLine("| Github : https://github.com/gaetaen     |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("| Little help  : Zelly                    |");
                Console.WriteLine("| Github : https://github.com/ZelliDev    |");
                Console.WriteLine("|_________________________________________|");
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);

                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                Console.ReadKey();
            }

            if (op == "Secret")
            {
                Console.Title = "SeryuApp | Secret";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@" ________  ________  ___  ___  ________  ________  ________   ");
                Console.WriteLine(@"|\   ____\|\   ____\|\  \|\  \|\   __  \|\   __  \|\   __  \  ");
                Console.WriteLine(@"\ \  \___|\ \  \___|\ \  \\\  \ \  \|\  \ \  \|\  \ \  \|\  \ ");
                Console.WriteLine(@" \ \  \    \ \_____  \ \   __  \ \   __  \ \   _  _\ \   ____\");
                Console.WriteLine(@"  \ \  \____\|____|\  \ \  \ \  \ \  \ \  \ \  \\  \\ \  \___|");
                Console.WriteLine(@"   \ \_______\____\_\  \ \__\ \__\ \__\ \__\ \__\\ _\\ \__\   ");
                Console.WriteLine(@"    \|_______|\_________\|__|\|__|\|__|\|__|\|__|\|__|\|__|   ");
                Console.WriteLine(@"             \|_________|                                     ");
                Console.WriteLine("");
                Console.WriteLine(@"     ========       By              Seryû       ========      ");
                Console.WriteLine(@"     ========    https://github.com/Seryu-Ub    ========      ");
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Si vous voulez jouer au petit jeu caché ecrivez 'Jouer'" + Environment.NewLine + "Ecrivez 'Retour' pour revenir au pannel principal" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Magenta;

                string up = Console.ReadLine();

                if (up == "Retour")
                {
                    Main();
                }

                if (up == "Jouer")
                {
                    JustePrix();
                }
                Console.ReadKey();
            }
        }
    }
}
