// 1) Initiate db connection
// 2) Start the app
// 3) Display available features (based on story)
// 4) Process Input based on selection
// 5) Terminate features
//
using TodoList;
using System;

DBService db = DBService.GetInstance();
DBService db2 = DBService.GetInstance();
Console.WriteLine(db.randomNumber);
Console.WriteLine(db2.randomNumber);
if (db == db2) {
    Console.WriteLine("both are same instance");
}
