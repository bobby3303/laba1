open System

let rec BuildList () = 
    let input = Console.ReadLine()
    if input = "" 
    then []
    else 
        input :: BuildList ()

[<EntryPoint>]
let main args = 
    printfn "Введите строки:"
    let result = BuildList()
    printfn "Результат: %A" result
    0


