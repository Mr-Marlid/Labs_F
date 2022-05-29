open System
let rec sovpad list max n  =
    let N = n+1
    match list with
    |h::t ->
        if h>max then 
            let max1 = h
            
            sovpad t max1 N 
        else sovpad t max N 
    |[]-> max
[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите индекс: ")
    let n = int(Console.ReadLine())
    
    let x = [1;2;3;4;5;6;7]
    
    if (sovpad x -1 0) = (x.Item(n)) then
        printfn "%A" "Yes"
        
    else
        printfn "%A" "No"
    0
