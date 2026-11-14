
namespace C__Advanced.Delegates.FilterAndTransformNumbers
{
    public class Filter
    {
        #region Properties

        public FilterDelegate FilterMethod { get; set; }

        #endregion

        #region Constructor

        public Filter()
        {
            FilterMethod = IsEven;
        }

        #endregion

        #region Filtering Methods

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool GreaterThan10(int number)
        {
            return number > 10;
        }

        #endregion
    }
}
