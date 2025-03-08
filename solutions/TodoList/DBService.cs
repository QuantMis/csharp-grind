

// responsibility: 
// - manage connection with the database
// - abstract the ADO.NET library
//
// states: 
// - connection instance (public)
// - connection string (private)
//
// behavior: connection lifecycle
// - createConnection()
// - closeConnection()
// - executeQuery()
//
// instantiation 
// - single
//
// relationship
// - act as a singleton, and will be shared around the app
// - provide connection instance to other object
// - execute query on behalf of other object

using System;
using System.Data.SqlClient

namespace TodoList;
public class DBService
{
    private static DBService _instance;

    public static DBService GetInstance() {
        if (_instance == null) {
            _instance = new DBService();
        }
        return _instance; 
    }

    private DBService() {
    }

}
