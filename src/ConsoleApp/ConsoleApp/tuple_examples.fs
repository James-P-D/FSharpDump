module tuple_examples
open System

let do_tuple_examples() =
    // We can create tuples for containing different types of data
    let my_data = ("John", "Doe", 21, 125.6)

    // We can use pattern matching to get various items, and use '_' to ignore those we don't
    let (first_name, last_name, _, _) = my_data
    printfn "Name : %s %s" first_name last_name