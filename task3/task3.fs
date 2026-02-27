open System

let Add (a, b) (c, d) = (a + c, b + d)
let Sub (a, b) (c, d) = (a - c, b - d)
let Mul (a, b) (c, d) = (a * c - b * d, a * d + b * c)

let Div (a, b) (c, d) =
    let denom = c * c + d * d
    if denom = 0.0 then
        eprintfn "Ошибка: знаменатель равен 0!"
        (0.0, 0.0) 
    else
        ((a * c + b * d) / denom, (b * c - a * d) / denom)

let rec Pow (a, b) n =
    if n <= 0 then 
        (1.0, 0.0)
    else 
        Mul (a, b) (Pow (a, b) (n - 1))

let readComplex msg =
    printfn "Введите %s (Re, затем Im):" msg
    let re = float(Console.ReadLine())
    let im = float(Console.ReadLine())
    (re, im)

let calc symb =
    if symb = "^" then
        let z = readComplex "число"
        printfn "Введите степень (целое число):"
        let n = int(Console.ReadLine())
        Pow z n
    else
        let z1 = readComplex "первое число"
        let z2 = readComplex "второе число"
        if symb = "+" then Add z1 z2
        elif symb = "-" then Sub z1 z2
        elif symb = "*" then Mul z1 z2
        elif symb = "/" then Div z1 z2
        else 
            printfn "Неизвестная операция"
            (0.0, 0.0)

[<EntryPoint>]
let main args = 
    printfn "Введите операцию: + - * / ^"
    let symb = Console.ReadLine()

    let result = calc symb
    printfn "Результат: %A" result
    
    0
