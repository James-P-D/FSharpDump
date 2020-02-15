open System
open output_examples
open bind_examples
open function_examples

// ----------------- output_examples ----------------- //

//hello()
//padded_output  

// ------------------ bind_examples ------------------ //

//bind_test()

// ---------------- function_examples ---------------- //

printfn "5 + 10 = %i" (get_sum(5, 10))
printfn "5 + 10 = %i" (get_int_sum(5, 10))
printfn "Factorial 4 = %i" (factorial 4)
printfn "rand_list = %A" rand_list
printfn "long_list = %A" long_list
printfn "rand_list2 = %A" rand_list2
printfn "even_and_then_double_list = %A" even_and_then_double_list
printfn "mult_add : %i" (mult_add 10)
printfn "add_mult : %i" (add_mult 10)

//Stopped at 12 mins
//https://www.youtube.com/watch?v=c7eNDJN758U&list=PLGLfVvz_LVvSX7fVd4OUFp_ODd86H0ZIY&index=47&t=0s

Console.ReadKey |> ignore