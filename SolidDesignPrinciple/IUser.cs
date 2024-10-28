using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_DEMO {
    
    public interface IUser {
        public void GetDesignation();
    }
    public interface IStudent : IUser {
        public void BorrowBook(string bookName, Dictionary<string, bool> books);
    }
    public interface ITeacher : IUser {
        public void BorrowBook(string bookName, Dictionary<string, bool> books);
        public void ReserveBook(string bookName, Dictionary<string, bool> books);
    }
    public interface ILibrarian : IUser {
        public void AddBook(string bookName, Dictionary<string, bool> books);
        public void RemoveBook(string bookName, Dictionary<string, bool> books);
    }

    public class Student : IStudent {
        public void BorrowBook(string bookName, Dictionary<string, bool> books) {
            if (books.ContainsKey(bookName)) {
                books[bookName] = false;
                Console.WriteLine("Name of borrowed book is " + bookName);
            }
            else {
                Console.WriteLine($"The book: {bookName}  does not exist in the inventory.");
            }
        }

        public void GetDesignation() {
            Console.WriteLine("User is Student");
        }
    }

    public class Teacher : ITeacher {
        public void BorrowBook(string bookName, Dictionary<string, bool> books) {
            if (books.ContainsKey(bookName)) {
                books[bookName] = false;
                Console.WriteLine("Name of borrowed book is " + bookName);
            }
            else {
                Console.WriteLine($"The book: {bookName} does not exist in the inventory.");
            }
        }

        public void GetDesignation() {
            Console.WriteLine("User is Teacher");
        }

        public void ReserveBook(string bookName, Dictionary<string, bool> books) {
            if (books.ContainsKey(bookName)) {
                books[bookName] = false;
                Console.WriteLine("Name of reserved book is " + bookName);

            }
            else {
                Console.WriteLine($"The book: {bookName} does not exist in the inventory.");
            }
        }
    }

    public class Librarian : ILibrarian {
        public void AddBook(string bookName, Dictionary<string, bool> books) {
            Console.WriteLine("Name of new book added is " + bookName);
            books.Add(bookName, true);
        }

        public void GetDesignation() {
            Console.WriteLine("User is Librarian");
        }

        public void RemoveBook(string bookName, Dictionary<string, bool> books) {
            if (books.ContainsKey(bookName)) {
                books.Remove(bookName);
                Console.WriteLine("Name of removed book is " + bookName);
            }
            else Console.WriteLine($"Book: {bookName} not found");
        }
    }
}
