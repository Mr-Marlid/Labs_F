open System
//Написать функцию, принимающую в качестве аргумента
//список и функцию трех переменных, и возвращающую новый список
//длины в три раза меньше, где каждый элемент — это результат
//применения функции к соответствующей тройке. На основе этой
//функции модифицировать введенный пользователем список так, чтобы
//каждый элемент нового списка был суммой соответствующей тройки,
//если количество элементов не делится на три, то в качестве
//недостающих элементов использовать единицы.
let rec F list n =
    if (n>0) then
        let x = int(Console.ReadLine())
        let L = x :: list
        let n1 = n - 1
        F L n1
    else list
let rec f11 list L func x y
    match list with
    |head::tail ->  
        if (x<>0) then 
            if (y<>0) then 
                let L1 = (func x y head)::L
                f11 tail L1 func 0 0
            else 
                f11 tail L func x head
        else 
            f11 tail L func head y
    |[]->
        if (x<>0) then
            if (y<>0) then 
               let L1 = (func x y 1)::L
            else let L1 = (func x 1 1)::L
        else let L1 = L
        L1

let  F11 list func
    f11 list [] func 0 0

[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите число: ")
    let n = int(Console.ReadLine())
    let list = []
    let L = F list n
    let res = F11 L (func x y z -> x+y+z)
    Console.WriteLine res
    0
