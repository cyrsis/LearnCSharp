using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Demo.Model
{
    public class Family
    {
        
        private IList<FamilyMember> members = new List<FamilyMember>();

        public void Add(FamilyMember member)
        {
            this.members.Add(member);
        }

        public Image ToBitmap()
        {
            
            IEnumerable<Image> memberImages = GetMemberImages();

            Image image = new ImageComposer().Compose(memberImages);
            
            DisposeMemberImages(memberImages);

            return image;

        }

        public void Each<T>(Action<T> operation, T defaultValue) where T : class
        {
            foreach (FamilyMember member in this.members)
                operation(member.As<T>(defaultValue));
        }

        private IEnumerable<Image> GetMemberImages()
        {
            return this.members.Select(m => m.As<VisualElement>(VisualElement.NullObject).ToBitmap()).ToList();
        }

        private void DisposeMemberImages(IEnumerable<Image> memberImages)
        {
            foreach (Image img in memberImages)
                img.Dispose();
        }

    }
}