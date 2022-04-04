open System

let f s = 
    match s with
        |"F#" | "Prolog" -> printfn "Подлиза"
        |"python" -> printfn "Ну, можешь забыть его до 3 курса"
        |"С++" -> printfn "А, это что-то типо паскаля?"
        |"ruby" -> printfn "Не смей."
        |"С#" -> printfn "Садо-мазо?"
        |other -> printfn "Мы таких не понимаем"

[<EntryPoint>]
let main argv =
    printfn "Введите свой любимый язык программирования:"
    let s = Console.ReadLine()
    f s
    0