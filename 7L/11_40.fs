//Дан целочисленный массив. Необходимо найти минимальный четный элемент.
open System

[<EntryPoint>]
let main argv =
    
    
    let x = [1;3;3;4;5;6;7]
    let F number elem = elem % number = 0
    printfn "%A" "Answer:"
    printfn "%A" (List.find (F 2)(List.sort x))
    0
