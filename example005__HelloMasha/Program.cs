Console.Write("Введите имя ");
string username = Console.ReadLine();
if(username.ToLower() == "маша"){
    Console.WriteLine("Ура, Это же Маша!");
}
else{
    Console.WriteLine($"Привет, {username}");
}