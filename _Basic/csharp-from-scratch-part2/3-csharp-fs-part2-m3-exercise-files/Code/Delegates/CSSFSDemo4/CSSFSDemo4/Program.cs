﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFSDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.Text = "Document text goes here";

            var blogPoster = new BlogPoster();
            var blogDelegate = new Document.SendDoc(blogPoster.PostToBlog);
            doc.ReportSendingResult(blogDelegate);

            var emailSender = new EmailSender();
            var emailDelegate = new Document.SendDoc(emailSender.SendEmail);
            doc.ReportSendingResult(emailDelegate);



        }
    }
}
