using Common;
namespace Demo.Model
{
    public class FamilyMemberBuilder
    {

        private int rowIndex;
        private ChainElement chain;
        
        private readonly int SkullColumnIndex = 0;
        private readonly int FaceColumnIndex = 1;

        public FamilyMemberBuilder(int rowIndex)
        {
            this.rowIndex = rowIndex;
            this.chain = ChainElement.NullValue;
        }

        public void AddHair()
        {
            this.chain = new VisualHairy(this.rowIndex, this.chain);
        }

        public void AddEmotions()
        {
            this.chain = new VisualEmotional(this.rowIndex, this.chain);
        }

        public void AddBeard()
        {
            this.chain = new VisualBearded(this.rowIndex, this.chain);
        }

        public FamilyMember Build()
        {

            AddFace();
            AddSkull();

            return new FamilyMember(this.chain);

        }

        private void AddFace()
        {
            if (IsFaceMissing())
                this.chain = new VisualElement(this.rowIndex, this.FaceColumnIndex, this.chain);
        }

        private bool IsFaceMissing()
        {
            return this.chain.As<IEmotional>(null) == null;
        }

        private void AddSkull()
        {
            this.chain = new VisualElement(this.rowIndex, this.SkullColumnIndex, this.chain);
        }

    }
}