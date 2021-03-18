module Basics 

let x:int32 = 10 // variable declaration with type
let p:float = 3.14 
let mutable mut = 100
let mutable mutfl:float = 1.0

let variables = 
    //x <- 11 - error - this type is noy mutable
    mut <- 110 // you can mutate value - assignement
    printfn "x: %i;" x // printing x out
    printfn "mut: %i;" mut
    mut <- 10 % 3 // modulus operator
    mutfl <- 10.0 ** 4.0 // exponential operator
    
let main =
    printfn "Hello from new module"
    variables
    0
