


Random random = new Random();


// Caractères disponibles pour le mot de passe
string passwordMin = "abcdefghijklmnopqrstuvwxyz";
string passwordMaj = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string passwordNum = "0123456789";
string passwordSymb = "!\"#$%&'( )*+,-./:;<=>?@[\\]^_`{|}~";


// Demande la taille du mot de passe
Console.WriteLine("Choose the size of your password (min 4 characters) :");
int passwordSize = int.Parse(Console.ReadLine()!);


// Vérifie la taille minimum du mot de passe
if (passwordSize < 4)
{
    Console.WriteLine("The password must be at least 4 characters");
    return;
}


// On prépare la génération
string password = "";
int estimateSize = passwordSize - 4;


// Sélectionne 1 caractère obligatoire de chaque catégorie
int maj = random.Next(passwordMaj.Length);
int min = random.Next(passwordMin.Length);
int num = random.Next(passwordNum.Length);
int symb = random.Next(passwordSymb.Length);


// Génère les caractères restants
for (int i = 0; i < estimateSize; i++)
{

    int randomCategorie = random.Next(4);


    if (randomCategorie == 0)
    {
        maj = random.Next(passwordMaj.Length);
        password += passwordMaj[maj];
    }

    else if (randomCategorie == 1)
    {
        min = random.Next(passwordMin.Length);
        password += passwordMin[min];
    }

    else if (randomCategorie == 2)
    {
        num = random.Next(passwordNum.Length);
        password += passwordNum[num];
    }

    else
    {
        num = random.Next(passwordSymb.Length);
        password += passwordNum[symb];
    }

}


// Ajoute les 4 caractères obligatoires
password += passwordMaj[maj];
password += passwordMin[min];
password += passwordNum[num];
password += passwordSymb[symb];


// Mélange du mot de passe final (Fisher-Yates Shuffle)
char[] chars = password.ToCharArray();

for (int i = chars.Length - 1; i > 0; i--)
{
    int j = random.Next(i + 1);
    (chars[i], chars[j]) = (chars[j], chars[i]);
}

password = new string(chars);


// On donne le mot de passe à l'utilisateur
Console.WriteLine("Your new password is : " + password);
