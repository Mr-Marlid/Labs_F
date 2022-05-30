open System

type Passport(first:string ,surname: string,last: string,series:int, number: int,date: string) =
    //параметры конструктора
    member this.Firstname:string  = first
    member this.Surname:string = surname
    member this.Lastname:string = last
    member this.Number:int = number
    member this.Series:int = series
    member this.Date = date

    //Вывод элементов:
    member this.Print() = printfn $"Паспорт:Фамилия: {this.Firstname}
    Имя:{this.Lastname}
    Отчество:{this.Lastname}
    дата рождения: {this.Date}
    Серия и Hомер:{this.Series} {this.Number}" 


[<EntryPoint>]
let main argv =
   printfn "Введите ФИО"
   let Firstname = System.Console.ReadLine();
   let Surname = System.Console.ReadLine();
   let Lastname = System.Console.ReadLine();
   printfn "Введите серию и номер паспорта(серия 4 цифры, а номер 6 цифр) "
   let series =System.Convert.ToInt32(System.Console.ReadLine());
   let number = System.Convert.ToInt32(System.Console.ReadLine());
   printfn "Введите дату рождения (формат дд.мм.гггг)"
   let date = System.Console.ReadLine();

   let passport_1 = Passport(Firstname,Surname,Lastname,series,number,date)
   passport_1.Print()
   0 
