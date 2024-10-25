#region Assignment-1
/*Create a Book and Author class with suitable properties and Hardcoded with Minimum 5 data for both the classes and covert into Json and XML Format 
 * and store that data in Local Disk using File concept .Read the Json and XML data and display the same in console App
 */

using Assignment1;
using System.Net;
using System.Text.Json;
using System.Xml.Serialization;

List<Book> books = new List<Book>
{
    new Book(){ BookId = 1, BookName = "Harry Potter", AuthorName = "JK Rowling" },
    new Book(){ BookId = 2, BookName = "Making India Awesome", AuthorName = "Chetan Bhagat  " },
    new Book(){ BookId = 3, BookName = "A Million Mutinies Now ", AuthorName = "V.S. Naipaul" },
    new Book(){ BookId = 4, BookName = "A Brush with Life ", AuthorName = "Satish Gujral" },
    new Book(){ BookId = 5, BookName = "A River Sutra", AuthorName = "Gita Mehta" }
};

List<Author> authors = new List<Author>
{
    new Author(){AuthorID=1, AuthorName="JK Rowling", AuthorAge=55},
    new Author(){AuthorID=2, AuthorName="Chetan Bhagat", AuthorAge=45},
    new Author(){AuthorID=3, AuthorName="V.S. Naipaul", AuthorAge=55},
    new Author(){AuthorID=4, AuthorName="Satish Gujral", AuthorAge=45},
    new Author(){AuthorID=5, AuthorName="Gita Mehta", AuthorAge=55}
};

#region For Books Class

#region JSON Format Serialization
/*
string jsonString=JsonSerializer.Serialize(books);
Console.WriteLine($"Serialized Data= \n {jsonString}");
File.WriteAllText("D:\\Phase3C#\\ClassAssignment\\Assignment1\\Books.json", jsonString);
*/
#endregion

#region JSON Format DeSerialization
/*
string readResult = File.ReadAllText("D:\\Phase3C#\\ClassAssignment\\Assignment1\\Books.json");
List<Book> bookDeserialize =JsonSerializer.Deserialize<List<Book>>(readResult);
foreach(var book in bookDeserialize) {
    Console.WriteLine($" BookId: {book.BookId} BookName: {book.BookName} AuthorName: {book.AuthorName}");

}
*/
#endregion

#region XML Format Serialization
/*
string filePath = "D:\\Phase3C#\\ClassAssignment\\Assignment1\\Books.dat";
XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));

using(FileStream fs=new FileStream(filePath, FileMode.Create)) {
    serializer.Serialize(fs, books);
}
Console.WriteLine("Books Serialized to XML Format");
*/
#endregion

#region XML Format DeSerialization
/*
string filePath = "D:\\Phase3C#\\ClassAssignment\\Assignment1\\Books.dat";
XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Book>));
using (FileStream fs = new FileStream(filePath, FileMode.Open)) {
    List<Book> bookD=(List<Book>)xmlserializer.Deserialize(fs);
    foreach(var book in bookD) {
        Console.WriteLine($"BookId: {book.BookId} BookName: {book.BookName} BookAuthor: {book.AuthorName}");
    }
}
*/
#endregion

#endregion

#region For Author Class

#region JSON Format Serialization
/*
string jsonString=JsonSerializer.Serialize(authors);
Console.WriteLine($"Serialized Data= \n {jsonString}");
File.WriteAllText("D:\\Phase3C#\\ClassAssignment\\Assignment1\\Authors.json", jsonString);
*/
#endregion

#region JSON Format DeSerialization
/*
string readResult = File.ReadAllText("D:\\Phase3C#\\ClassAssignment\\Assignment1\\Authors.json");
List<Author> authorDeserialize =JsonSerializer.Deserialize<List<Author>>(readResult);
foreach(var author in authorDeserialize) {
    Console.WriteLine($" AuthorId: {author.AuthorID} AuthorName: {author.AuthorName} AuthorAge: {author.AuthorAge}");

}
*/
#endregion

