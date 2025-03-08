namespace Fundamentals;

public class SimpleOperationExamples
{
    public void whileLoop() {
        int counter = 0;
        bool start = true;
        while(start) {
            Console.WriteLine(counter);
            counter++;
            if(counter == 5) {
                start = false;
            }
        }
        Console.WriteLine("Program Ended");
    } 
    
    public void doWhileLoop() {
        int counter = 0;
        bool start = true;
        do{
            Console.WriteLine(counter);
            counter++;
            if(counter == 5) {
                start = false;
            }
        }while(start);
        Console.WriteLine("Program Ended");
    }
    
    public void forLoops() {
        for(int i = 10; i > 0; i--){
            Console.WriteLine($"Index: {i}");
        }
    }

    public void listExample1() {
        // Episode 12: List<T> and Collections
        // List<T> is a class
        var items = new List<string> {"Item 1", "Item 2", null};
        var itemCount = items.Count;
        items.Add("Item 3");
        items.Remove(null);
        var exist = items.Contains(null);
        Console.WriteLine($"Item exist?: {exist}");
        
        for(int i = 0; i < items.Count; i++) {
            Console.WriteLine(items[i]);
        }
        
        foreach(var item in items) {
            Console.WriteLine(item);
        }
    }

}
