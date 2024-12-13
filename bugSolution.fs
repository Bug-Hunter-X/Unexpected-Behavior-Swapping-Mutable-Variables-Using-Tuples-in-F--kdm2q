let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // This will print 20 10 as expected

// Correct way to swap using tuples and mutable variables:
let swapTupleMutable (x, y) =
    let temp = x
    x <- y
    y <- temp
    (x, y)

let mutable x3 = 10
let mutable y3 = 20

let (x4, y4) = swapTupleMutable (x3, y3)
printf "%d %d" x4 y4 // This will print 20 10 as expected
printf "%d %d" x3 y3 // This will print 20 10 as expected

//Alternative approach
let swapTuple (x, y) = (y, x)
let (x2, y2) = swapTuple (10, 20)
printf "%d %d" x2 y2 // Prints 20 10 

//Demonstrates that tuple assignment does not modify the original variables in this case. 
let (x5, y5) = swapTuple (x3, y3)
printf "%d %d" x3 y3 // Prints 20 10 because swapTupleMutable modifies x3 and y3 
printf "%d %d" x5 y5 // Prints 20 10 