#region XML Format Serialization
/*
string filePath = "D:\\Phase3C#\\ClassAssignment\\Assignment1\\Authors.dat";
XmlSerializer serializer = new XmlSerializer(typeof(List<Author>));

using(FileStream fs=new FileStream(filePath, FileMode.Create)) {
    serializer.Serialize(fs, authors);
}
Console.WriteLine("Books Serialized to XML Format");
*/
#endregion

#region XML Format DeSerialization
/*
string filePath = "D:\\Phase3C#\\ClassAssignment\\Assignment1\\Authors.dat";
XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Author>));
using (FileStream fs = new FileStream(filePath, FileMode.Open)) {
    List<Author> AuthorD=(List<Author>)xmlserializer.Deserialize(fs);
    foreach(var Author in AuthorD) {
        Console.WriteLine($"AuthorId: {Author.AuthorID} AuthorName: {Author.AuthorName} AuthorAge {Author.AuthorAge}");
    }
}
*/
#endregion


#endregion

#endregion

#region Assignment-2

/*
 * create a Customer class with the below properties
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }

create a separate class to validate PhoneNumber, Email,DOB using some function which should return bool
(true if valid ,False if invalid)
 */
#region PhoneNum Validation
/*
Console.WriteLine("Enter phone num");
string number = Console.ReadLine();
ValidatePhoneNum validatePhoneNum = new ValidatePhoneNum();
if(validatePhoneNum.ValidatePhone(number)) Console.WriteLine($"Correct format: {number}");
else Console.WriteLine($"Wrong format: {number}");
*/
#endregion

#region EmailValidation
/*
Console.WriteLine("Enter email");
string email=Console.ReadLine();
ValidateEmail validateEmail = new ValidateEmail();
if(validateEmail.CheckEmail(email)) Console.WriteLine($"Correct format: {email}");
else Console.WriteLine($"Wrong format: {email}");
*/
#endregion

#region DOB-Validation
/*
Console.WriteLine("Enter DOB (DD-MM-YYYY)");
string DOB=Console.ReadLine();
ValidateDOB validateDOB = new ValidateDOB();
if (validateDOB.CheckDOB(DOB)) Console.WriteLine($"Correct format: {DOB}");
else Console.WriteLine($"Invalid format: {DOB}");
*/
#endregion

#endregion

#region Assignment 3
/*
Create a TransportSchedule class with properties like TransportType (bus or flight), Route, DepartureTime, ArrivalTime, Price, and SeatsAvailable.
Create a TransportManager class to manage a list of transport schedules.
LINQ Operations:
Search: Find schedules by transport type, route, or time.
Group By: Group schedules by transport type (bus or flight).
Order By: Order schedules by departure time, price, or seats available.
Filter: Filter schedules based on availability of seats or routes within a time range.
Aggregate: Calculate the total number of available seats and the average price of transport.
Select: Project a list of routes and their departure times.
*/

List<TransportSchedule> schedules = new List<TransportSchedule>
{
    new TransportSchedule(){Type="Bus",Route=1,DepartureTime="05:15" ,ArrivalTime="04:15",Price=100,SeatAvailable=15},
    new TransportSchedule(){Type="Bus",Route=1,DepartureTime="05:15" ,ArrivalTime="04:15",Price=200,SeatAvailable=20},
    new TransportSchedule(){Type="Flight",Route=2,DepartureTime="07:15" ,ArrivalTime="03:15",Price=1000,SeatAvailable=45},
    new TransportSchedule(){Type="Flight",Route=2,DepartureTime="08:15" ,ArrivalTime="02:15",Price=10000,SeatAvailable=30},
    new TransportSchedule(){Type="Train",Route=3,DepartureTime="09:15" ,ArrivalTime="02:15",Price=5000,SeatAvailable=100}
};

List<TransportManager> managers = new List<TransportManager>
{
    new TransportManager(){schedule=schedules }
};

