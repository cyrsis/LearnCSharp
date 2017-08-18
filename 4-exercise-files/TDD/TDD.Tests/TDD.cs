using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Tests
{
   [TestClass]
   public class TDD
   {
      [TestMethod]
      public void MustPass()
      {
         int expected = 1;
         int actual = 1;
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void WhenProjectStartsProjectIsActive()
      {
         Project project = new Project();
         project.Start();
         Assert.IsTrue(project.IsActive);
      }

      [TestMethod]
      public void ProjectHasDuration()
      {
         DateTime start = DateTime.Now;
         Project project = new Project();
         project.Start(start);
         project.End(start.AddSeconds(60));
         Assert.AreEqual(60, project.Duration);
      }
      [TestMethod]
      public void ProjectDurationCanConsistOfMultipleStartsAndStops()
      {
         DateTime start = DateTime.Now;
         Project project = new Project();

         project.Start(start);
         project.End(start.AddSeconds(60));     //60

         project.Start(start.AddSeconds(120));  //240
         project.End(start.AddSeconds(360));


         project.Start(start.AddSeconds(380)); // 190
         project.End(start.AddSeconds(570));



         Assert.AreEqual(60 + 240+ 190, project.Duration);
      }

   }
}
