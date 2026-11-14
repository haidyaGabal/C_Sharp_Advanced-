
namespace C__Advanced.Delegates.FilterAndTransformNumbers
{
    public class Transform
    {
        #region Properties

        public TransformDelegate TransformMethod { get; set; }

        #endregion

        #region Constructor

        public Transform()
        {
            TransformMethod = DoubleNumber;
        }

        #endregion

        #region Transformation Methods

        public int DoubleNumber(int number)
        {
            return number * 2;
        }

        public int SquareNumber(int number)
        {
            return number * number;
        }

        #endregion
    }
}
