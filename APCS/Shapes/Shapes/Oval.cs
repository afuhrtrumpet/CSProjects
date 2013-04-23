using System;
using System.Drawing;

//TODO: Declare class MyOval so that it inherits from MyShape
public class Oval : Shape
{
    /// <summary>
    /// Initializes the instance variables.
    /// </summary>
    /// <param name="x1">The x coordinate of the oval's first point.</param>
    /// <param name="y1">The y coordinate of the oval's first point.</param>
    /// <param name="x2">The x coordinate of the oval's second point.</param>
    /// <param name="y2">The y coordinate of the oval's second point.</param>
    /// <param name="color">The color of the oval.</param>
	public Oval( int x1, int y1, int x2, int y2, Color color )
 	//TODO: Force a call to the MyShape constructor with 5 parameters.
        :base( x1, y1, x2, y2, color)
   { 
     //The Java way...
     //super( x1, y1, x2, y2, Color.get_Blue());
   }

	//TODO: Implement the draw method.
    /// <summary>
    /// Draws the oval.
    /// </summary>
    /// <param name="g">The graphics object which the oval is to be drawn on.</param>
    public override void  draw(Graphics g)
{
    g.DrawEllipse(new Pen(new SolidBrush(base.getColor()), .5F),
            new Rectangle(base.getX1(), base.getY1(), base.getX2() - base.getX1(), base.getY2() - base.getY1()));
}
    
}
