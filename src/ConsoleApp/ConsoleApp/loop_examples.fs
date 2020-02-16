module loop_examples
open System

let do_loop_examples() =
    // ----- WHILE LOOP -----
    let magic_num  = "7"
    let mutable guess = ""
    
    while not (magic_num.Equals(guess)) do
        printf "Guess the Number : "
        guess <- Console.ReadLine()    
    printfn "You Guessed the Number" // Note the whitespace change! No end-while or braces, must just indention like Python!

    // ----- FOR LOOP -----
    // Iterate up
    printfn "Loop from 1 to 10"
    for i = 1 to 10 do 
        printf "%i " i
    printfn ""

    // Iterate down
    printfn "Loop from 10 to 1"
    for i = 10 downto 1 do
        printf "%i " i
    printfn ""
    
    // Iterate over a range
    printfn "Loop over range"
    for i in [10..20] do
        printfn "%i " i
    printfn ""

    // Piping a range into a list iterator
    printfn "Piping range 1..10 into List.iter"
    [1..10] |> List.iter (printfn "Num : %i")
 
    // Summing a list
    printfn "Summing a list"
    let sum = List.reduce (+) [1..10]
    printfn "Sum : %i" sum