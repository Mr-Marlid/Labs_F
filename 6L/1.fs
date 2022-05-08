open System

let rec F list n =
    if (n>0) then
        let x = int(Console.ReadLine())
        let L = x :: list
        let n1 = n - 1
        F L n1
    else list
[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите число: ")
    let n = int(Console.ReadLine())
    let list = []
    let res = F list n
    Console.WriteLine res
    0
