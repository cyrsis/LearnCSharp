//using FeatureToggle.Core;
//using FeatureToggle.Toggles;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Web;
//using MvcMusicStore.Models;

//namespace MvcMusicStore.Featuretoggles
//{
//    public class HomePagefeatureToggleUI : FeatureToggle.Core.AlwaysOnFeatureToggle //SqlFeatureToggle
//    {
//        private static HomePagefeatureToggleUI _current;
//        private static string _id = "";
//        public static HomePagefeatureToggleUI Current
//        {
//            get
//            {
//                if (_current == null)
//                {
//                    _current = new HomePagefeatureToggleUI();
//                }
//                return _current;
//            }
//        }

//        public void TurnOn()
//        {
//            SetValue(true);
//        }

//        public void TurnOff()
//        {
//            SetValue(false);
//        }

//        private void SetValue(bool toggleValue)
//        {
//            MusicStoreEntities db = new MusicStoreEntities();
//            var featureToggle = db.FeatureToggles.FindAsync(_id).Result;

//            featureToggle.Enabled = true;
//            db.Entry(featureToggle).State = EntityState.Modified;
//            db.SaveChangesAsync();
//        }
//    }
//}