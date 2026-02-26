open System
let rec StrSum () =
    let input = Console.ReadLine()
    if input = ""
    then 0
    else input.Length + StrSum()

[<EntryPoint>]
let main args = 
    printfn "Введите строки; конец ввода - пустая строка:"
    let result = StrSum()
    printfn "Результат: %i" result
    0