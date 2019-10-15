# CodeTest
<h3>Code Test for Edge-Sweets</h3>

<span>Given a list of points that make up a shape (all points inside the list are part of the shape), determine how many shapes you can fit inside a given size rectangle with a given amount of space inbetween each shape.</span>

<span>Example: The image below shows a rectangle (green) 50x50. The white rectangle next to it is 5x5.</span><br />
<img src="https://raw.githubusercontent.com/Edge-Sweets/CodeTest/master/images/Rectangles.PNG" width=250 ></img>


<span>The first shape should go in the bottom-left corner, as so: </span><br />
<img src="https://raw.githubusercontent.com/Edge-Sweets/CodeTest/master/images/Rectangles_inside.PNG" width=250 ></img>

<span>Determine how many shapes can fit inside the large rectangle, and set their starting points where they need to be, like so: </span><br />
<img src="https://raw.githubusercontent.com/Edge-Sweets/CodeTest/master/images/Rectangles_Filled.PNG" width=250 ></img>


The code test is the backend logic that would determine how to do the above example. There are sample shapes in the code test to work with. You should:

1. Determine how many shapes can fit.
2. Return a list of shapes complete with their starting points
3. Confirm that your method works for any variety of shape.

Notes:
- Assume shapes will be "rectangular". That is, no overlapping of shapes need to occur.
- Spacing includes spacing from the sides of the rectangle
- Bottom-left corner is 0,0
- Not all parts will fit exactly in the rectangle. Side spacing is minimum required spacing
