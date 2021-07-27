using System;

///<summary>Base Class</summary>
public class Shape
{
    ///<summary>Throws exception</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
///<summary>REctangle class inherits from Shape</summary>
public class Rectangle : Shape
    {
        private int width;
        private int height;
        ///<summary>Gets and sets width</summary>
        public int Width
        {
            get => width;
            set 
            {
                if (value < 0) throw new ArgumentException("Width must be greater than or equal to 0");
                else width = value;
            }
        }
        ///<summary>Gets and sets Height</summary>
        public int Height
        {
            get => height;
            set
            {
                if (value < 0) throw new ArgumentException("Height must be greater than or equal to 0");
                else height = value;
            }
        }
        ///<summary>Returns the area of the rectangle</summary>
        public new int Area()
        {
            return height * width;
        }
        ///<summary>Overrides ToString for Rectangle</summary>
        public override string ToString() => $"[Rectangle] {this.width} / {this.height}";
   


    }