module conditional_examples
open System

let do_conditional_examples() =

    // ----- IF ELSE ELIF -----
    let age = 8
    if age < 5 then
        printfn "Preschool"
    elif age = 5 then 
        printfn "Kindergarten"
    elif (age > 5) && (age <= 18) then
        let grade = age - 5
        printfn "Go to Grade %i" grade
    else
        printfn "Go to College"
            
    // ----- MATCH -----
    // You can use match and guard statements
    // to do the same thing
    let grade2: string = 
        match age with
        | age when age < 5 -> "Preschool"
        | 5 -> "Kindergarten" 
        | age when ((age > 5) && (age <= 18)) -> (age - 5).ToString()
        | _ -> "College"   // Else case
 
    printfn "Grade2 : %s" grade2
 