//Дан целочисленный массив. Необходимо найти все пропущенные числа.
open System



let rec f1 list x list2=
    match list with
    |h::t ->
        let x1 = x+1
        let list1 = [ for i in x1 .. h -> i ]
        let list3 = list1@list2
        
        f1 t h list3
    |[]-> list2



let rec reverse list1 list2 =
    match list1 with
    |h::t ->
        let list3 = h::list2
        reverse t list3
    |[]->list2


[<EntryPoint>]
let main argv =
    
    
    let x = [1;6;7]
    let sortedX = List.sort x
    let a = sortedX.Head
    let b = sortedX.Tail
    let list1 =a::(f1 b a [])
    let list2 = List.sort list1
    printfn "%A" "Answer:"
    printfn "%A" list2
    0 
