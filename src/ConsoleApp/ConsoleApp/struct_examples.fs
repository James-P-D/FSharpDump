module struct_examples
open System

type Rectangle = struct
    val Length : float
    val Width : float
    new (length, width) = {Length = length; Width = width}
end

let do_struct_examples() =
 
    let area(shape: Rectangle) = shape.Length * shape.Width
    let rect = new Rectangle(5.0, 6.0)
    let rect_area = area rect
    printfn "Area : %.2f" rect_area