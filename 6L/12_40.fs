//Дан целочисленный массив. Необходимо найти минимальный
//четный элемент.
open System
let rec minimal l min func =
    
    match l with
    |h::t-> 
        if func h min && h%2=0 then 
            let min1 = h
            minimal t min1 func
        else minimal t min func
    |[]-> min

[<EntryPoint>]
let main argv =
    
    
    let x = [1;2;3;4;5;6;7]
    let min = minimal x 1000 (fun x y -> x<y)
    if min = 1000 then  
        printfn "%A" "Answer: Nothing :("
    else
        printfn "%A" "Answer:"
        printfn "%A" min
    0
