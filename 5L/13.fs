open System

let rec F2 a s =
    match a with
    |0 -> s
    |a -> F2 (a/10) ((a%10)*s)

let rec F1 a =
    if (a <> 0) then (a%10) * F1 (a/10)
    else 1
        
[<EntryPoint>]
let main argv =
    printfn "Введите число:"
    let a = int(Console.ReadLine())
    printfn "Up:"
    Console.WriteLine(F1 a)
    printfn "Down:"
    Console.WriteLine(F2 a 1)
    0