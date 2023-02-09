let num1 = 3
let num2 = 1

let suma x y = x + y
let resta x y = x - y
let multiplicar x y = x * y
let dividir x y = x / y

let str = "Hola desde F# jeje"

let resultsuma = suma num1 num2
let resultresta = resta num1 num2
let resultmulti = multiplicar num1 num2
let resultdiv = dividir num1 num2

System.Console.WriteLine(str) 
//let val = Console.ReadLine()
printfn $"El resultado de la suma es: %d{resultsuma}"
printfn $"El resultado de la resta es: %d{resultresta}"
printfn $"El resultado de la multiplicacion es: %d{resultmulti}"
printfn $"El resultado de la division es: %d{resultdiv}"

open Microsoft.AspNetCore.Builder
open System

let builder = WebApplication.CreateBuilder()
let app = builder.Build()
app.MapGet("/", Func<string>(fun () -> "Hola desde F# jeje" + "\n" +
 $"El resultado de la suma es: %d{resultsuma}" + "\n" +
 $"El resultado de la resta es: %d{resultresta}" + "\n" +
 $"El resultado de la multiplicacion es: %d{resultmulti}" + "\n" +
 $"El resultado de la division es: %d{resultdiv}"
 )) |> ignore
app.Run()