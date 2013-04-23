using System;
using System.Drawing;

//TODO: Declare class BoX so that it inherits from Shape
public class Box : Shape
{
    /// <summary>
    /// Initializes the instance variables.
    /// </summary>
    /// <param name="x1">The x coordinate of the box's first point.</param>
    /// <param name="y1">The y coordinate of the box's first point.</param>
    /// <param name="x2">The x coordinate of the box's second point.</param>
    /// <param name="y2">The y coordinate of the box's second point.</param>
    /// <param name="color">The color of the box.</param>
	public Box( int x1, int y1, int x2, int y2, Color color ) : base (x1, y1, x2, y2, color)
 	//TODO: Force a call to the Shape constructor with 5 parameters.
   {
     //The Java way...
     //super( x1, y1, x2, y2, Color.get_Red());
   }

	//TODO: Implement the drw method.
    /// <summary>
    /// Draws the box.
    /// </summary>
    /// <param name="g">The graphics object which the box is to be drawn on.</param>
    public override void draw(Graphics g)
    {
        //Sets top left corner to a point with the minimum x and minimum y value.
        Point topLeft = new Point();
        if (base.getX1() < base.getX2()) topLeft.X = base.getX1();
        else topLeft.X = base.getX2();
        if (base.getY1() < base.getY2()) topLeft.Y = base.getY1();
        else topLeft.Y = base.getY2();
        g.DrawRectangle(new Pen(new SolidBrush(base.getColor()), .5F), 
            new Rectangle(topLeft.X, topLeft.Y, Math.Abs(base.getX2() - base.getX1()), Math.Abs(base.getY2() - base.getY1())));
    }
}
