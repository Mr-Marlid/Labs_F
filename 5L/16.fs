open System

let rec NOD x y z=
    let z1 = z-1
    if z=1 then 1 
    else if x%z=0 && y%z=0 then z
    else NOD x y z1

let rec f x func s a =
        if a <> 0 then 
            let s1= if NOD x a a <> 1 then func s a else s
            let a1 = a - 1
            f x func s1 a1
        else
            s


let rec e x func s a = 
        if x <> 1 then 
            if x%a=0 then 
                let x1 = x/a
                let s1 = func s a-1
                e x1 func s1 a
            else
                let a1 = a + 1
                e x func s a1
        else
            s

let  E x func s =
    e x func s 2

let F x func s =
    f x func s x
        
[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите число: ")
    let x = int(Console.ReadLine())
    let res = F x (fun x y -> x+y) 0
    Console.Write("Результат NOD: ")
    Console.WriteLine res

    let res1 = E x (fun x y -> x*y) 1
    Console.Write("Результат E: ")
    Console.WriteLine res1
    0
