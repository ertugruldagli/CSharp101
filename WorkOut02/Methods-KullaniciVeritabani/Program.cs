internal class Program
{

    //datUsers
    public static string[,] datUsers = new string[,]
    {
        {"K1", "K2", "K3"},//kullanıcılar
        {"P1", "P2", "P3"}, //şifreler
        {"A","K","K" }, //kullanıcı tipi A: Admin K: kullanıcı
        {"+","+","+"}//kullanıcının durumu (ACTIVE + / PASSIVE -)
    };

    public static string userAuthority; // kullanıcı türü tutacak
    public static string userStatus; // kullanıcı aktif ve pasif olduğunu belirtir.

    public static string[] datlog = new string[100]; //LOG DİZİSİ
    public static int indexLog = 0;
    

    private static void Main(string[] args)
    { //kullanıcı adı, şifresi, yetkisi, aktifliğini içeren bir dizi
        //user tablosu gibi
        //4*3 boyutunda manuel (hard coded) oluşturulacak
        //k1,k2,k3 kullanıcı adları 
        //p1, p2, p3 --  kullanıcı şifreleri
        //A,K,K - Yetki derecsi (admin mi, normal kullanıcı mı)
        //+,+,+ - kullanıcını aktifliği + aktif /- pasif 
        // bunun dışında sistem üzerindeki işlemleri izleyebileceği (Adminin ) bit log dizisi var (tek boyutlu
        // 
        // 1. program ilk çalıştığında kullanıcıyı bir ana menü ekranı karşılayacak (methodsal yapı)
        // 2. seçenekler 1.Sisteme giriş, 2,çıkış 
        // 3. 1. seçenek basıldığında kullanıcının karşısına bir login ekranı gelmeli
        // 4. kullanıcıdan kullanıcı adı user name ve user pass  alınacak
        // 5. kontrol  işlemiyle (datUser) kullanıcının var olup olmadığını kontrol edilecek yoksa, kullanıcı yok mesajı verilecek tekrar login ekranına dönülecek
        // 6. eğer varsa kullanıcnın diğer bilgileri (yetki ve aktiflik) öğrenilecek buna göre  yetki durumuna bağlı olarak farklı ekranlar kullanıcının karşısına gelecek.Admin paneli normal kullanıcı ise yapacağı işlemler listesi gibi
        // 7. yapılan işlemler datLog isimli bir  diziye işlenecek... İstenildiğinde admin kullanıcı tarafından listelenecek. Bu seçenek adminin kendi panelinde bir seçenek olarak bulunacak.

        bool showMenu = true;

        while (showMenu)
        {
            showMenu = MainMenu();
        }

        Console.WriteLine("çıkış için bir tuşa baısınız...!");
        Console.ReadKey();

    }

    private static bool MainMenu()
    {
        bool showLogin = true;

        Console.Clear();
        Console.WriteLine("----- Ana Menu -----");
        Console.WriteLine("1. Sistem Giriş");
        Console.WriteLine("2. Programdan Çıkış");
        Console.Write("\nSeçeneğiniz: ");

        switch (Console.ReadLine())
        {
            case "1":
                while(showLogin)
                {
                    showLogin = Login();
                }
                return true;

            case "2":
                //Porgramdan çıkış bölümü
                return false;
            case "3":
                //Porgramdan çıkış bölümü
                return false;
            default:
                return true;

        }
    }

    private static bool Login()
    {
        //note: her şifre karakteri girdiğinde şifre bölümünde yıldız karakteri gözüksün 

        string userID = "", userPass = "";

        Console.Clear();

        Console.WriteLine("---Login--- ");
        Console.WriteLine("bir önceki menüye için YILDIZ'ı tuşlayınız \n\n ");
        Console.WriteLine("kullanıcı adını giriniz: ");
        userID = Console.ReadLine().Trim();

        if (userID=="*")
        {
            return false;
        }

        Console.WriteLine("kullanıcı şifresini giriniz: ");
        userPass= Console.ReadLine().Trim();


        if (userControl(datUsers, userID, userPass) )
        {
            //Eğer kullanıcı bulunduysa...
            Console.WriteLine("HEyyyooo...Kullanıcıyı bulduk...\n\n");

            Console.WriteLine($"Kullanıcı yetki seviyesi {userAuthority}\n\n");

            Console.WriteLine($"Kullanıcı Durumu {userStatus}\n\n");

            Console.WriteLine("Devam etmek için bir tuşa basınız....");

            datlog[indexLog] = $"{userID} isimli kullanıcı sisteme giriş yapmıştır...";
            indexLog++;

            for (int i = 0; i < indexLog; i++)
            {
                Console.WriteLine("Log kaydı: "+ datlog[i]);
            }
                   
        }
        else
        {
            Console.WriteLine("Malesef kullanıcı yok...");
        }

        return true;
    }

    private static bool userControl(string[,] prmUsers,string prmUser, string prmPass)
    {
        bool found= false; //kullanıcının bulunup bulunmadığını belirten bir değişken
        // iç içe for döngüleri yardımı ile tüm dizi öğelerini dolaşalım.

        for (int satir = 0; satir < prmUsers.GetLength(0); satir++)
        {
            for (int sutun = 0; sutun< prmUsers.GetLength(1); sutun++)
            {
                if (prmUsers[satir,sutun]==prmUser) //eşleşen kullanıcı mı
                {
                    if (prmUsers[satir+1,sutun]==prmPass)//eşleşen şifre mi
                    {
                        userAuthority = prmUsers[satir + 2, sutun];
                        userStatus = prmUsers[satir+3, sutun];

                        found = true; //kullanıcı bulundu.
                        break;
                    }
                }
            }

            if (found)// kayıt bulunmuşsa
            {
                break;
            }
        }
        return found;
    }




}
      
    


