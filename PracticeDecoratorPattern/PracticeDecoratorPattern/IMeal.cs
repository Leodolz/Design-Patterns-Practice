using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDecoratorPattern
{
    public interface IMeal
    {
        void DescribeIngredients();
        void DescribePrice();
        void DescribeAll();
    }
}
