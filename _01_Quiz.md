# Polished Interview Questions & Answers (C# / .NET Basics)

---

## 1️⃣ What is an application (app)? What are different types of apps?

**Answer**
An **application** is a software program designed to solve a specific user problem or perform a task.

**Types of applications**

* **Desktop applications**
  Examples: VLC, Visual Studio, VS Code, games
* **Web applications**
  Examples: Gmail, YouTube
* **Console applications**
  Command-line based programs
* **Mobile applications**
  Android / iOS apps
* **Services / APIs**
  Background or server-side programs

---

## 2️⃣ What is a web server?

**Answer**
A **web server** is a software application that:

* Listens for HTTP requests
* Processes those requests
* Sends responses (HTML, JSON, files) to clients like browsers

It hosts **web applications**, not desktop apps.

---

## 3️⃣ What types of applications can be developed using .NET?

**Answer**

* Console applications
* Desktop applications (WinForms, WPF)
* Web applications (ASP.NET)
* Web APIs
* Mobile apps (via MAUI)
* Cloud services
* Games (via Unity using C#)

---

## 4️⃣ Difference between Visual Studio and VS Code?

**OR**
Difference between an IDE and a code editor?

**Answer**

**Visual Studio**

* Full-fledged **IDE**
* Built-in support for:

  * Writing code
  * Building
  * Debugging
  * Profiling and performance analysis
* Heavyweight but beginner-friendly

**VS Code**

* Lightweight **code editor**
* Requires extensions and manual setup
* Flexible and cross-platform
* Preferred by advanced users and polyglot developers

---

## 5️⃣ Difference between .NET Framework, .NET Core, and .NET?

**Answer**

**.NET Framework**

* Legacy platform
* Windows-only
* Tightly coupled to Windows APIs
* Web apps require IIS
* Cannot run on Linux or macOS

**.NET Core**

* Introduced in 2016
* Open-source
* Cross-platform (Windows, Linux, macOS)
* Introduced Kestrel web server
* Designed for cloud and containers

**.NET (5+)**

* Unified platform
* Successor to .NET Core
* Same runtime across platforms
* Current and future of .NET

---

## 6️⃣ Which .NET platform is legacy?

**Answer**
**.NET Framework**

---

## 7️⃣ Which web server does .NET Framework use?

**Answer**
**IIS (Internet Information Services)**

---

## 8️⃣ Which web server does .NET / .NET Core use?

**Answer**
**Kestrel**

---

## 9️⃣ Which web server is cross-platform?

**Answer**
**Kestrel**

---

## 🔟 Can Kestrel be used for desktop apps or games?

**Answer**
❌ No.
Kestrel is a **web server**, used only to host **web applications or APIs**.
It has no role in desktop apps or games.

---

## 1️⃣1️⃣ What is LTS and STS? Which do organizations prefer?

**Answer**

* **LTS (Long-Term Support)**

  * Supported for several years
  * Stable and secure
  * Preferred by enterprises
* **STS (Standard-Term Support)**

  * Shorter support lifecycle
  * Used for experimenting with new features

**Organizations usually prefer LTS.**

---

## 1️⃣2️⃣ What are the main components of the .NET platform? What are IL and CLR?

**Answer**

Execution flow:

```
C# Code → IL → CLR → Machine Code
```

* **IL (Intermediate Language)**
  Platform-independent bytecode generated at build time
* **CLR (Common Language Runtime)**
  The execution engine of .NET
  Responsible for:

  * JIT compilation
  * Memory management
  * Garbage collection
  * Security

---

## 1️⃣3️⃣ Can .NET support multiple programming languages? How?

**Answer**
Yes.

**Why it’s possible**

* All .NET languages compile to **IL**
* CLR executes IL, not the original language

Examples:

* C#
* F#
* VB.NET

This is why multiple languages can run on the same runtime.

---

## 1️⃣4️⃣ Keyboard shortcut to build a project in Visual Studio?

**Answer**

```
Ctrl + Shift + B
```

---

## 1️⃣5️⃣ What is Run with Debugging vs Run without Debugging?

**Answer**

* **Run with Debugging** → `F5`
  Runs app with debugger attached
* **Run without Debugging** → `Ctrl + F5`
  Runs app normally, faster startup

---

## 1️⃣6️⃣ What is the difference between Solution, Project, and .cs files?

**Answer**

* **Solution**
  Container for one or more projects
* **Project**
  Contains source code, references, and build settings
* **.cs files**
  Actual C# source code files

---

## 1️⃣7️⃣ What happens when we build an application?

**Answer**

* Source code is compiled
* IL is generated
* Output is produced as:

  * `.exe` (executable) or
  * `.dll` (library)

---

## 1️⃣8️⃣ What happens when we press F5?

Do we need to build manually before running?

**Answer**

* Visual Studio **automatically builds** the project if needed
* Then launches the application
* Attaches the debugger

Manual build is **not mandatory** before pressing `F5`.

---

## 1️⃣9️⃣ Difference between F5 and Ctrl + F5?

**Answer**

| Key       | Behavior                         |
| --------- | -------------------------------- |
| F5        | Build + Run **with debugger**    |
| Ctrl + F5 | Build + Run **without debugger** |

---

## Final interview one-liner (great closer)

> **.NET Framework is legacy and Windows-only.
> Modern .NET is cross-platform, open-source, and unified.**

