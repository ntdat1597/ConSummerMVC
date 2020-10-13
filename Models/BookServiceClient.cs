using ConSummerMVC.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConSummerMVC.Models
{
    public class BookServiceClient
    {
        BookServiceClient client = new BookServiceClient();

        public List<Book> getAllBook()
        {
            var list = (List < Book > client.GetBookList().toList());
            return list;
        }

    }
}