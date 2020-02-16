module enum_examples
open System

// Create the enum. Make sure this is done outside of the 'let'
type emotion =
    | joy = 0
    | fear = 1
    | anger = 2
    | love = 3
    | jealousy = 4

let do_enum_examples() =
    let my_feeling = emotion.love
 
    // Match on various fields and use '_' for anything unmatched
    // Also not that we need to qualify the cases with 'emotion'!
    match my_feeling with
    | emotion.joy -> printfn "I'm joyful"
    | emotion.fear -> printfn "I'm fearful"
    | emotion.anger -> printfn "I'm angry"
    | _ -> printfn "I'm something else"