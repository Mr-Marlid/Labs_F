//Чё?
//Дан целочисленный массив и отрезок a..b. Необходимо найти
//элементы, значение которых принадлежит этому отрезку.
open System
let rec prov l l1 x y index func =
    let index1 = func index
    match l with
    |h::t-> 
        
        if (x<=index && index<=y) then 
            
            let l2 = h::l1
            prov t l2 x y index1 func
        else 
                
            
            prov t l1 x y index1 func
        
    |[]->l1

[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите число a: ")
    let a = int(Console.ReadLine())
    Console.WriteLine("Введите число b: ")
    let b = int(Console.ReadLine())
    
    let x = [1;2;3;4;5;6;7]
    
    printfn "%A" "Answer:"
    printfn "%A" (prov x [] a b 0 (fun x -> x+1))
    0
