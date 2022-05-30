type Passport(first:string ,surname: string,last: string,series:int, number: int,date: string) =
    //параметры конструктора
    member this.Firstname:string  = first
    member this.Surname:string = surname
    member this.Lastname:string = last
    member this.Number:int = number
    member this.Series:int = series
    member this.Date = date
