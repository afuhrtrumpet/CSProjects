using System.Drawing;

//TODO: Declare class MyLine so that it inherits from MyShape
public class Line : Shape
{
    /// <summary>
    /// Initializes the instance variables.
    /// </summary>
    /// <param name="x1">The x coordinate of the box's first point.</param>
    /// <param name="y1">The y coordinate of the box's first point.</param>
    /// <param name="x2">The x coordinate of the box's second point.</param>
    /// <param name="y2">The y coordinate of the box's second point.</param>
    /// <param name="color">The color of the box.</param>
    public Line( int x1, int y1, int x2, int y2, Color color ) : base (x1, y1, x2, y2, color)
//TODO: Force a call to the MyShape constructor with 5 parameters.
    { 
        //The Java way...
        //super (x1, y1, x2, y2, Color.get_Green());
    }

//TODO: Implement the draw method.
    /// <summary>
    /// Draws the line.
    /// </summary>
    /// <param name="g">The graphics object which the line is to be drawn on.</param>
    public override void draw(Graphics g)
    {
        g.DrawLine(new Pen(new SolidBrush(base.getColor()), .5F),
            new Point(base.getX1(), base.getY1()), new Point(base.getX2(), base.getY2()));
    }
}
