//Дан целочисленный массив и интервал a..b. Необходимо найти
//количество минимальных элементов в этом интервале.
open System
let rec minimal l min =
    match l with
    | h::t -> 
        if h<min then
            
            let min1 = h
           
            minimal t min1 
        else
            minimal t min 
    |[] -> 
        
        min




let rec prov l x y z n index func =
    let index1 = func index
    match l with
    |h::t-> 
        if x<=index && index<=y then
            
            if h = z then 
                
                let n1 = func n
                prov t x y z n1 index1 func
            else prov t x y z n index1 func
        else prov t x y z n index1 func
    |[]-> n

[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите число a: ")
    let a = int(Console.ReadLine())
    Console.WriteLine("Введите число b: ")
    let b = int(Console.ReadLine())
    
    let x = [1;2;3;4;5;6;7]
    let min = minimal x 1000
    printfn "%A" "Answer:"
    printfn "%A" (prov x a b min 0 0 (fun x -> x+1))
    0
