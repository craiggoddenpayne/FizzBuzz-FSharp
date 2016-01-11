open FizzBuzz

[<EntryPoint>]
let main args =
    for i in [1..100] do
        System.Console.WriteLine(FizzBuzz.Compute(i))
    let a = System.Console.ReadKey()
    0 