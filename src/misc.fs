open System

// *************************************************************************************

let Sum a b = a + b
//let int1 = 10
//let int2 = 20
// printfn "sum = %d" (Sum int1 int2)

// *************************************************************************************

let Swap (a, b) = (b, a)
//let int1 = 10
//let int2 = 20
// let (int3, int4) = Swap(int1, int2)

// *************************************************************************************

let AddQuestionMark x = x + "?"
//printfn "%s" (AddQuestionMark "hello")

// *************************************************************************************

let ToPosNegZero x = if x > 0 then "positive"
                     elif x < 0 then "negative"
                     else "zero"
//let x = -1
//printfn "%d is %s" x (ToPosNegZero x)
//let x = x + 1
//printfn "%d is %s" x (ToPosNegZero x)
//let x = x + 1
//printfn "%d is %s" x (ToPosNegZero x)

// *************************************************************************************

let rec SumList l = match l with
                    | [] -> 0
                    | head::tail -> head + (SumList tail)
//printfn "sum = %d" (SumList [1; 2; 3])
//printfn "sum = %d" (SumList [1..10])

// *************************************************************************************

let rec DisplayList l = match l with
                        | [] -> "\n"
                        | head::tail -> head.ToString() + " " + (DisplayList tail)
//printfn "%s" (DisplayList [1..10])

// *************************************************************************************

let GenerateList x y = [x..y]
//printfn "%s" (DisplayList (GenerateList 1 10))

// *************************************************************************************

let SquaresOfXToY x y = [ for i in x..y -> i*i ]
//printfn "%s" (DisplayList (SquaresOfXToY 1 10))

// *************************************************************************************

let rec DoubleList l = match l with
                       | [] -> []
                       | head::tail -> head * 2::DoubleList tail
//printfn "%s" (DisplayList (DoubleList [1..5]))

// *************************************************************************************

//let arr = Array.create 4 "hello"
//arr.[1] <- "world"
//arr.[3] <- "don"
//let arrLength = arr.Length        
//let front = arr.[0..2]

// *************************************************************************************

//let lookupTable = dict [ (1, "One"); (2, "Two") ]
//let oneString = lookupTable.[1]

// *************************************************************************************

let Square x = x*x              
let SquareList l = List.map Square l
let SquareSquareList l = l |> List.map Square |> List.map Square
//printfn "%s" (DisplayList (SquareList [1..5]))
//printfn "%s" (DisplayList (SquareSquareList [1..5]))

// *************************************************************************************

type Expr = 
  | Num of int
  | Add of Expr * Expr
  | Mul of Expr * Expr
  | Var of string

// First paramter 'env' of type map string to int,
// Second paramter expression
let rec Evaluate (env:Map<string,int>) exp = 
  match exp with
    | Num n -> n
    | Add (x,y) -> Evaluate env x + Evaluate env y
    | Mul (x,y) -> Evaluate env x * Evaluate env y
    | Var id    -> env.[id]

// Create the environment
let envA = Map.ofList [ "a",1 ;
                        "b",2 ;
                        "c",3 ]
// Create the expression
let expT1 = Add(Var "a", Mul(Num 2, Var "b"))

// Evaluate expT1 using environment envA
let resT1 = Evaluate envA expT1

// *************************************************************************************

let IntegerDoubleOnly (x:int) = x * 2
//printf "%d" (IntegerDoubleOnly 5) // Works
//printf "%d" (IntegerDoubleOnly 5) // Fails

// *************************************************************************************
// *************************************************************************************

