---

# DotNetInterviewTDD

A **Test-Driven Development (TDD) practice project** designed to prepare for real-world **.NET technical interviews** by enforcing foundational concepts through failing unit tests.

This repository contains **only tests at first**. Your job is to implement production code that satisfies them — one test at a time — using proper TDD (Red → Green → Refactor).

---

## 🎯 Purpose

This project is intentionally opinionated.

It helps you practice and internalize:

* Value vs reference types
* Immutability
* Interfaces & dependency injection
* Exception handling
* Async / await correctness
* LINQ deferred execution
* IDisposable patterns
* Equality & value objects

These are **core interview topics** for mid-to-senior .NET roles.

---

## 🧱 Solution Structure

```text
DotNetInterviewTDD/
│
├── DotNetInterviewTDD.sln
│
├── src/
│   └── DotNetInterviewTDD.Core/
│       └── DotNetInterviewTDD.Core.csproj
│       └── (your implementations go here)
│
└── tests/
    └── DotNetInterviewTDD.Tests/
        ├── DotNetInterviewTDD.Tests.csproj
        ├── ValueVsReferenceTests.cs
        ├── ImmutabilityTests.cs
        ├── InterfaceTests.cs
        ├── ExceptionTests.cs
        ├── AsyncTests.cs
        ├── LinqTests.cs
        ├── DisposableTests.cs
        └── EqualityTests.cs
```

---

## 🚀 Getting Started

### Prerequisites

* .NET SDK **8.0+**
* Any IDE (Rider, Visual Studio, VS Code)

### Clone the Repo

```bash
git clone https://github.com/your-username/DotNetInterviewTDD.git
cd DotNetInterviewTDD
```

### Run Tests (Expect Failure)

```bash
dotnet test
```

All tests should **fail initially**.
That’s intentional.

---

## 🔴 How to Practice (TDD Rules)

Follow this process **strictly** for maximum benefit:

1. Pick **one test file**
2. Run tests → 🔴 **RED**
3. Write the **minimum code** to pass → 🟢 **GREEN**
4. Refactor if needed
5. Commit
6. Move to the next test file

🚫 Do **not**:

* Skip ahead
* Add extra public methods
* Over-engineer
* “Future proof” code

Interviews reward **clarity and correctness**, not cleverness.

---

## 📚 What Each Test File Teaches

| Test File               | Concept                                  |
| ----------------------- | ---------------------------------------- |
| `ValueVsReferenceTests` | Memory behavior, copying vs shared state |
| `ImmutabilityTests`     | Immutable object design                  |
| `InterfaceTests`        | Dependency injection, abstractions       |
| `ExceptionTests`        | Guard clauses & domain exceptions        |
| `AsyncTests`            | Proper async/await usage                 |
| `LinqTests`             | Deferred vs eager execution              |
| `DisposableTests`       | Resource cleanup patterns                |
| `EqualityTests`         | Value equality vs reference equality     |

---

## 🧠 Interview Tips While Practicing

As you implement each feature, ask yourself:

* *How would I explain this in an interview?*
* *Why is this designed this way?*
* *What common mistakes do candidates make here?*

If you can **code it and explain it**, you own the concept.

---

## 🧪 Suggested Practice Schedule

**Weekday plan (30–60 min/day):**

* Day 1: Value vs Reference
* Day 2: Immutability
* Day 3: Interfaces & DI
* Day 4: Exceptions
* Day 5: Async / Await
* Day 6: LINQ + IDisposable
* Day 7: Equality

Repeat the cycle without looking at previous solutions.

---

## 🛠️ Extensions (Optional Challenges)

Once you finish the base tests, consider adding:

* Threading & locking tests
* ASP.NET Core Web API tests
* Entity vs Value Object modeling
* Caching & performance constraints
* Integration tests

These are **senior-level interview differentiators**.

---

## 📄 License

MIT — use freely for learning and interview prep.

---

## ⭐ Final Note

This repo is not about memorizing answers.
It’s about building **muscle memory** for real engineering conversations.

If you can pass these tests **from scratch**, you’re interview-ready.

Good luck — and enjoy the grind 🚀
