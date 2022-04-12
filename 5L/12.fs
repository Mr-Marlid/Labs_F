open System

let f s = 
    match s with
        |"F#" | "Prolog" -> "Подлиза"
        |"python" -> "Ну, можешь забыть его до 3 курса"
        |"С++" -> "А, это что-то типо паскаля?"
        |"ruby" -> "Не смей."
        |"С#" -> "Садо-мазо?"
        |other -> "Мы таких не понимаем"

[<EntryPoint>]
let main argv =
    //12.1
    (Console.ReadLine>>f>>Console.WriteLine)()
    //12.2
    let F input (output:string->unit) f = output(f(input()))
    F Console.ReadLine Console.WriteLine f
    0
