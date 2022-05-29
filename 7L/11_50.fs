//Для двух введенных списков L1 и L2 построить новый список,
//состоящий из элементов, встречающихся только в одном из этих списков и
//не повторяющихся в них.
open System
let rec F list list1 list2 =
    match list with
    |H::T->
        
        let isEven x = (x = H)
        if (match List.tryFind isEven list1 with
|           Some value -> false
|           None -> true) then
            let list3 = H::list2
            F T list1 list3
        else F T list1 list2
    |[]->list2
[<EntryPoint>]
let main argv =
    
    
    let x = [1;3;3;4;5;6;7]
    let y = [8;9;10;11;1;3;2]
    let z =F x y []
    
    printfn "%A" "Answer:"
    printfn "%A" (F y x z)
    0
