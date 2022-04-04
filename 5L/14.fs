﻿open System
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
    Console.WriteLine("Number: ")
    let x = int(Console.ReadLine())
    let result = F x (fun x y -> x+y) 0
    Console.Write("Result: ")
    Console.WriteLine result
    0