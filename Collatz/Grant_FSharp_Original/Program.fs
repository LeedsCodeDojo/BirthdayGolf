let isEven n = n % 2 = 0

[<EntryPoint>]
let main argv = 

    let rec sequence = function
        | 1 -> [1]
        | n when isEven n -> n::sequence (n/2)
        | n -> n::sequence (3 * n + 1)

    let arg = int argv.[0]
    printfn "%i" (sequence arg).Length
    0
