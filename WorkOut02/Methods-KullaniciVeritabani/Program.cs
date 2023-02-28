internal class Program
{
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
        
    }
}