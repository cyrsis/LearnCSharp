using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Events
{
    // A project's review status type.
    public enum ReviewStatus
    {
        Pending,
        Approved,
        Rejected,
    }

    // Hold information about a review event.
    public class ReviewEventArgs
    {
        public SoftwareProject Project;
        public int Priority;
    }

    // The event handler delegate type.
    public delegate void ReviewEventHandler(
        SoftwareProject project, ReviewEventArgs args);

    // Holds information about a software project.
    public class SoftwareProject
    {
        public string Name;
        public ReviewStatus Status;

        // Holds information about a registered event handler.
        private class ReviewHandlerInfo : IComparable<ReviewHandlerInfo>
        {
            public ReviewEventHandler Handler;
            public int Priority;

            // Compare the priorities of the two projects.
            // Used to sort by priority.
            public int CompareTo(ReviewHandlerInfo other)
            {
                return this.Priority.CompareTo(other.Priority);
            }
        }

        // The list of registered ewvire event handlers.
        private List<ReviewHandlerInfo> ReviewHandlers =
            new List<ReviewHandlerInfo>();

        // Register a new review event handler.
        public void AddReviewHandler(int priority,
            ReviewEventHandler handler)
        {
            // Add the review event handler information.
            ReviewHandlerInfo info = new ReviewHandlerInfo()
                { Priority = priority, Handler = handler };
            ReviewHandlers.Add(info);

            // Sort by priority.
            ReviewHandlers.Sort();
        }

        // Raise the event on the registered handlers
        // until one of them sets a project status.
        public void OnReviewEvent()
        {
            // Make the basic ReviewEventArgs object.
            ReviewEventArgs args = new ReviewEventArgs()
                { Project = this };

            foreach (ReviewHandlerInfo info in ReviewHandlers)
            {
                // If the status has been assigned, we're done.
                if (this.Status != ReviewStatus.Pending) break;

                // Save the event handler's priority in the
                // ReviewEventArgs and call the event handler.
                args.Priority = info.Priority;
                info.Handler(this, args);
            }
        }
    }
}
