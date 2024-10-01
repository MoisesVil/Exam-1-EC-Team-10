using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_EC
{
    /// <summary>
    /// Class for a page
    /// </summary>
    public class Page
    {
        public int pageNum;
        public bool isBookmarked;

        /// <summary>
        /// Constructor to create a page
        /// </summary>
        /// <param name="pageNum">the page number</param>
        /// <param name="pageTxt">the page text</param>
        /// <param name="isBooked">whether or not the page is bookmarked</param>
        public Page(int pageNum, bool isBooked) 
        {
            this.pageNum = pageNum;
            isBookmarked = isBooked;
        }
    }
}
