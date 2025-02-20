

// responsibility: manage connection with the database
//
// states: 
// - connection instance (public)
// - connection string (private)
//
// behavior:
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
namespace TodoList;
public class DBService
{
    public int randomNumber;

    private static DBService _instance;

    public static DBService GetInstance() {
        if (_instance == null) {
            _instance = new DBService();
        }
        return _instance; 
    }

    private DBService() {
        this.generateRandom();
    }

    private void generateRandom() {
        this.randomNumber = (new Random()).Next(999,9999);
    }

}
