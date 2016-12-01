using Common;
using Demo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private int bodyTypeIndex;
        private IList<Type> personBehaviors;
        private IList<Type> supportedBehaviors;

        private Family family;

        public MainWindow()
        {
            
            InitializeComponent();

            this.supportedBehaviors = new Type[] { typeof(IHairy), typeof(IBearded), typeof(IEmotional) };
            this.personBehaviors = new List<Type>();

            this.family = new Family();

        }

        private void AddFamilyMember(object sender, RoutedEventArgs e)
        {
            AddFamilyMember();
            OnFamilyChanged();
        }

        private void AddFamilyMember()
        {
            FamilyMember member = BuildFamilyMember();
            InitializeMemberBehaviors(member);
            this.family.Add(member);
        }

        private void InitializeMemberBehaviors(FamilyMember member)
        {
            InitialMemberHair(member);
            InitializeMemberBeard(member);
            InitializeMemberEmotions(member);
        }

        private void InitialMemberHair(FamilyMember member)
        {
            if (IsHairLong.IsChecked.Value)
                member.As<IHairy>(NullHairy.Instance).GrowHair();
        }

        private void InitializeMemberBeard(FamilyMember member)
        {
            if (IsBeardPresent.IsChecked.Value)
                member.As<IBearded>(NullBearded.Instance).GrowBeard();
        }

        private void InitializeMemberEmotions(FamilyMember member)
        {
            if (IsHappy.IsChecked.Value)
                member.As<IEmotional>(NullEmotional.Instance).BeHappy();
        }

        private FamilyMember BuildFamilyMember()
        {
            FamilyMemberBuilder builder = new FamilyMemberBuilder(bodyTypeIndex);
            AddMemberBehaviors(builder);
            return builder.Build();
        }

        private void AddMemberBehaviors(FamilyMemberBuilder builder)
        {
            AddHair(builder);
            AddBeard(builder);
            AddEmotions(builder);
        }

        private void AddHair(FamilyMemberBuilder builder)
        {
            if (this.personBehaviors.Contains(typeof(IHairy)))
                builder.AddHair();
        }

        private void AddBeard(FamilyMemberBuilder builder)
        {
            if (this.personBehaviors.Contains(typeof(IBearded)))
                builder.AddBeard();
        }

        private void AddEmotions(FamilyMemberBuilder builder)
        {
            if (this.personBehaviors.Contains(typeof(IEmotional)))
                builder.AddEmotions();
        }

        private void OnFamilyChanged()
        {
            System.Drawing.Image image = this.family.ToBitmap();
            this.FamilyImage.Source = CreateBitmapSource(image);
        }

        private BitmapSource CreateBitmapSource(System.Drawing.Image image)
        {

            MemoryStream stream = new MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            stream.Position = 0;

            BitmapImage bitmap = new BitmapImage();

            bitmap.BeginInit();
            bitmap.StreamSource = stream;
            bitmap.EndInit();

            return bitmap;

        }

        private void BodyTypeClick(object sender, RoutedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            string optionNumber = button.Name.Substring("Option".Length);
            this.bodyTypeIndex = Int32.Parse(optionNumber) - 1;
        }

        private void CheckBoxClick(object sender, RoutedEventArgs e)
        {
            
            CheckBox checkBox = sender as CheckBox;
            string typeName = checkBox.Name.Substring("Support".Length);
            Type type = this.supportedBehaviors.Where(t => t.Name == typeName).Single();
            
            if (checkBox.IsChecked.HasValue && checkBox.IsChecked.Value)
                this.personBehaviors.Add(type);
            else
                this.personBehaviors.Remove(type);
        
        }

        private void CutHair(object sender, RoutedEventArgs e)
        {
            this.Behave<IHairy>(h => h.CutHair(), NullHairy.Instance);
        }

        private void GrowHair(object sender, RoutedEventArgs e)
        {
            this.Behave<IHairy>(h => h.GrowHair(), NullHairy.Instance);
        }

        private void BeContent(object sender, RoutedEventArgs e)
        {
            this.Behave<IEmotional>(em => em.BeContent(), NullEmotional.Instance);
        }

        private void BeHappy(object sender, RoutedEventArgs e)
        {
            this.Behave<IEmotional>(em => em.BeHappy(), NullEmotional.Instance);
        }

        private void Shave(object sender, RoutedEventArgs e)
        {
            this.Behave<IBearded>(b => b.Shave(), NullBearded.Instance);
        }

        private void GrowBeard(object sender, RoutedEventArgs e)
        {
            this.Behave<IBearded>(b => b.GrowBeard(), NullBearded.Instance);
        }

        private void Behave<T>(Action<T> operation, T defaultValue) where T : class
        {
            this.family.Each<T>(operation, defaultValue);
            OnFamilyChanged();
        }
    }
}
