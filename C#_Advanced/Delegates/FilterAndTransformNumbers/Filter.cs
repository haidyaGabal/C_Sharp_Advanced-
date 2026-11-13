
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
            FilterMethod += GreaterThan10;
        }

        #endregion

        #region Filtering Methods

         bool IsEven(int number)
        {
            return number % 2 == 0;
        }

         bool GreaterThan10(int number)
        {
            return number > 10;
        }

        #endregion
    }
}
