# Class and Object in OOP (C#)

## 1. What is a Class?

A **class** is a **blueprint or template** used to create objects.

It defines:
- what data an object will have
- what actions an object can perform

However, a class **does not hold real data until an object is created**.

### Real-World Analogy

| Real World | Programming |
|-------------|-------------|
| House blueprint | Class |
| Actual house | Object |

A blueprint only describes the house. The real house is built from it.

---

## 2. Example of Class Concept

Imagine a **Student system**.

Every student has:
- Name  
- Age  
- Marks  

And every student can:
- Study  
- Write exam  

So we create a **Student class** that defines these properties and actions.

The class only describes what a student should have.

---

## 3. What is an Object?

An **object** is a **real instance of a class**.

This means:
- When we create something using a class, it becomes an object.
- Objects store actual values.

### Example

Class → `Student`

Objects:

- Student1 (Aman, 20, 85)  
- Student2 (Sara, 19, 90)  
- Student3 (Ali, 21, 75)

All these students follow the same **Student class structure**, but their **data is different**.

---

## 4. Relationship Between Class and Object

A class can create **multiple objects**.

Example:

Class → `Student`

Objects created from it:
- student1
- student2
- student3
- student4

So we can say:

> Class = Design  
> Object = Real entity created from the design

---

## 5. Simple Real-Life Analogy

### Car Example

Class → `Car`

Properties:
- color
- model
- speed

Actions:
- start()
- stop()
- drive()

Objects:
- BMW
- Audi
- Tesla

Each car is an **object**, but all follow the **Car class structure**.

---

## 6. Class and Object in C#

### Class Example

```csharp
class Student
{
    public string name;
    public int age;
}
```

### Object Creation

```csharp
Student s1 = new Student();
Student s2 = new Student();
```

Here:

- `Student` → Class  
- `s1`, `s2` → Objects  

Each object stores its own data.

Example:

```csharp
s1.name = "Aman";
s2.name = "Sara";
```

Even though both objects come from the same class, they store **different values**.

---

## 7. Why Classes Are Important

Classes help to:

- Organize code  
- Create reusable structures  
- Represent real-world entities  
- Reduce code duplication  

Instead of writing the same variables again and again, we define them once in a class.

---

## 8. Why Objects Are Important

Objects allow us to:

- Store real data  
- Perform operations  
- Interact with other objects  

Without objects, classes are just designs.  
Objects make the program **functional**.

---

# Interview Definitions

### Class
A class is a blueprint or template used to create objects.

### Object
An object is an instance of a class that contains real data and behavior.

---

# Simple Understanding

Class = Design  
Object = Real thing created from the design

Example:

Class → Car  
Objects → BMW, Audi, Tesla