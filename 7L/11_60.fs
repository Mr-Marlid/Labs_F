//Дан список. Построить массив из элементов, делящихся на свой номер и встречающихся в исходном массиве 1 раз.
open System



let rec f1 list index list1 k =
    
    match list with
    |h::t ->
        let index1 = index + 1
        if (h % index = 0) then
            

            let rec f2 list x ind ind1=
                match list with
                |h::t->
                    let index2 = ind + 1
                    if h = x && ind = ind1 then 
                        
                        false
                    else f2 t x index2 index1
                |[]->true

           
            if (f2 list1 h 1 index) then
                
                let k1 = k+1
                f1 t index1 list1 k1
            else f1 t index1 list1 k
        else f1 t index1 list1 k
    |[]-> k




[<EntryPoint>]
let main argv =
    
    
    let x = [1;1;3;8]
    let Count = f1 x 1 x 0
    
    printfn "%A" "Answer:"
    printfn "%A" Count
    0 
