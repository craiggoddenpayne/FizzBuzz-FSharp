module WhenTestingFizzBuzz

open NUnit.Framework

[<Test>]
let WhenCallingComputeWith1ItShouldReturn1() = Assert.That(FizzBuzz.Compute 1, Is.EqualTo 1)

[<Test>]
let WhenCallingComputeWith2ItShouldReturn2() = Assert.That(FizzBuzz.Compute 2, Is.EqualTo 2)