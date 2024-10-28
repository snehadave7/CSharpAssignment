Dictionary<string, bool> books = new Dictionary<string, bool>();
    
IStudent student = new Student();
ITeacher teacher = new Teacher();
ILibrarian librarian = new Librarian();

librarian.AddBook("HarryPotter",books);
librarian.AddBook("Alice in wonderLand",books);
librarian.AddBook("Gita", books);

student.BorrowBook("HarryPotter", books);
teacher.ReserveBook("ABc", books);

foreach (var book in books) {
    Console.WriteLine("bookName: "+ book.Key+ "  Book Availability: "+ book.Value);
}
