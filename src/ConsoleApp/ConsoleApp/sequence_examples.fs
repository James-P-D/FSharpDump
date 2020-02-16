module sequence_examples
open System

let do_sequence_examples() =

    // Sequences are infinite data structures that 
    // aren't defined until needed
 
    // You can have a list made from a range
    let seq1 = seq { 1 .. 100 }
    printfn "seq1 = %A" seq1
    
    // Descending sequence but it won't work because starting at 50 and going up to 1 creates an empty sequence
    // (See seq4 for a real descending sequence)
    let seq2 = seq { 50 .. 1 }
    printfn "seq2 = %A" seq2
    
    // You can use a range of evens
    // Start at zero, end at 50, increment at 2
    let seq3 = seq { 0 .. 2 .. 50 }
    printfn "seq3 = %A" seq3
    
    // Descending sequence
    let seq4 = seq { 50 .. -1 .. 1 }
    printfn "seq4 = %A" seq4

    // Note these only printed the first 4 elements. If we want to print all the elements,
    // then we have to convert it to a list
    printfn "seq4 as list = %A" (Seq.toList(seq4))

    // create function to check if number is prime
    let is_prime n =
        let rec check i =
            // i is prime if its greater than n/2
            // or if n is not divisable by i and i+1 is also prime
            i > n/2 || (n % i <> 0 && check (i + 1))
        check 2
 
    // If is_prime returns true then add to the sequence
    let prime_seq = seq { for n in 1..500 do if is_prime n then yield n }
 
    printfn "prime_seq = %A" prime_seq