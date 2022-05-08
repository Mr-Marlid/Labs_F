open System
let F x func s =
    let rec f x func s a =
        if a <> 0 then 
            let s1= if x % a = 0 then func s a else s
            let a1 = a - 1
            f x func s1 a1
        else
            s
    f x func s x
        
[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите число: ")
    let x = int(Console.ReadLine())
    Console.WriteLine("Введите функцию: ")
    let J = string(Console.ReadLine())
    match J with
    |"Сумма" |"сумма" -> 
        let res = F x (fun x y -> x+y) 0
        Console.Write("Результат: ")
        Console.WriteLine res
    |"Произведение"|"Произведение" ->
        let res = F x (fun x y -> x+y) 0
        Console.Write("Результат: ")
        Console.WriteLine res
    |"Минимум"|"минимум" ->
        let res = F x (fun x y -> if (x<y) then x else y) 0
        Console.Write("Результат: ")
        Console.WriteLine res
    |"Максимум"|"максимум" ->
        let res = F x (fun x y -> if (x>y) then x else y) 0
        Console.Write("Результат: ")
        Console.WriteLine res
    0
