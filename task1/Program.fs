open System
 
let input () =
    printfn "Введите количество строк:"
    let cnt = int(Console.ReadLine())
    if cnt >= 1
    then
        printfn "Вводите строки: "
        cnt
    else
        0

let rec BuildList cnt = 
    if cnt <= 0 then 
        []
    else 
        let input = Console.ReadLine()
        input :: BuildList (cnt-1)

[<EntryPoint>]
let main args = 
    let cnt = input()
    if cnt >0 then 
        let result = BuildList cnt
        printfn "Результат: %A" result
    else
        eprintfn "неверное значение "
    0


