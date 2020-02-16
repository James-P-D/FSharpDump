open System
open output_examples
open bind_examples
open function_examples
open maths_examples
open string_examples
open loop_examples
open conditional_examples
open list_examples
open enum_examples
open option_examples
open tuple_examples
open record_examples
open sequence_examples
open map_examples
open generics_examples
open exception_examples
open struct_examples
open class_examples

// ----------------- output_examples ----------------- //

hello()
padded_output()

// ------------------ bind_examples ------------------ //

bind_test()

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

// ------------------ maths_examples ----------------- //

do_math_examples()

// ----------------- string_examples ----------------- //

do_string_examples()

// ------------------ loop_examples ------------------ //

do_loop_examples()

// --------------- conditional_examples -------------- //

do_conditional_examples()

// ------------------ list_examples ------------------ //

do_list_examples()

// ------------------ enum_examples ------------------ //

do_enum_examples()

// ----------------- option_examples ----------------- //

do_option_examples()

// ----------------- tuple_examples ------------------ //

do_tuple_examples()

// ---------------- record_examples ------------------ //

do_record_examples()

// --------------- sequence_examples ----------------- //

do_sequence_examples()

// ----------------- map_examples -------------------- //

do_map_examples()

// --------------- generics_examples ----------------- //

do_generics_examples()

// -------------- exception_examples ----------------- //

do_exception_examples()

// ---------------- struct_examples ------------------ //

do_struct_examples()

// ----------------- class_examples ------------------ //

do_class_examples()

Console.ReadKey |> ignore