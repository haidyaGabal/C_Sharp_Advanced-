using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Delegates.FilterAndTransformNumbers
{
    public delegate bool FilterDelegate(int x);
    public delegate int TransformDelegate(int x);
}
