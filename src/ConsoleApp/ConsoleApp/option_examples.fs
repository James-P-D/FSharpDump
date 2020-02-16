module option_examples
open System

let do_option_examples() =

    // Options are used when a function may not return a value
    let divide x y =
        match y with
        | 0 -> None
        | _ -> Some(x/y)
 
    if (divide 5 0).IsSome then
        printfn "5 / 0 = %A" ((divide 5 0).Value)
    elif (divide 5 0).IsNone then
        printfn "Can't Divide by Zero"
    // Frankly not really sure why this last case it here :D
    //else
    //    printfn "Something Happened"