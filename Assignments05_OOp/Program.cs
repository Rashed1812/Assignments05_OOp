namespace Assignments05_OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Question 1 MCQ

            //Answer Of Question 1 (MCQ) 
            /*
            1.B
            2.A
            3.B
            4.B
            5.D
            6.A
            7.B
            8.B
            9.B
            10.C
             */

            #endregion

            #region Part02 Q1

            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();

            IRectangle rectangle = new Rectangle(4, 7);
            rectangle.DisplayShapeInfo();  
            
            #endregion
        }
    }
}
