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


#endregion