# SetExampleProject

A minimal C# console app that demonstrates how sets work in both mathematics and code.

## What this demonstrates

In set theory, order and duplicates do not matter. A set is defined only by its unique elements.

- A = {1, 2, 3, 4}
- B = {4, 2, 4, 3, 1, 3}

Even though B repeats values and has a different order, both represent the same mathematical set:

- Unique(A) = {1, 2, 3, 4}
- Unique(B) = {1, 2, 3, 4}
- Therefore, A = B

The app uses `HashSet<int>` and `SetEquals` to validate this exact rule programmatically.

## Project structure

- `Program.cs`: console entry point and demo output
- `SetComparer.cs`: reusable set-equivalence logic
- `SetExampleProject.Tests/UnitTest1.cs`: xUnit tests for true/false and null-input behavior

## Run locally

```bash
dotnet run
```

Expected output:

```text
Are the sets the same? True
```

## Run tests

```bash
dotnet test
```

## Why this is valid math and valid code

- Math: sets ignore duplicates and order.
- Code: `HashSet<int>` stores unique items only.
- Comparison: `SetEquals` checks whether two sets contain exactly the same unique elements.

So the result `True` is both mathematically correct and programmatically correct.
