using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class CustomIterator : Iterator
    {
        public EmployeesCollection currentCollection;
        private int currentIndex = 0;
        private int nestedIndexLevel1 = 0;
        private int nestedIndexLevel2 = 0;
        private int nestedIndexLevel3 = 0;
        public CustomIterator(EmployeesCollection collectionItems)
        {
            currentCollection = collectionItems;
        }

        public object GetNext()
        {
            if (GetNextSubordinate((Employee)(currentCollection.GetItem(currentIndex))) != null)
                return GetNextSubordinate((Employee)(currentCollection.GetItem(currentIndex)));
            else
            {
                if (HasNext())
                {
                    currentIndex = currentIndex + 1;
                    if (GetNextSubordinate((Employee)(currentCollection.GetItem(currentIndex))) != null)
                        return GetNextSubordinate((Employee)(currentCollection.GetItem(currentIndex)));
                }
            }
            return null;
        }

        public object getFirst()
        {
            currentIndex = 0;
            return currentCollection.GetItem(0);
        }

        public object getLast()
        { 
            Employee lastEmployee = (Employee)getFirst();
            Employee nullableEmployee = (Employee)GetNext();
            while(nullableEmployee!=null)
            {
                lastEmployee = nullableEmployee;
                nullableEmployee = (Employee)GetNext();
            }
            return lastEmployee;
        }

        private bool HasNext()
        {
            return currentCollection.Count() > (currentIndex + 1);
        }
        private Employee GetNextSubordinate(Employee currentEmployee)
        {
            if (currentEmployee.subordinates.Count > nestedIndexLevel1)
            {
                if (currentEmployee.subordinates[nestedIndexLevel1].subordinates.Count > nestedIndexLevel2)
                {
                    if (currentEmployee.subordinates[nestedIndexLevel1].subordinates[nestedIndexLevel2].subordinates.Count > nestedIndexLevel3)
                    {
                        nestedIndexLevel3 = nestedIndexLevel3 + 1;
                        return currentEmployee.subordinates[nestedIndexLevel1].subordinates[nestedIndexLevel2].subordinates[nestedIndexLevel3-1];
                    }
                    nestedIndexLevel3 = 0;
                    nestedIndexLevel2 = nestedIndexLevel2 + 1;
                    return currentEmployee.subordinates[nestedIndexLevel1].subordinates[nestedIndexLevel2-1];
                }
                nestedIndexLevel2 = 0;
                nestedIndexLevel1 = nestedIndexLevel1 + 1;
                return currentEmployee.subordinates[nestedIndexLevel1-1];
            }
            nestedIndexLevel1 = 0;
            return null;
        }
        private void rebootIterator()
        {
            currentIndex = 0;
            nestedIndexLevel1 = 0;
            nestedIndexLevel2 = 0;
            nestedIndexLevel3 = 0;
        }
    }
}
