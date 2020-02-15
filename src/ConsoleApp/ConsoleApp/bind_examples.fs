module bind_examples
open System

let bind_test() =
    let mutable weight = 123
    printfn "weight is %i" weight

    let another_weight = weight
    printfn "another_weight is %i" another_weight
    weight <- 456                        // This only works because weight is mutable. Remove mutable and we get a compile-time error
    printfn "weight is now %i" weight
    printfn "another_weight is now %i" another_weight // another_weight is *still* 123 and has not changed to 456

    let height = ref 123
    printfn "height is %i" !height     // Needs exclamation mark to dereference the reference
    
    let another_height = height          // Create another reference to height
    printfn "another_height is %i" !another_height // Needs exclamation mark to dereference the reference
    
    height := 456
    printfn "height is now %i" !height // Needs exclamation mark to dereference the reference
    printfn "another_height is now %i" !another_height // Even though another_height hasn't changed, because it also references height, it *has* changed
    
