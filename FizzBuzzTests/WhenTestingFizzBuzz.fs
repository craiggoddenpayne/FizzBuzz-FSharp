module WhenTestingFizzBuzz

open NUnit.Framework

[<Test>]
let WhenCallingComputeWith1ItShouldReturn1() = Assert.That(FizzBuzz.Compute 1, Is.EqualTo 1)

[<Test>]
let WhenCallingComputeWith2ItShouldReturn2() = Assert.That(FizzBuzz.Compute 2, Is.EqualTo 2)

[<Test>]
let WhenCallingComputeWith3ItShouldReturnFizz() = Assert.That(FizzBuzz.Compute 3, Is.EqualTo "Fizz")

[<Test>]
let WhenCallingComputeWith6ItShouldReturnFizz() = Assert.That(FizzBuzz.Compute 6, Is.EqualTo "Fizz")

[<Test>]
let WhenCallingComputeWith9ItShouldReturnFizz() = Assert.That(FizzBuzz.Compute 9, Is.EqualTo "Fizz")