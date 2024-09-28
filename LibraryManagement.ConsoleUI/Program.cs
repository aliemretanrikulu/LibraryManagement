// (Record) Kitap -> Id, Title, Description, pageSize, PublishDate, Stock 
// (Record) Author -> Id, name, surname, 
// (Class) Category -> Id, name


// Kitaplar listesi oluşturunuz
// yazarlar listesi oluşturunuz
// Kategoriler listesi oluşturunuz 

// Yazarları ekrana bastıran kodu yazınız
// Kitapları ekrana bastıran kodu yazınız
// Kategorileri ekrana bastıran kodu yazınız

// Kitapları sayfa sayısına göre filtreleyen kodu yazınız
// Kütüphanedeki tüm kitapların sayfa sayısının toplamını hesaplayan kodu yazınız
// Kitap başlığına göre filtreleme işlemleri yapınız 
// Kitap ISBn numarasına göre ilgili kitabı getrininiz 

// Kitaplar listesine yeni bir kitap ekleyip sonra listeyi ekran çıktısı olarak yazınız (Verileri kullanıcdan alınız) 

// * Kitap eklerken ID'si veya ISBM numarası daha önceki eklenen kitaplada var ise
// "benzersiz bir kitap girmeniz" gerekmektedir yazısı çıksın 

// Kullanıcı bir Id giridği zaman o ID'ye göre o kitabı silen ve yeni listeyi ekrana bastıran kodu yazınız 

// Kullanıcıdan ilk başta ID değeri alın arama yaptıktan sonra eğer o ID ye ait bir kitap yoksa "İlgili ID'ye ait bir kitap bulunamadı"
// Güncellenecek olan değerler kullanıcdan alınacak. 

// Kullanıcıdan bir kitap almasını isteyen kodu yazınız
// eğer o kitap Stokta varsa "kitap alındı" desin
// 1 tane varsa o kitap alınsın 0 olursa listeden silinsin 



// Prime Örnekler 
// BookDetail adında bir record oluşturun şu değerler listeleecek
// Kitap Id, kitap başlığı, kitap açıklaması, kitap sayfa sayısı, ISBN, Yazar adı, kategori adı 


// Kullanıcıdan PageIndex ve PageSize değerlerini alarak sayfalama desteği getiriniz 

using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Repository;
using LibraryManagement.ConsoleUI.Service;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;


List<Category> categories = new List<Category>()
{
    new Category(1, "Dünya Klasikleri"),
    new Category(2, "Türka Klasikleri"),
    new Category(3, "Bilim Kurgu")
};



//GetAllBooksByPageSizeFilter();
//GetAllAuthors();
//GetAllCategories();
//PageSizeTotalCalculator();
//GetAllBooksByTitleContains();
//GetBookByISBN();

BookService bookService = new BookService();
//bookService.GetAll();
//bookService.GetById(6);
//bookService.GetBookByISBN("9781234567800");

//bookService.GetAllBooksByPageSİzeFilter();

bookService.GetBookMaxSize();
bookService.GetBookMinSize();
//bookService.GetAllBookAndAuthorDetails();

Book GetBookInputs2()
{
    Console.WriteLine("Lütfen kitap id sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    string title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
    string description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
    int pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
    string publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
    string isbn = Console.ReadLine();

    Book book = new Book(id, 1,1, title, description, pageSize, publishDate, isbn);
    return book;
}

//bool AddBookValidator(Book book)
//{
//    bool isUnique = true;

//    foreach (Book item in books)
//    {
//        if (item.Id == book.Id || item.ISBN == book.ISBN)
//        {
//            isUnique = false;
//            break;
//        }
//    }

//    return isUnique;
//}

//void GetBookInputs(out int id,
//     out string title,
//     out string description,
//     out int pageSize,
//     out string publishDate,
//     out string isbn)
//{
//    Console.WriteLine("Lütfen kitap id sini giriniz: ");
//    id = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
//     title = Console.ReadLine();

//    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
//     description = Console.ReadLine();

//    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
//     pageSize = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
//     publishDate = Console.ReadLine();

//    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
//     isbn = Console.ReadLine();
//}


//void GetAllCategories()
//{
//    PrintAyirac("Kategorileri Listele");
//    foreach (Category category in categories)
//    {
//        Console.WriteLine(category);
//    }
//}

//void GetAllAuthors()
//{
//    PrintAyirac("Yazarları Listele: ");

//    foreach (Author author in authors)
//    {
//        Console.WriteLine(author);
//    }
//}

//void PrintAyirac(string metin)
//{
//    Console.WriteLine(metin);
//    Console.WriteLine("----------------------------------------");
//}