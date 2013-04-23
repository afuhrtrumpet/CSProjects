using System.Drawing;

//TODO: Declare Shape as an abstract class
public abstract class Shape
{
    private int x1, x2, y1, y2;
    private Color myColor;
    /// <summary>
    /// Initializes the instance variables to their default values.
    /// </summary>
    public Shape() 
    { 
        setX1( 0 );
        setX2( 0 );
        setY1( 0 );
        setY2( 0 );
		myColor = Color.Black;
    }
    /// <summary>
    /// Initializes the instance variables.
    /// </summary>
    /// <param name="x1">The x coordinate of the shape's first point.</param>
    /// <param name="y1">The y coordinate of the shape's first point.</param>
    /// <param name="x2">The x coordinate of the shape's second point.</param>
    /// <param name="y2">The y coordinate of the shape's second point.</param>
    /// <param name="c">The color of the shape.</param>
    public Shape( int x1, int y1, int x2, int y2, Color c ) 
    { 
        setX1( x1 );
        setX2( x2 );
        setY1( y1 );
        setY2( y2 );
		setColor( c );
    }

    public void setX1( int x1 ) { this.x1 = ( x1 >= 0 ? x1 : 0 ); }
    public void setX2( int x2 ) { this.x2 = ( x2 >= 0 ? x2 : 0 ); }
    public void setY1( int y1 ) { this.y1 = ( y1 >= 0 ? y1 : 0 ); }
    public void setY2( int y2 ) { this.y2 = ( y2 >= 0 ? y2 : 0 ); }
	public void setColor(Color c) {this.myColor = c;}

    public int getX1() { return x1; }
    public int getX2() { return x2; }
    public int getY1() { return y1; }
    public int getY2() { return y2; }
	public Color getColor() { return myColor; }

//TODO: Declare an abstract draw method with a Graphics parameter
    /// <summary>
    /// Draws the shape.
    /// </summary>
    /// <param name="g">The graphics object which the shape will be drawn on.</param>
    public abstract void draw(Graphics g);
}
