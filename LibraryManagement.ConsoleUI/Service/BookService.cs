
using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Models.DTO;
using LibraryManagement.ConsoleUI.Repository;
using System.Collections.Concurrent;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace LibraryManagement.ConsoleUI.Service;

public class BookService
{
    BookRepository bookRepository = new BookRepository();

    public void GetAll()
    {
        List<Book> books = bookRepository.GetAll();

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void GetById(int id)
    {
        Book? book = bookRepository.GetById(id);
        if (book is null)
        {
            Console.WriteLine("Aradığınız id'ye göre kitap bulunamadı");
            return;
        }
        Console.WriteLine(book);
    }

    public void Remove(int id)
    {
        Book? deletedBook = bookRepository.Remove(id);
        if (deletedBook is null)
        {
            Console.WriteLine("Aradığınız kitap bulunamadı");
            return;
        }

        Console.WriteLine(deletedBook);
    }

    public void GetBookByISBN(string isbn)
    {
        Book? book = bookRepository.GetBookByISBN(isbn);
        if (book is null)
        {
            Console.WriteLine($"Aradığınız ISBN numarasına göre kitap bulunamadı {isbn}");
            return;
        }
        Console.WriteLine(book);
    }

    public void Add(Book book)
    {
        BookIdBusinessRules(book.Id);

        }

        Book getBookByISBN(Book isbn) {
            Book getByBookISBN = bookRepository.GetBookByISBN(book.ISBN);
            if (getByBookISBN != null) {
                Console.WriteLine($"Girmiş olduğunuz kitabın ISBN alanı benzersiz olmalıdır! {book.ISBN}");

                Book created = bookRepository.Add(book);
                Console.WriteLine("Kitap eklendi: ");
                Console.WriteLine(created);
            }

            public void GetAllBooksByPageSİzeFilter(int min, int max)
            {
                List<Book> books = bookRepository.GetAllBooksByPageSizeFilter(min, max);
                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }

            }

            public void GettAllBooksTitleContains(string text)
            {
                List<Book> books = bookRepository.GetAllBooksByTitleContains(text);
                foreach (Book book in books)
                {
                    Console.WriteLine(books);
                }
            }

            public void GetAllBooksOrderByTitle()
            {
                List<Book> books = bookRepository.GetAllBooksOrderByTitle();

                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
            }

            public void GetAllBooksOrderByDescending()
            {
                List<Book> books = bookRepository.GetAllBooksOrderByDescending();

                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
            }

            public void GetBookMaxSize()
            {
                {
                    Book books = bookRepository.GetBookMaxSize();
                    Console.WriteLine(books);
                }
            }

            public void GetBookMinSize()
            {
                Book books = bookRepository.GetBookMinSize();
                Console.WriteLine(books);
            }

            public void GetDetails()
            {
                List<BookDetailDto> books = bookRepository.GetDetails();
                foreach (BookDetailDto bookDetail in books)
                {
                    Console.WriteLine(bookDetail);
                }
            }

            public void GetDetailsV2()
            {
                List<BookDetailDto> books = bookRepository.GetDetailsV2();
                foreach (BookDetailDto bookDetail in books)
                {
                    Console.WriteLine(bookDetail);
                }
            }

            public void GetAllBookAndAuthorDetails()
            {
                List<BookDetailDto> details = bookRepository.GetAuthorAndBookDetails();
                details.ForEach(x => Console.WriteLine(x));
            }

            private void BookIdBusinessRole()
            {
                Book? getByIdBoook = bookRepository.GetByIdBoook(book.Id);
                if (getByIdBoook != null) { }
                {
                    Console.WriteLine($"Girmiş olduğunuz kitabın Id laanı benzersiz olmalıdır! {book.Id}");
                    return;
                }

            private void BookISBNBusinessRole(string isbn)
                {


                }
        }

    }