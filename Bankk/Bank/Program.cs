using Bank;
using System.Security.Cryptography;

List<User> users = new List<User>();

users.Add(new User { Name = "Zehra", Surname = "Memmedzade", creaditCart = new BankCard { PAN = "1234123412341234", PIN = "4166", CVC = "453", date = "06/29", balanc = 3320 } });
users.Add(new User { Name = "Nezrin", Surname = "Xelilzade", creaditCart = new BankCard { PAN = "1234567887654321", PIN = "1148", CVC = "827", date = "02/20", balanc = 875 } });
users.Add(new User { Name = "Lamiye", Surname = "Qeribova", creaditCart = new BankCard { PAN =  "6567783465677834" , PIN = "0000", CVC = "629", date = "12/17", balanc = 8756457 } });
users.Add(new User { Name = "Abbas", Surname = "Mehemmedov", creaditCart = new BankCard { PAN = "9148252952959435", PIN = "8968", CVC = "281", date = "08/25", balanc = 777660 } });
users.Add(new User { Name = "Nihad", Surname = "Cabbarli", creaditCart = new BankCard { PAN = "5382927619437372", PIN = "5179", CVC = "483", date = "10/13", balanc = 355532 } });


Console.WriteLine("PIN kodunu girin: ");
string writePIN = Console.ReadLine();

User contUser = null;

foreach (var item in users)
{
    if(item.creaditCart.PIN == writePIN)
    {
        contUser = item;
        break;
        
    }

}


if(contUser != null)
{
    Console.WriteLine($"{contUser.Name}{contUser.Surname} xos gelmisiniz zehmet olmasa asagidakilardan birini secerdiniz.");
    Console.WriteLine("1.Balanc");
    Console.WriteLine("2.Nagd pul");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {

        case 1:
            Console.WriteLine($"Balanc: {contUser.creaditCart.balanc}azn");
            break;
        case 2:
            Console.WriteLine("1. 10AZN");
            Console.WriteLine("2. 20AZN");
            Console.WriteLine("3. 50AZN");
            Console.WriteLine("4. 100AZN");
            Console.WriteLine("5. Diger");

            int TextChoice = int.Parse(Console.ReadLine());

            decimal Choice_ = 0;

            switch(TextChoice)
            {
                case 1:
                    Choice_ = 10;
                    break;
                case 2:
                    Choice_ = 20;
                    break;
                case 3:
                    Choice_ = 50;
                    break;
                case 4:
                    Choice_ = 100;
                    break;
                case 5:
                    Console.WriteLine("Meblegi daxil edin: ");
                    Choice_ = decimal.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Yanlis secim!");
                    break;
            }

            if(Choice_ >contUser.creaditCart.balanc)
            {
                Exception ex = new Exception("Daxil etdiyiniz mebleg tapilmadi");
                Console.WriteLine(ex.Message);
            }
            else
            {
                contUser.creaditCart.balanc -= Choice_;
                Console.WriteLine($"{Choice_} azn balans cixardi");
                Console.WriteLine($"Balansda qalan mebleg: {contUser.creaditCart.balanc}");
            }
            break;

        default:
            break;
    }

}
else
{
    Console.WriteLine("Daxil edilen PIN tapilmadi");
}






