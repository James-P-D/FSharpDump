module list_examples
open System

let do_list_examples() =

    // We can create lists 
    printfn "Create list with discrete values"
    let list1 = [1; 9; 5; 6]
    printfn "list1 = %A" list1
    
    // Print list by piping it into List.iter
    printfn "Print list1 by piping it into an List.iter"
    list1 |> List.iter (printfn "list1 item : %i")
    
    // We can lists from ranges
    printfn "Create list with a range"
    let list2 = [10..15]
    printfn "list2 = %A" list2

    // We can create a list by concatonating with '::'
    printfn "Create list with concatonation of values"
    let list3 = 5::6::7::[] // Note last element must be an empty list
    printfn "list3 = %A" list3

    // Concatonate lists with '@' *not* ::
    printfn "Create list with concatonation of list1 and list2 using @"
    let list4 = list1 @ list2
    printfn "list4 = %A" list4
    
    // Initialise list of length 5 using anonymouse function that doubles index
    printfn "Create list of 5 with initial values of index * 2"
    let list5 = List.init 5 (fun i -> i * 2)
    printfn "list5 = %A" list5

    // Initialse list using for-loop and yield
    printfn "Create list using for loop and yield"
    let list6 = [ for a in 1..5 do yield (a * a) ]
    printfn "list6 = %A" list6

    // For each value in range 1..3, add the range X..X+2
    printfn "Create a list using for loop and yield! (bang)"
    let list7 = [for a in 1..3 do yield! [ a .. a + 2 ] ]
    printfn "%A" list7


    printfn "Length List1 = %i" list1.Length
    
    // Check if empty
    printfn "Empty List1 = %b" list1.IsEmpty

    printfn "Empty [] = %b" [].IsEmpty
    
    // Get item at index
    printfn "Index 0 of List1 (zero indexed) = %d" (list1.Item(0))
    printfn "Index 2 of List1 (zero indexed) = %d" (list1.Item(2))
    
    // Get the 1st item
    printfn "Head List1 = %d" (list1.Head)
    
    // Get the tail
    printfn "Tail List1 = %A" (list1.Tail)

    // Filter out only evens
    printfn "We can filter so we only get the even numbers from list1"
    let list8 = list1 |> List.filter (fun x -> x % 2 = 0)
    printfn "List8 = %A" list8
 
    // Multiply all values times themselves
    printfn "We can use List.map to apply an anonymous function to every element in list 8, in this case squaring them"
    let list9 = list8 |> List.map (fun x -> (x * x))
    printfn "List9 = %A" list9
 
    // Sort a list
    printfn "Sorted constant list = %A" (List.sort [5; 4; 3])
    printfn "Sorted list1 = %A" (List.sort list1)

    // Sum a list with fold
    printfn "We can use List.fold to get a single value after applying anonymous function to every item in list"
    printfn "Sum of list1 = %i" (List.fold (fun sum elem -> sum + elem) 0 list1)
 