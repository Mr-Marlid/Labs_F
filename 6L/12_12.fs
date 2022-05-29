//Дан целочисленный массив. Необходимо переставить в обратном
//порядке элементы массива, расположенные между его минимальным и
//максимальным элементами.
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
    |[] -> 
        
        minindex

let rec maximum l max maxindex index func =
    let index1 = func index
    match l with
    | h::t -> 
        if h>max then
            let max1 = h
            let maxindex1 = index
            maximum t max1 maxindex1 index1 func
        else
            maximum t max maxindex index1 func
    |[] -> maxindex

let rec reverse l l1 =
    match l with
    | h::t -> 
        let l2 = h::l1
        reverse t l2
    |[] -> l1
let rec prov l l1 l2 x y index func =
    let index1 = func index
    match l with
    |h::t-> 
        match l1 with
        |H::T->
            if (x<index && index<y) then 
                printfn "%A" index
                let l3 = h::l2
                prov t T l3 x y index1 func
            else 
                
                let l3 = H::l2
                prov t T l3 x y index1 func
        |[]->l2
    |[]->l2

[<EntryPoint>]
let main argv =
    let a = [1;2;3;4;5;6;7]
    let x = minimal a 100 0 0 (fun x -> x+1)
    
    let y = maximum a -1 0 0 (fun x -> x+1)
    
    let a1 = reverse a []
    if x<y then
        printfn "%A" (prov a a1 [] x y 0 (fun x -> x+1))
    else
        printfn "%A" (prov a a1 [] y x 0 (fun x -> x+1))
    
    0
