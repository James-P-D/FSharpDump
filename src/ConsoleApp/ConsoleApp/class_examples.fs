module class_examples
open System

type Animal = class
   val Name : string
   val Height : float
   val Weight : float
 
   new (name, height, weight) =
      { Name = name; Height = height; Weight = weight;}
 
   member x.Run =
      printfn "%s Runs" x.Name
end

type Dog(name, height, weight) = 
    inherit Animal(name, height, weight)
 
    member x.Bark =
        printfn "%s Barks" x.Name

let do_class_examples() =
    let spot = new Animal("Spot", 20.5, 40.5)
    
    spot.Run
    
    let bowser = new Dog("Bowser", 20.5, 40.5)
    
    // Subclasses get every field and method
    // in the super class plus new ones
    bowser.Run
    bowser.Bark