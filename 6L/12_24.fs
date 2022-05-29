//Дан целочисленный массив. Необходимо найти два наибольших элемента.
open System
let rec maximum l max1 max2 =
    match l with
    | h::t -> 
        if h>max1 then
            if h>max2 then
                maximum t max2 h
            else 
                maximum t h max2
           
            
        else
            maximum t max1 max2
            
    |[] -> max1,max2


[<EntryPoint>]
let main argv =
    
    let x = [1;2;3;4;5;6;7]
    
    printfn "%A" "Answer:"
    printfn "%A" (maximum x -2 -1)
    0
