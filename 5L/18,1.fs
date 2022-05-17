open System

let rec prost x y z=
    let z1 = z-1
    if z=1 then 1 
    else if x%z=0 && y%z=0 then 0
    else prost x y z1

let rec f x n a = 
    let n1 =n+1
    let a1 = a-1
    if a<>1 then    
        if prost x a a = 0 && a % 2 = 0 then 
            f x n1 a1
        else f x n a1
    else 
        n

        
[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите число: ")
    let x = int(Console.ReadLine())
    let x1 = x-1
    let res = f x 0 x1
    Console.Write("Результат: ")
    Console.WriteLine res
    0
