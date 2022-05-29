// Дан целочисленный массив. Необходимо найти элементы,
//расположенные перед последним минимальным.
open System
let rec minimal l min minindex index func =
    let index1 = func index
    match l with
    | h::t -> 
        if h<min then
            let min1 = h
            let minindex1 = index
            minimal t min1 minindex1 index1 func
        else
            minimal t min minindex index1 func
    |[] -> minindex

let rec posle l minindex index func=
    let index1 = func index
    match l with
    | h::t -> 
        if index>minindex then printfn "%A" h
        posle t minindex index1 func
    |[] -> ignore

[<EntryPoint>]
let main argv =
    let a = [1;2;3;4;5;6;7]
    let x = minimal a 100 0 0 (fun x -> x+1)
    posle a x 0 (fun x -> x+1)
    
    
    0
