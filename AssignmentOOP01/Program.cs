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

#endregion