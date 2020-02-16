module record_examples
open System

// create the record type outside of the let
type Person = {
    Name : string;
    Age : int}

let do_record_examples() =
    // Create and initialise 'bob'
    let bob = { Name = "Bob"; Age = 21}
    // Display the type of 'bob'
    printfn "bob is of type %A" (bob.GetType())
    // Display information extracted from 'bob'
    printfn "%s is %d years old" bob.Name bob.Age