// Learn more about F# at http://fsharp.org

open System
open System.IO
open FSharpx

[<EntryPoint>]
let main argv =
    let sumOfFile = "./data.txt" 
                    |> File.ReadAllText
                    |> String.splitChar [|','|]
                    |> Array.sumBy Int64.Parse
    
    let sumOfSeq = seq {0L..100000L}
                   |> Seq.sum
    
    let missingNumber = sumOfSeq-sumOfFile
    
    printf "I think that %d is missing" missingNumber
    
    0
