open System

let hello() =
    printf "enter name: "
    let name = Console.ReadLine()
    printfn "Hello %s" name

    // Note we also have..
    // %i for integers
    // %f for floats
    // %b for booleans
    // %A for tuples?
    // %O for objects?
    // %M for BigNum?

let padded_output() =
    printfn "[%-5s]" "X"     // pad-right
    printfn "[%5s]" "X"      // pad-left
    printfn "[%*s]" 5 "X"    // pad-left by 5
    printfn "[%*s]" 10 "X"   // pad-left by 10 (but negative doesn't work :/ )

////////////////////////////////////////////////////////////////////////////////////////////////////////    
////////////////////////////////////////////////////////////////////////////////////////////////////////    

let bind_test() =
    let mutable weight = 123
    printfn "weight is %i\n" weight
    weight <- 456                        // This only works because weight is mutable. Remove mutable and we get a compile-time error
    printfn "weight is now %i\n" weight

    let height = ref 123
    printfn "height is %i\n" !height     // Needs exclamation mark to dereference the reference
    height := 456
    printfn "height is now %i\n" !height // Needs exclamation mark to dereference the reference
    
bind_test()

//Stopped at 12 mins
//https://www.youtube.com/watch?v=c7eNDJN758U&list=PLGLfVvz_LVvSX7fVd4OUFp_ODd86H0ZIY&index=47&t=0s

Console.ReadKey |> ignore