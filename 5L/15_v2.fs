open System
let rec prost x y z=
    let z1 = z-1
    if z=1 then 1 
    else if x%z=0 && y%z=0 then z
    else prost x y z1
let rec f x func s a =
        if a <> 0 then 
            let s1= if prost x a a = 1 then func s a else s
            let a1 = a - 1
            f x func s1 a1
        else
            s
let F x func s =
    f x func s x-1

[<EntryPoint>]
let main argv =
    printfn "%A" ("Введите число:")
    let x = int(Console.ReadLine())
    printfn "%A""Введите функцию: "
    let s = string(Console.ReadLine())
    printfn "%A" "Обход взаимно простых компонентов числа"
    match s with
    |"Сумма" |"сумма" -> printfn "%A" (F x (fun x y -> x+y) 0)
    |"Произведение"|"Произведение" -> printfn "%A" (F x (fun x y -> x+y) 0)
    |"Минимум"|"минимум" -> printfn "%A" (F x (fun x y -> if (x<y) then x else y) 0) 
    |"Максимум"|"максимум" -> printfn "%A" (F x (fun x y -> if (x>y) then x else y) 0)
    0
