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
 
let rand_list = [1;2;3]
