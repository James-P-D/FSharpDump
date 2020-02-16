module generics_examples
open System

let add_stuff<'T> x y =
    printfn "%A" (x + y)

let do_generics_examples() =
    //add_stuff<float> 5.5 2.4
    add_stuff<int> 5 2