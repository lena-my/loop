
/* Crée un tableau moves de taille 32

Une boucle itère en attendant que l'utilisateur rentre un pas de danse de type string. La boucle s'arrête lorsque la taille maximum est atteinte ou que la chaîne de caractères "done" est spécifiée.

Ajouter dans le tableau moves chaque pas entré si il est différent de "done"
L'utilisateur choisit ensuite le nombre d'itérations de la suite de pas

La suite de pas est répétée autant de fois à l'écran que le nombre d'itérations entré par l'utilisateur */


string[] moves = new string[32];

for (int i=0; i < moves.Length; i++)
{
    Console.WriteLine("Please, insert a dance move: ");
    moves[i] = Console.ReadLine(); 
    Console.WriteLine($"The dance move entered is: {moves[i]}");
}

Console.WriteLine($"The dance moves are: {string.Join(" ", moves)}");