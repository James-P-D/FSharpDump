module function_examples
open System

// We can create functions
let get_sum(x, y) = x + y

// We can create functions that specify input parameter and return value data-types
let get_int_sum (x : int, y : int) : int = x + y

// We can create recursive functions
let rec factorial x =   
    if x < 1 then 1
    else x * factorial (x - 1)
 
// Create a list with elements 1, 2 and 3
let rand_list = [1;2;3]

// Create a list with range 1, 2, 3..99, 100
let long_list = [1..100]

// Use List.map to apply a function to every element in rand_list
let rand_list2 = List.map (fun x -> x * 2) rand_list

let even_and_then_double_list =
    [1..10]
    // Filter keeps only items in the list that are even
    |> List.filter (fun v -> (v % 2) = 0)
    // Double them
    |> List.map (fun x -> x * 2)

// We can also apply multiple functions using << and >>
let mult_num x = x * 3
let add_num n = n + 5

let mult_add = mult_num >> add_num
let add_mult = mult_num << add_num

// We can call functions mutually with 'and'
let rec doubler some_list =
    match some_list with
    | [] -> 0
    | head::tail -> (head * 2) + tripler(tail)
and tripler some_list =
    match some_list with
    | [] -> 0
    | head::tail -> (head * 3) + doubler(tail)
      
//printfn "%A" (doubler([1..10]))
       