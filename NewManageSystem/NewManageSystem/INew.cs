using System;
using System.Collections.Generic;
using System.Text;

namespace NewManageSystem
{
    interface INew
    {
        int Id { get; set; }
        string Title { get; set; }
        DateTime PublishDate { get; set; }
        string Author { get; set; }
        string Content { get; set; }
        float AverageRate { get; set; }
        string Display();
    }
}
