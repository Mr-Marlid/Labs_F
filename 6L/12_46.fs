//Дан целочисленный массив. Необходимо вывести вначале его
//положительные элементы, а затем - отрицательные.
open System
let rec otric l l1 func =
    
    match l with
    |h::t-> 
        if func h then 
           
            let l2 = h::l1
            otric t l2 func
        else otric t l1 func
    |[]-> l1
let rec pol l l1 func =
    
    match l with
    |h::t-> 
        if func h then 
           
            let l2 = h::l1
            otric t l2 func
        else otric t l1 func
    |[]-> l1
[<EntryPoint>]
let main argv =
    
    
    let x = [-1;2;-3;4;-5;6;-7]
    let list = otric x [] (fun x -> x < 0 )
    printfn "%A" "Answer:"
    printfn "%A" (pol x list (fun x -> x > 0) )
    0
