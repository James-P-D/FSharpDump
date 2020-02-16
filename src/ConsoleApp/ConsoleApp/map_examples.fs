module map_examples
open System

let do_map_examples() =
    // Create a map
    let customers =
        // Create empty map
        Map.empty. 
            // Add key values to map
            Add("Bob Smith", 100.50).
            Add("Sally Marks", 50.25)
 
    // Number of customers
    printfn "# of Customers %i" customers.Count
    
    // Find Bob Smiths balance
    let cust = customers.TryFind "Bob Smith"
    match cust with
    | Some x -> printfn "Balance : %.2f" x
    | None -> printfn "Not Found"
    
    // List customer names and balances
    printfn "Customers: %A" customers
    
    // Test if key exists
    if customers.ContainsKey "Bob Smith" then
        printfn "Bob Smith was Found"
    
    // Get value of key
    printfn "Bobs Balance : %.2f" customers.["Bob Smith"]
    
    // Remove an item
    let custs2 = Map.remove "Sally Marks" customers
    printfn "# of Customers %i" custs2.Count    