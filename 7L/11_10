//Даны два массива. Необходимо найти количество совпадающих по значению элементов.

let rec sovpad list list1 n =
    match list with
    |h::t ->
        let isSame x y = x=y
        match List.tryFind (isSame h) list1 with
        |Some value -> 
            let n1 = n+1
            sovpad t list1 n1
        |None -> sovpad t list1 n
    |[]-> n
[<EntryPoint>]
let main argv =
    
    
    let x = [1;2;3;4;5;6;7]
    let y = [1;2;8;9]
    
    printfn "%A" "Answer:"
    printfn "%A" (sovpad x y 0 )
    0
