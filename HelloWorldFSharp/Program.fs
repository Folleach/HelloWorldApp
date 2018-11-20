open System

let writeText = printf "F#\nHello World!"

[<EntryPoint>]
let main argv =
    writeText
    Console.ReadKey()
    0
