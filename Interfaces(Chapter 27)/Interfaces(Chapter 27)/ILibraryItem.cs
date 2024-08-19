// Written by Jay Gunderson
// 08/18/2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Chapter_27_
{
    internal interface ILibraryItem
    {
        
        bool IsAvailable
        {
            get;
        }
        string Title
        {
            get;
            set;
        }

        string Author
        {
            get;
            set;
        }

        int PublicationYear
        {
            get;
            set;
        }


        void CheckOut();

        void ReturnItem();

        string GetInfo();
    }
}
