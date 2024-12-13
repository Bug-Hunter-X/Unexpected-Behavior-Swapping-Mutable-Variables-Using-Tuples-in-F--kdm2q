let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // This will print 20 10 as expected

// But if you try to swap using tuples, you will get a compiler error

let swapTuple (x,y) = (y,x)
let x1 = 10
let y1 = 20
let (x2, y2) = swapTuple (x1, y1)
printf "%d %d" x2 y2 // This will print 20 10 as expected

// However if we modify the code in this way:
let mutable x3 = 10
let mutable y3 = 20

let swapTupleMutable (x, y) =
    (y, x)

let (x4,y4) = swapTupleMutable (x3,y3)
printf "%d %d" x4 y4 // This will print 20 10 as expected

// It appears to work but if you try this:
let (x5, y5) = swapTupleMutable (x3, y3)
printf "%d %d" x3 y3 // This will print 10 20

// The problem is that the swapTupleMutable function returns a new tuple, but it doesn't modify the original variables x3 and y3.  To fix this, you would need to use mutable variables inside the function, or use a different approach to swapping the values.