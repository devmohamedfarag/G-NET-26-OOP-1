#region Part 01

#region Question01
//Q1: Explain with code example how class and struct behave differently 

// Answer: The primary difference between a class and a struct is that classes are reference types, while structs are value types. 
// When you create an instance of a class, it is allocated on the heap, and a reference to that memory location is stored in the variable.
// When you create an instance of a struct, it is allocated on the stack, and the variable directly contains the data.

/* Class (Reference Type): When you assign a class instance to a new variable,
   you are copying the reference (memory address) to the object, not the actual data.
   Both variables point to the same memory location.*/

/*Struct(Value Type): When you assign a struct to a new variable, you are creating a complete, 
  independent copy of the data.*/

//public class PersonClass
//{
//public string Name;
//}

//// STRUCT Definition (Value Type)
//public struct PersonStruct
//{
//public string Name;
//}

//class Program
//{
//static void Main()
//{
//// --- Class Behavior ---
//PersonClass c1 = new PersonClass();
//c1.Name = "Alice";
//PersonClass c2 = c1;      // c2 references the SAME object as c1
//c2.Name = "Bob";          // Changing c2 changes c1

//Console.WriteLine($"Class: c1={c1.Name}, c2={c2.Name}");
//// Output: Class: c1=Bob, c2=Bob

//// --- Struct Behavior ---
//PersonStruct s1 = new PersonStruct();
//s1.Name = "Alice";
//PersonStruct s2 = s1;        // s2 is an INDEPENDENT COPY of s1
//s2.Name = "Bob";            // Changing s2 does NOT affect s1

//Console.WriteLine($"Struct: s1={s1.Name}, s2={s2.Name}");
//// Output: Struct: s1=Alice, s2=Bob
//}
//}
#endregion

#region Question02:
//Q2: Explain the difference between public and private access modifiers with an example. 

// Answer: The public access modifier allows members of a class to be accessed from any other code in the same assembly or another assembly that references it.
/* Example Public access modifier:
    class Person
    {
        public string Name;   // Public field
    }
    
    class Program
    {
        static void Main()
        {
            Person p = new Person();
            p.Name = "Mohamed";   // Accessible
            Console.WriteLine(p.Name);  // Accessible
        }
    }*/

// The private access modifier restricts access to members of a class to only within the class itself.
/* Example Private access modifier:
 class Person
 {
     private string Name;   // Private field

     public void SetName(string name)
     {
         Name = name;   // Accessible inside class
     }

     public string GetName()
     {
         return Name;   // Accessible inside class
     }
 }

 class Program
 {
     static void Main()
     {
         Person p = new Person();
         p.SetName("Ahmed");

         Console.WriteLine(p.GetName());  // Accessible

         // Console.WriteLine(p.Name);   Error (private)
     }
 }*/
#endregion

#region Question03:
// Q3: Describe the steps to create and use a class library in Visual Studio.
// Answer: 
// 1- Open Visual Studio and choose to Create a new project.
// 2- In the "Create a new project" window, search for "blank solution" and select the Blank Solution template. Name it appropriately (e.g., ClassLibraryProjects) and select Create.
// 3- In the Solution Explorer (usually on the right), right-click the solution and select Add > New Project.
// 4- Search for "class library", select the Class Library template (for C# or the language of your choice, targeting .NET or .NET Standard), and select Next.
// 5- Configure the project name (e.g., StringLibrary) and the target framework, then select Create.
// 6- In the default Class1.cs (or equivalent) file, add the code for your library's functionality. 
// 7- Build the library by selecting Build > Build Solution from the top menu, or by right-clicking the project in Solution Explorer and selecting Build. This generates the necessary.
// 8- To use the class library in another project, right-click on the target project in Solution Explorer, select Add > Reference, and then choose the Projects tab to add a reference to your class library.
// 9- After adding the reference, you can use the classes and methods from your class library in the target project by including the appropriate using directive (e.g., using StringLibrary;).
// 10- Finally, build and run your target project to see the functionality of the class library in action.

#endregion

#region Question04:
// Q4: What is a class library? Why do we use class libraries?

// Answer: A class library is a collection of classes, interfaces, and other reusable software components
//         in object-oriented programming that developers can incorporate into their own applications.
//         These libraries are typically compiled into a single binary file (such as a DLL in .NET) and provide pre-written, tested code to perform common tasks
//
//We use Class Librsries for several reasons:
// 1- Code Resuability: Class libraries allow developers to reuse code across multiple projects, reducing duplication and improving maintainability.
// 2- Maintainability: By centralizing common functionality in a class library, developers can easily update and maintain that code without having to modify each individual project that uses it.
// 3- Scalability: Class libraries can be designed to be modular and extensible, allowing developers to add new features or functionality without affecting existing code.
// 4- Team Development: Class libraries facilitate collaboration among developers by providing a shared codebase that can be easily accessed and used by multiple team members.
// 5- Better Project Organization: Class libraries help organize code into logical units, making it easier to navigate and understand the structure of a project.
#endregion'

#endregion