#region Search
/*
#region Type
var searchType = from s in schedules
                 where s.Type == "Bus"
                 select s;

Console.WriteLine("Schedule based on type:BUS");
foreach(var v in searchType) {
    Console.WriteLine($"Type: {v.Type} Route: {v.Route} DepartureTime: {v.DepartureTime} ArrivalTime: {v.ArrivalTime} Price: {v.Price} SeatAvailable: {v.SeatAvailable}");
}
#endregion
#region Route
var searchType1 = from s in schedules
                 where s.Route == 2
                 select s;

Console.WriteLine("Schedule based on route:2");
foreach (var v in searchType1) {
    Console.WriteLine($"Type: {v.Type} Route: {v.Route} DepartureTime: {v.DepartureTime} ArrivalTime: {v.ArrivalTime} Price: {v.Price} SeatAvailable: {v.SeatAvailable}");
}
#endregion
#region Time
var searchType3 = from s in schedules
                 where TimeOnly.ParseExact(s.ArrivalTime,"HH:mm")> TimeOnly.ParseExact("04:00","HH:mm")
                  select s;

Console.WriteLine("Schedule based on Arrival Time > 04:00");
foreach (var v in searchType3) {
    Console.WriteLine($"Type: {v.Type} Route: {v.Route} DepartureTime: {v.DepartureTime} ArrivalTime: {v.ArrivalTime} Price: {v.Price} SeatAvailable: {v.SeatAvailable}");
}

#endregion
*/
#endregion

#region GroupBy
/*
var groupby = schedules.GroupBy(s=>s.Type);
foreach(var v in groupby) {
    Console.WriteLine($"Grouping by Type: {v.Key}");
    foreach(var i in v) {
        Console.WriteLine($"{i.Route} {i.DepartureTime} {i.ArrivalTime} {i.Price} {i.SeatAvailable}");
    }
}
*/
#endregion

#region OrderBy
/*
var orderbyDepartureTime=schedules.OrderBy(s=>s.DepartureTime);
Console.WriteLine("Order by Departure Time");
foreach(var v in orderbyDepartureTime) {
    Console.WriteLine($"Type: {v.Type} Route: {v.Route} DepartureTime: {v.DepartureTime} ArrivalTime: {v.ArrivalTime} Price: {v.Price} SeatAvailable: {v.SeatAvailable}");

}
var orderbyDeparturePrice = schedules.OrderBy(s => s.Price);
Console.WriteLine("Order by Price");
foreach (var v in orderbyDeparturePrice) {
    Console.WriteLine($"Type: {v.Type} Route: {v.Route} DepartureTime: {v.DepartureTime} ArrivalTime: {v.ArrivalTime} Price: {v.Price} SeatAvailable: {v.SeatAvailable}");

}
var orderbyDepartureSeat = schedules.OrderBy(s => s.SeatAvailable);
Console.WriteLine("Order by Seat");
foreach (var v in orderbyDepartureSeat) {
    Console.WriteLine($"Type: {v.Type} Route: {v.Route} DepartureTime: {v.DepartureTime} ArrivalTime: {v.ArrivalTime} Price: {v.Price} SeatAvailable: {v.SeatAvailable}");

}
*/
#endregion

#region Filter

Console.WriteLine("Filter by Seat>20");

var filterBySeat = schedules.Where(s => s.SeatAvailable > 20);
foreach(var v in filterBySeat) {
    Console.WriteLine($"Type: {v.Type} Route: {v.Route} DepartureTime: {v.DepartureTime} ArrivalTime: {v.ArrivalTime} Price: {v.Price} SeatAvailable: {v.SeatAvailable}");

}

#endregion

#region Aggregate
/*
var agg=schedules.Where(s=>s.Type=="Bus").Sum(s=>s.SeatAvailable);
var agg1 = schedules.Where(s => s.Type == "Bus").Average(s => s.Price);

Console.WriteLine($"TotalSeats available for bus is: {agg}");
Console.WriteLine($"TotalPrice available for bus is: {agg1}");

*/
#endregion

#region select
/*
var selectq = from s in schedules
              select new { s.Route, s.DepartureTime };

foreach(var v in selectq) {
    Console.WriteLine($"Route: {v.Route} DepartureTime: {v.DepartureTime}");
}
*/
#endregion

#endregion

