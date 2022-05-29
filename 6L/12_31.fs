//Дан целочисленный массив. Найти количество чётных элементов.
open System
let rec kol l n func =
    match l with
    | h::t -> 
        if h%2=0 then
            let n1 = func n
            kol t n1 func
            
        else
             kol t n func
            
    |[] -> n


[<EntryPoint>]
let main argv =
    
    let x = [1;2;3;4;5;6;7]
    
    printfn "%A" "Answer:"
    printfn "%A" (kol x 0 (fun x -> x+1))
    0
