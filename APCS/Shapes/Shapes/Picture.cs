using System;
using System.Drawing;
using System.Drawing.Imaging;

//TODO: Declare class BoX so that it inherits from Shape
public class Picture : Shape
{
    /// <summary>
    /// Initializes the instance variables.
    /// </summary>
    /// <param name="x1">The x coordinate of the picture's first point.</param>
    /// <param name="y1">The y coordinate of the picture's first point.</param>
    /// <param name="x2">The x coordinate of the picture's second point.</param>
    /// <param name="y2">The y coordinate of the picture's second point.</param>
    /// <param name="color">The color of the picture.</param>
    /// <param name="iMage">The image that is to be drawn.</param>
    private Image myIMage;
    public Picture(int x1, int y1, int x2, int y2, Image iMage, Color color)
        : base(x1, y1, x2, y2, color)
    //TODO: Force a call to the Shape constructor with 5 parameters.
    {
        myIMage = iMage;
        //The Java way...
        //super( x1, y1, x2, y2, Color.get_Red());
    }
    //TODO: Implement the drw method.
    /// <summary>
    /// Draws the picture.
    /// </summary>
    /// <param name="g">The graphics object which the picture is to be drawn on.</param>
    public override void draw(Graphics g)
    {
        //Edits the image's color scheme to fit the chosen color.
        ImageAttributes atts = new ImageAttributes();
        float[][] ptsArray = 
{ 
new float[] {1, 0, 0, 0, 0},
new float[] {0, 1, 0, 0, 0},
new float[] {0, 0, 1, 0, 0},
new float[] {0, 0, 0, 1, 0},
new float[] {-1* (1-(float)base.getColor().R / 255), -1 * (1-(float)base.getColor().G / 255), -1 * (1-(float)base.getColor().B / 255), 0, 1}
};
        ColorMatrix daMatrix = new ColorMatrix(ptsArray);
        atts.SetColorMatrix(daMatrix);
        //Sets top left corner to a point with the minimum x and minimum y value.
        Point topLeft = new Point();
        if (base.getX1() < base.getX2()) topLeft.X = base.getX1();
        else topLeft.X = base.getX2();
        if (base.getY1() < base.getY2()) topLeft.Y = base.getY1();
        else topLeft.Y = base.getY2();
        g.DrawImage(myIMage, new Rectangle(topLeft.X, topLeft.Y, Math.Abs(base.getX2() - base.getX1()), Math.Abs(base.getY2() - base.getY1())), 0, 0,
            myIMage.Width, myIMage.Height, GraphicsUnit.Pixel, atts);
    }
}
