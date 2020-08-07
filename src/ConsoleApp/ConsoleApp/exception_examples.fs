module exception_examples
open System

let do_exception_examples() =
    let divide x y =
        try
            printfn "%.2f / %.2f = %.2f" x y (x / y)
        with
            | :? System.DivideByZeroException -> printfn "Can't Divide by Zero"
 
    divide 5.0 4.0
