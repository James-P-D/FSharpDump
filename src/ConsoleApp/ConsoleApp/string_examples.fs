module string_examples
open System

let do_string_examples() =
    // Escape characters
    // \n, \\, \", \'
    let str1 = "This is a random string"
    printfn "str1 = %s" str1

    // Verbatim Strings
    let str2 = @"I ignore backslashes \t ok?"
    printfn "str2 = %s" str2
 
    // Triple Quoted Strings
    let str3 = """ "I ignore double quotes and backslashes" """
    printfn "str3 = %s" str3
 
    // Combine strings
    let str4 = str1 + " " + str2
    printfn "str4 = %s" str4
 
    // Get length
    printfn "Length of str4 = %i" (String.length str4)
 
    // Access index
    printfn"1st (zero-indexed) character in str1 = %c" str1.[1]  
 
    // Get a substring with a range
    printfn"Substring 0..3 in str1 = %s" (str1.[0..3])
 
    // Collect executes a function on each character
    let str1_char = String.collect (fun c -> sprintf "%c, " c) str1
    printfn "Applying to each char in str1 : %s" str1_char
 
    // Exists checks if any characters meet a condition
    printfn "Does str1 contain uppercase characters?  %b" (String.exists (fun c -> Char.IsUpper(c)) str1)
 
    // Check if every character meets condition
    printfn "Does str1 contain only numbers? %b" (String.forall (fun c -> Char.IsDigit(c)) str1)
 
    // Apply function to each index in a string
    let number_str = String.init 10 (fun i -> i.ToString())  
    printfn"Numbers : %s" number_str
 
    // Apply function to each item in string
    String.iter(fun c -> printfn "[%c]" c) number_str