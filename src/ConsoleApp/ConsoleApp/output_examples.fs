module output_examples
open System

let hello() =
    printf "enter name: "
    let name = Console.ReadLine()
    printfn "Hello %s" name

    // Note we also have..
    // %i for integers
    // %f for floats
    // %b for booleans
    // %A for lists
    // %O for objects?
    // %M for BigNum?

let padded_output() =
    printfn "[%-5s]" "X"     // pad-right
    printfn "[%5s]" "X"      // pad-left
    printfn "[%*s]" 5 "X"    // pad-left by 5
    printfn "[%*s]" 10 "X"   // pad-left by 10 (but negative doesn't work :/ )
